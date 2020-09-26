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
    public partial class Main_ADD : Form
    {
        static String strConn = "Server=223.195.109.35;Database=bosl95;Uid=bosl95;Pwd=1234";
        MySqlConnection conn = new MySqlConnection(strConn);

        Form_MAIN main;

        public Main_ADD(Form_MAIN temp)
        {
            InitializeComponent();
            main = temp;
            conn.Open();
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

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox_detail.Text == "" || textBox_amount.Text == "" || (checkBox.Checked == false && (CB_bankname.Text == "" || CB_account.Text == "")) || comboBox_type.Text == "" || comboBox_category.Text == "")
            {
                MessageBox.Show("공백란이 존재합니다.");
                return;
            }
            
            string[] time = dateTimePicker_time.Value.ToString().Split(' ');
            if(time[1] == "오후")
            {
                string[] temp_time = time[2].Split(':');
                temp_time[0] = (Int32.Parse(temp_time[0]) + 12).ToString();
                if(temp_time[0] == "24")
                {
                    temp_time[0] = "12";
                }
                time[2] = temp_time[0] + ":" + temp_time[1] + ":" + temp_time[2];
            }
            else
            {
                string[] temp_time = time[2].Split(':');
                if(temp_time[0] == "12")
                {
                    temp_time[0] = "00";
                }
                time[2] = temp_time[0] + ":" + temp_time[1] + ":" + temp_time[2];
            }
            string sql = "INSERT INTO LOG VALUES ('" + dateTimePicker.Value.ToShortDateString()+" " + time[2] + "','"
               + textBox_detail.Text + "','"
               + textBox_amount.Text + "','"
               + CB_account.Text + "','"
               + comboBox_type.Text + "','"
               + comboBox_category.Text + "')";
            MessageBox.Show(dateTimePicker.Value.ToShortDateString() + " " + time[2]);
            Callcmd(sql);

        
                if (comboBox_type.Text == "수입" || comboBox_type.Text == "저축")
                {
                    sql = "UPDATE BANK SET B_sum=B_sum+'"+textBox_amount.Text+"' WHERE B_account='" + CB_account.Text + "';";
                    Callcmd(sql);
                }
                else
                {
                    sql = "UPDATE BANK SET B_sum=B_sum-'" + textBox_amount.Text + "' WHERE B_account='" + CB_account.Text + "';";
                    Callcmd(sql);
                }
            main.Readlog();
            textBox_amount.Text = textBox_detail.Text = "";

        }
        //DB에 정보를 저장, 출금통장만 LOG DB에 안들어감     
        // 하나라도 공백이 있을시 저장x

        private void comboBox_type_TextChanged(object sender, EventArgs e)
        {
            label_category.Text = "카테고리";
            comboBox_category.Items.Clear();    //일단 콤보박스 비우고
            if (comboBox_type.Text != "")
            {
                if (comboBox_type.Text == "수입")
                {
                    comboBox_category.Items.Add("급여");
                    comboBox_category.Items.Add("용돈");
                    comboBox_category.Items.Add("사업 수입");
                }   //수입 카테고리 추가
                else if (comboBox_type.Text == "지출")
                {
                    comboBox_category.Items.Add("식사");
                    comboBox_category.Items.Add("카페/간식");
                    comboBox_category.Items.Add("술/유흥");
                    comboBox_category.Items.Add("의복/미용");
                    comboBox_category.Items.Add("교통");
                    comboBox_category.Items.Add("주거/통신");
                    comboBox_category.Items.Add("생활");
                    comboBox_category.Items.Add("문화/여가");
                    comboBox_category.Items.Add("여행/숙박");
                    comboBox_category.Items.Add("교육");
                }   //지출 카테고리 추가
                else if (comboBox_type.Text == "저축")
                {
                    comboBox_category.Items.Add("보험");
                    comboBox_category.Items.Add("적금");
                }   //저축 카테고리 추가
                comboBox_category.Enabled = true;
            }
        }

        private void Main_ADD_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Show();
        }

        private void CB_bankname_Click(object sender, EventArgs e)  //출금 통장 콤보박스 클릭시
        {
            string sql = "SELECT B_name FROM BANK WHERE MEM_id='" + main.id + "'";
            MySqlDataReader rdr = Readercmd(sql);

            CB_bankname.Items.Clear(); //콤보박스 Clear

            while (rdr.Read())
            {
                string B_name = rdr["B_name"].ToString();

                for (int i = 0; i < CB_bankname.Items.Count; i++)
                {
                    if (CB_bankname.Items[i].ToString() == B_name)
                    { B_name = "중복"; break; }
                }  //중복된 통장 이름 발견

                if (B_name == "중복")
                    break;
                else
                    CB_bankname.Items.Add(B_name);
            }
            rdr.Close();
            //회원이 가지고 있는 통장 읽기  & 중복되는 통장 이름 제거
        }

        private void CB_bankname_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT B_account FROM BANK WHERE MEM_id='" + main.id + "' and B_name='" + CB_bankname.Text + "'";
            MySqlDataReader rdr = Readercmd(sql);

            CB_account.Items.Clear(); //콤보박스 Clear
            while (rdr.Read())
            {
                CB_account.Items.Add(rdr["B_account"].ToString());
            }           rdr.Close();      //이 출금통장과 연관된 계좌번호 읽기
        }

        private void checkBox_Click(object sender, EventArgs e)
        {
            if (checkBox.Checked == true)
            {
                CB_bankname.Enabled = false;
                CB_account.Enabled = false;
            }
            else
            {
                CB_bankname.Enabled = true ;
                CB_account.Enabled = true;
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Main_ADD_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void Main_ADD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
