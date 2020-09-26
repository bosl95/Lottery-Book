using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.Common;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class MAIN_CARDNBANK : Form
    {
        static String strConn = "Server=223.195.109.35;Database=bosl95;Uid=bosl95;Pwd=1234;";
        MySqlConnection conn = new MySqlConnection(strConn);    //Connection

        Form_MAIN main;
        ListViewItem item;

        public MAIN_CARDNBANK(Form_MAIN temp)
        {
            InitializeComponent();
            main = temp;
            conn.Open();
            Bank_read();
            //Read("BANK"); //통장 라디오 버튼이 활성화 된 체로 시작
        }

        private MySqlDataReader Readercmd(string sql)
        {
            conn.Close();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            return rdr;
        }

        private void Callcmd(string sql)
        {
            conn.Close();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        private void Bank_insert(ListViewItem temp_item)
        {
            string sql = null;

            sql = "INSERT INTO BANK(B_name,B_account,B_attribute,B_sum,MEM_id) VALUES ('"
            + temp_item.SubItems[0].Text + "','"
            + temp_item.SubItems[1].Text + "','"
            + temp_item.SubItems[2].Text + "','"
            + temp_item.SubItems[3].Text + "','"
            + main.id + "');";

            Callcmd(sql);
        }   // DB에 카드/통장  VALUE를 삽입
        //**계좌번호 겹치면 안되게 하기 함수 끝냄

        private void Card_insert(ListViewItem temp_item)
        {
            string sql = null;
            sql = "SELECT B_account FROM BANK WHERE B_name='" + temp_item.SubItems[2].Text + "' AND MEM_id='" + main.id + "';";
            MySqlDataReader rdr = Readercmd(sql);
            rdr.Read();
            sql = "INSERT INTO CARD(C_company,C_name,B_account,C_duedate,MEM_id) VALUES ('"
              + temp_item.SubItems[0].Text + "','"
              + temp_item.SubItems[1].Text + "','"
              + rdr[0].ToString() + "','"
              + temp_item.SubItems[3].Text + "','"
              + main.id + "');";
            rdr.Close();

            Callcmd(sql);
        }
        //**계좌번호or  카드이름 겹치면 안되게 하기 함수 끝냄


        private void Bank_read()
        {
            string sql = "SELECT * FROM  BANK";
            MySqlDataReader rdr = Readercmd(sql);
            listView_bank.Items.Clear();
            while (rdr.Read())
            {
                item = new ListViewItem(rdr[0].ToString());
                item.SubItems.Add(rdr[1].ToString());
                item.SubItems.Add(rdr[2].ToString());
                item.SubItems.Add(rdr[3].ToString());

                listView_bank.Items.Add(item);
            }
            rdr.Close();
        }

        private void Card_read()
        {
            listView_card.Items.Clear();
            string sql = "SELECT * FROM  CARD";
            MySqlDataReader rdr = Readercmd(sql);

            while (rdr.Read())  // 카드 리스트뷰에 카드사, 카드명, 연계통장, 결제일을 읽음
            {
                item = new ListViewItem(rdr[0].ToString());
                item.SubItems.Add(rdr[1].ToString());
                item.SubItems.Add(rdr[2].ToString());
                item.SubItems.Add(rdr[3].ToString());

                listView_card.Items.Add(item);
            }
            rdr.Close();


            // 연계계좌만 통장이름으로 바꿔주기
            for (int j = 0; j < listView_card.Items.Count; j++)
            {
                sql = "SELECT B_name FROM BANK WHERE MEM_id='" + main.id + "' and B_account='" + listView_card.Items[j].SubItems[2].Text + "';";
                MySqlDataReader temp_rdr = Readercmd(sql);

                while (temp_rdr.Read())
                    listView_card.Items[j].SubItems[2].Text = temp_rdr[0].ToString();

            }
            rdr.Close();
        }

        private void Delete()
        {
            string sql = null;
            if (rB_bank.Checked) // 통장 삭제 
            {
                //연동된 카드가 있으면 삭제 불가
                string B_account = listView_bank.FocusedItem.SubItems[1].Text;    // 선택된 통장의 계좌번호 get       
                sql = "SELECT *  FROM CARD WHERE MEM_id='" + main.id + "' AND B_account='" + B_account + "';";
                MySqlDataReader rdr = Readercmd(sql);
                if (rdr.Read())
                {
                    MessageBox.Show("연계된 카드가 존재하여 삭제할 수 없습니다.");
                    rdr.Close();
                    return;
                }
                sql = "DELETE FROM BANK WHERE MEM_id='" + main.id + "' AND B_account='" + B_account + "';";
                Callcmd(sql);
            }
            else
            {
                string C_name = listView_card.FocusedItem.SubItems[1].Text;
                sql = "DELETE FROM CARD WHERE MEM_id='" + main.id + "'AND C_name='" + C_name + "';";
            }
            Callcmd(sql);
        }

        private void MAIN_CARDNBANK_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
            main.Show();
        }   // cardbank 폼이 꺼지면 main 폼이 다시 열림

        private void rB_bank_Click(object sender, EventArgs e)
        {
            panel_card.Visible = false;
            panel_cardlist.Visible = false;
            Bank_read();
        }   //통장 라디오 버튼 클릭시 카드 관련 패널을 숨기고, 통장 리스트뷰를 읽어옴

        private void rB_card_Click(object sender, EventArgs e)
        {
            panel_card.Visible = true;
            panel_cardlist.Visible = true;
            Card_read();
        }

        private void checkBox_Click(object sender, EventArgs e)
        {
            if (checkBox.Checked)
                CB_duedate.Enabled = false;     //체크박스 체크시 결제일 Enable false
            else
                CB_duedate.Enabled = true;
        }

        private void btn_add_Click(object sender, EventArgs e) //추가 버튼
        {

            if (rB_bank.Checked)
            {
                if (textBox_bankname.Text == "" || textBox_accountnubmer.Text == "" || comboBox_attribute.Text == "" || textBox_sum.Text == "")
                    return;

              /*  for (int i = 0; i < listView_bank.Items.Count; i++)
                {
                    if (textBox_bankname.Text == listView_bank.Items[i].SubItems[0].Text)
                    {
                        {
                            MessageBox.Show("통장 이름이 중복되었습니다.");
                            return;
                        }
                    }   //통장 이름이 겹칠 경우
                }*/

                item = new ListViewItem(textBox_bankname.Text);
                item.SubItems.Add(textBox_accountnubmer.Text);
                item.SubItems.Add(comboBox_attribute.Text);
                item.SubItems.Add(textBox_sum.Text);
                Bank_insert(item);
                textBox_bankname.Text = textBox_accountnubmer.Text = comboBox_attribute.Text = textBox_sum.Text = textBox_sum.Text = "";
                Bank_read();
            }   // 통장 라디오 버튼이 체크시

            else
            {
                if (CB_cardcompany.Text == "" || textBox_cardname.Text == "" || CB_bankname.Text == "")
                    return;

                for (int i = 0; i < listView_card.Items.Count; i++)
                {
                    if (textBox_cardname.Text == listView_card.Items[i].SubItems[0].Text)
                    {
                        {
                            MessageBox.Show("카드 이름이 중복되었습니다.");
                            return;
                        }
                    }   // 카드 이름이 겹칠 경우
                }

                item = new ListViewItem(CB_cardcompany.Text);
                item.SubItems.Add(textBox_cardname.Text);
                item.SubItems.Add(CB_bankname.Text);    //통장이름을 입력받았으므로 sql을 통해 계좌번호를 찾아 카드테이블에 저장
                item.SubItems.Add(CB_duedate.Text);
                Card_insert(item);
                CB_cardcompany.Text = textBox_cardname.Text = CB_bankname.Text = CB_duedate.Text = "";
                Card_read();
            }   // 카드 라디오 버튼 체크시 
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Delete();
            if (rB_bank.Checked)
                Bank_read();
            else
                Card_read();
        }

        private void CB_bankname_Click(object sender, EventArgs e)
        {
            //통장테이블에서 계좌번호 읽어서 연계통장을 콤보박스에  넣기
            string sql = "SELECT B_name FROM BANK WHERE MEM_id='" + main.id + "'";
            MySqlDataReader rdr = Readercmd(sql);

            CB_bankname.Items.Clear(); //콤보박스 Clear
            while (rdr.Read())
                CB_bankname.Items.Add(rdr["B_name"].ToString());
            rdr.Close();

            if (CB_bankname.Items.Count != 0)     //연계계좌 콤보박스가 비어있지않으면 활성화
                CB_bankname.Enabled = true;
            else  //연계계좌 콤보박스가 비어있으면 비활성화
            {
                MessageBox.Show("연계할 통장이 없습니다!");
                CB_bankname.Enabled = false;
            }
        }
    }
}
