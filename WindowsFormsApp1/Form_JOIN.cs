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
    public partial class Form_JOIN : Form
    {
        static String strConn = "Server=223.195.109.35;Database=bosl95;Uid=bosl95;Pwd=1234;";
        MySqlConnection conn = new MySqlConnection(strConn);    //Connection
        bool idcheck; // id 중복 check 변수, 초기값은 false

        public Form_JOIN()
        {
            InitializeComponent();
        }

        private void Insert()   // 회원 정보 DB 저장 함수
        {
            try
            {
                conn.Open();    //connection  오픈
                String sql = "INSERT INTO MEMBER VALUES ('" + textBox_id.Text + "','" + textBox_pwd.Text + "','" + textBox_name.Text + "','" + textBox_cash.Text +"')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        } 

        private void SelectData()       //  ID 조회 함수, ID가 이미 있으면 idcheck 가 false
        {
           
            try
            {
                conn.Open();
                string sql = "SELECT id FROM MEMBER WHERE id='" + textBox_id.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
             
                if (rdr.Read())
                    idcheck = false;    // 값이 들어가있으면 아이디 중복이므로 false
                else 
                    idcheck = true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)  // Form2 취소 버튼
        {
            Close();
        }

        private void button_signup_Click(object sender, EventArgs e) // 회원 가입 버튼
        {
            if( textBox_id.Text == "" || textBox_pwd.Text == "" || textBox_name.Text == "" || textBox_cash.Text == "")
            {
                MessageBox.Show("공백란이 존재합니다.");
                return;
            }
            else if(idcheck == false)
            {
                MessageBox.Show("ID 중복 확인이 필요합니다.");
                return;
            }

            Insert();
            MessageBox.Show("Congratulations on joining!");
            Close();
        }

        private void button_check_Click(object sender, EventArgs e) // ID 중복 확인 버튼
        {
            if(textBox_id.Text == "")
            {
                MessageBox.Show("ID가 입력되지않았습니다!");
                return;
            }   // ID칸 공백시 실행되지않음
          
            SelectData();

            if (!idcheck)
            {
                MessageBox.Show("아이디가 중복되었습니다.");
                textBox_id.Text = "";
            }
            else
            {
                MessageBox.Show( "아이디가 사용가능합니다.");
            }
        }

       
    }
}
