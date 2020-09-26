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
    public partial class Form_LOGIN : Form
    {
        static String strConn = "Server=223.195.109.35;Database=bosl95;Uid=bosl95;Pwd=1234;";
        MySqlConnection conn = new MySqlConnection(strConn);    //Connection

        public Form_LOGIN()
        {
            InitializeComponent();
        }

        private void Confirm()  // 회원 가입된 사용자 확인 함수
        {
            try
            {
                conn.Open();
                string sql = "SELECT id,pwd FROM MEMBER WHERE id='" + textbox_id.Text + "'AND pwd='" + textBox_pwd.Text + "'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (!rdr.Read()) // 회원 정보가 없거나 잘못 입력되었을경우 로그인 실패 false
                {
                    MessageBox.Show("존재하지 않는 회원 또는 회원 정보가 잘못 입력되었습니다.");
                }
                else
                {
                    Form_MAIN form_main = new Form_MAIN(this);
                    form_main.Show();
                    this.Hide();            //메인 스레드인 LOGIN 폼을 숨기고 메인폼을 SHOW
                } // 정보를 제대로 입력시 로그인 성공
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

       
        private void button_join_Click(object sender, EventArgs e)  // 회원가입 버튼 
        {
            Form_JOIN s = new Form_JOIN();
            s.ShowDialog();
        }

        private void button_cancle_Click(object sender, EventArgs e) // Cancle 버튼
        {
            Close();
        }

        private void button_confirm_Click(object sender, EventArgs e)   // Confirm 버튼
        {
            if (textbox_id.Text == "" || textBox_pwd.Text == "")
            {
                MessageBox.Show("공백란이 존재합니다.");
                return;
            }
            Confirm();
        }

        private void Form_LOGIN_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void Form_LOGIN_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (textbox_id.Text == "" || textBox_pwd.Text == "")
                {
                    MessageBox.Show("공백란이 존재합니다.");
                    return;
                }
                Confirm();
            }
            else if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
