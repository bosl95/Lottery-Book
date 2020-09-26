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
    public partial class MAIN_modify : Form
    {
        static String strConn = "Server=223.195.109.35;Database=bosl95;Uid=bosl95;Pwd=1234";
        MySqlConnection conn = new MySqlConnection(strConn);

        Form_MAIN main;
        ListViewItem item;

        public MAIN_modify(Form_MAIN temp, ListViewItem temp_item)
        {
            main = temp;
            item = temp_item;
            InitializeComponent();
            textBox_detail.Text= temp_item.SubItems[1].Text;
            if (temp_item.SubItems[2].Text != "")
                textBox_amount.Text = temp_item.SubItems[2].Text;
            else
                textBox_amount.Text = temp_item.SubItems[3].Text;

        }
        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            //item.SubItems[0].Text = DateTime.Parse(dateTimePicker.Text).ToString("yyyy-MM-dd");
            if (textBox_detail.Text == "" || textBox_amount.Text == "" || comboBox_type.Text == "" || comboBox_category.Text == "")
            {
                MessageBox.Show("공백이 존재합니다!");
                return;
            }

            if (checkBox.Checked)    //현금일경우
            {
                CB_bankname.Text = "";
                CB_account.Text = "";
            }

            string[] time = item.SubItems[0].Text.Split(' ');
            if (time[1] == "오후")
            {
                string[] temp_time = time[2].Split(':');
                temp_time[0] = (Int32.Parse(temp_time[0]) + 12).ToString();
                if (temp_time[0] == "24")
                {
                    temp_time[0] = "12";
                }
                time[2] = temp_time[0] + ":" + temp_time[1] + ":" + temp_time[2];
            }
            else
            {
                string[] temp_time = time[2].Split(':');
                if (temp_time[0] == "12")
                {
                    temp_time[0] = "00";
                }
                time[2] = temp_time[0] + ":" + temp_time[1] + ":" + temp_time[2];
            }

            string sql = "UPDATE LOG SET L_detail='" + textBox_detail.Text + "', L_amount='" + textBox_amount.Text +  "', B_account='" + CB_account.Text + "', L_type='" + comboBox_type.Text + "', L_category='" + comboBox_category.Text + "' WHERE L_date='" + time[0] + " " + time[2] + "'";
            main.Callcmd(sql);

            main.Readlog();
            Close();
        }

        private void CB_bankname_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT B_account FROM BANK WHERE MEM_id='" + main.id + "' and B_name='" + CB_bankname.Text + "';";
            MySqlDataReader rdr = main.Readercmd(sql);

            CB_account.Items.Clear(); //콤보박스 Clear
            while (rdr.Read())
            {
                CB_account.Items.Add(rdr["B_account"].ToString());
            }
            rdr.Close();      //이 출금통장과 연관된 계좌번호 읽기
        }

        private void CB_bankname_Click(object sender, EventArgs e)
        {
            string sql = "SELECT B_name FROM BANK WHERE MEM_id='" + main.id + "'";
            MySqlDataReader rdr = main.Readercmd(sql);

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
        }

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

        private void checkBox_Click(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                CB_bankname.Text = CB_account.Text = "";
                CB_bankname.Enabled = CB_account.Enabled = false;
            }
        }   //현금 체크박스가 체크시 통장과 계좌 콤보박스 비활성화


        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked == true)
            {
                CB_bankname.Items.Clear();
                CB_bankname.Enabled = false;
                CB_account.Items.Clear();
                CB_account.Enabled = false;
            }
            else
            {
                CB_bankname.Enabled = true; ;
                CB_account.Enabled = true; ;
            }
        }
    }
}
