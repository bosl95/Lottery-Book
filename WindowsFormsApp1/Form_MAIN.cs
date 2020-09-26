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
    public partial class Form_MAIN : Form
    {
        static String strConn = "Server=223.195.109.35;Database=bosl95;Uid=bosl95;Pwd=1234;";
        MySqlConnection conn = new MySqlConnection(strConn);    //Connection

        Form_LOGIN form_login;  //생성자의 Form_LOGIN타입 매개변수를 받을 객체 
        public string id;

        public Form_MAIN(Form_LOGIN temp_login)
        {
            InitializeComponent();
            form_login = temp_login;
            id = temp_login.textbox_id.Text;    //아이디를 받아옴

            Readlog();
            /*  try
              {
                  conn.Open();
                  string sql = "SELECT name FROM MEMBER WHERE id='" + temp_login.textbox_id.Text + "'";  //id가 있으면
                  MySqlCommand cmd = new MySqlCommand(sql, conn);
                  MySqlDataReader rdr = cmd.ExecuteReader();
              }
              catch(Exception e)
              {
                  Console.WriteLine(e.StackTrace);
              }
              conn.Close();*/
            //ID로 회원 정보 불러오기
        }

        public MySqlDataReader Readercmd(string sql)
        {
            conn.Close();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            return rdr;
        }

        public void Callcmd(string sql)
        {
            conn.Close();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        private void Form_MAIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_login.Close(); // MAIN 폼 종료시 HIDE 해놨던 메인스레드 LOGIN 폼을 같이 CLOSE
        }

        private void Form_MAIN_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            label_date.Text = DateTime.Now.ToString("yyyy-MM");
        }

        private void label_date_TextChanged(object sender, EventArgs e)
        {
            Readlog();
            Drawchart();
        } // 월별로 리스트뷰를 읽어옴

        private void button_left_Click(object sender, EventArgs e)
        {
            string[] date = label_date.Text.Split('-');
            int temp_date;

            if (date[1] == "01")
            {
                temp_date = Int32.Parse(date[0]);
                label_date.Text = (--temp_date).ToString("D4") + "-12";
            } // 1월 이라면 12월을 넣어주고 년도 -1
            else
            {
                temp_date = Int32.Parse(date[1]);
                label_date.Text = date[0] + "-" + (--temp_date).ToString("D2");
            } // 1월이 아니라면 월을 -1해줌

        }   //월별 라벨에 대한 왼쪽 버튼

        private void button_right_Click(object sender, EventArgs e)
        {
            string[] date = label_date.Text.Split('-');
            int temp_date;

            if (date[1] == "12")
            {
                temp_date = Int32.Parse(date[0]);
                label_date.Text = (++temp_date).ToString("D4") + "-01";
            } // 12월 이라면 1월을 넣어주고 년도 +1
            else
            {
                temp_date = Int32.Parse(date[1]);
                label_date.Text = date[0] + "-" + (++temp_date).ToString("D2");
            } // 12월이 아니라면 월을 +1해줌

        }   //월별 라벨에 대한 왼쪽 버튼

        private void Form_MAIN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Main_ADD add = new Main_ADD(this);
            add.Show();
            //this.Hide();        // ADD폼을 열고 MAIN 폼을 숨김
        }


        public void Readlog()
        {
            string sql = "SELECT * FROM LOG WHERE L_date LIKE '" + label_date.Text + "-%'";
            MySqlDataReader rdr = Readercmd(sql);
            listView.Items.Clear();

            while (rdr.Read())
            {
                ListViewItem item = new ListViewItem(DateTime.Parse(rdr[0].ToString()).ToString());

                for (int i = 1; i < 6; i++)
                {
                    if (i < 2)
                        item.SubItems.Add(rdr[i].ToString());
                    else if (i == 2)
                    {
                        if (rdr[i + 1].ToString() == "") // 계좌번호가 없는경우 -> 현금인경우
                        {
                            item.SubItems.Add(rdr[i].ToString());
                            item.SubItems.Add("");
                        }
                        else
                        {
                            item.SubItems.Add("");
                            item.SubItems.Add(rdr[i].ToString());
                        }
                        continue;
                    } // 금액을 현금인덱스에 넣을지 카드 인덱스에 넣을지 체크
                    else if (i == 3)
                    {
                        item.SubItems.Add(rdr[i].ToString());
                        item.SubItems.Add(rdr[i].ToString());
                    }
                    else
                        item.SubItems.Add(rdr[i].ToString());
                }
                listView.Items.Add(item);
            }
            rdr.Close();

            for (int j = 0; j < listView.Items.Count; j++)
            {
                sql = "SELECT B_name FROM BANK WHERE MEM_id='" + id + "' and B_account='" + listView.Items[j].SubItems[4].Text + "';";
                MySqlDataReader temp_rdr = Readercmd(sql);

                while (temp_rdr.Read())
                    listView.Items[j].SubItems[4].Text = temp_rdr[0].ToString();
            } //출금 통장 불러주는애 (계좌번호를 통해서)
            rdr.Close();

            listView.FocusedItem = null;
        }

        private void Drawchart()
        {
            Readlog();
            int index = 0; double amount_sum = 0;
            chart_date.Series["chart_pie"].Points.Clear();  //시작과 동시에 clear  그리고 모두 unchecked  일 경우도  clear된 채로 함수 종료

            string sql = "SELECT SUM(L_amount),L_category FROM LOG WHERE L_date LIKE '" + label_date.Text + "-%' and L_type='지출' GROUP BY L_category;";
            MySqlDataReader rdr = Readercmd(sql);

            while (rdr.Read())
            {
                int temp_amount = Int32.Parse(rdr["SUM(L_amount)"].ToString());
                chart_date.Series["chart_pie"].Points.Add(temp_amount);
                chart_date.Series["chart_pie"].Points[index].Label = rdr["L_category"].ToString();
                amount_sum += temp_amount;
                index++;
            }       // 원형차트에 금액과 카테고리 이름을 추가
            rdr.Close();

            listView_chart.Items.Clear();
            ListViewItem[] item = new ListViewItem[index + 1];
            for (int i = 0; i < index; i++)
            {
                double temp_amount = double.Parse(chart_date.Series["chart_pie"].Points[i].YValues[0].ToString());  // 한 카테고리의 금액을 임시로 저장
                double percent = Math.Round(temp_amount / amount_sum * 100);

                item[i] = new ListViewItem(chart_date.Series["chart_pie"].Points[i].Label); // 카테고리
                item[i].SubItems.Add(temp_amount.ToString()); // 금액
                item[i].SubItems.Add(percent.ToString() + "%"); // 퍼센트
                listView_chart.Items.Add(item[i]);

                chart_date.Series["chart_pie"].Points[i].Label += " ";
            }   // 인덱스 순으로 카테고리와 금액을 불러 퍼센트 계산 및 리스트뷰에 추가 하기위한 listviewitem에 저장
        }

        private void listView_chart_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            for (int i = 0; i < listView_chart.Items.Count; i++)
            {
                listView_chart.Items[i].SubItems[2].Text = listView_chart.Items[i].SubItems[2].Text.Replace("%", "");
            }

            if (listView_chart.Sorting == SortOrder.Ascending)
            {
                listView_chart.Sorting = SortOrder.Descending;
            }
            else
            {
                listView_chart.Sorting = SortOrder.Ascending;
            }

            listView_chart.ListViewItemSorter = new Sorter();      // * 1
            Sorter s = (Sorter)listView_chart.ListViewItemSorter;
            s.Order = listView.Sorting;
            s.Column = e.Column;
            listView_chart.Sort();

            for (int i = 0; i < listView_chart.Items.Count; i++)
            {
                listView_chart.Items[i].SubItems[2].Text += "%";
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string sql, amount, B_account;

            if (listView.FocusedItem.SubItems[2].Text != "")  //현금일경우
            {
                MessageBox.Show("현금");
                B_account = "";
                amount = listView.FocusedItem.SubItems[2].Text;
            }
            else //카드일경우
            {
                MessageBox.Show("카드");
                B_account = listView.FocusedItem.SubItems[5].Text;
                amount = listView.FocusedItem.SubItems[3].Text;
            }

            if (listView.FocusedItem.SubItems[6].Text == "수입" || listView.FocusedItem.SubItems[6].Text == "저축")
            {
                sql = "UPDATE BANK SET B_sum=B_sum-'" + amount + "' WHERE B_account='" + listView.FocusedItem.SubItems[5].Text + "';";
                Callcmd(sql);
            }
            else
            {
                sql = "UPDATE BANK SET B_sum=B_sum+'" + amount + "' WHERE B_account='" + listView.FocusedItem.SubItems[5].Text + "';";
                Callcmd(sql);
            }

            string[] time = listView.FocusedItem.SubItems[0].Text.Split(' ');
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
            sql = "DELETE FROM LOG WHERE L_date='" + time[0] + " " + time[2] + "';";
            Callcmd(sql);

            Readlog();
        }


        private void 카드통장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MAIN_CARDNBANK CB = new MAIN_CARDNBANK(this);
            CB.Show();
            this.Hide();
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            if (listView.FocusedItem != null)
            {
                MAIN_modify modify = new MAIN_modify(this, this.listView.FocusedItem);
                modify.Show();
            }
            else
                MessageBox.Show("수정할 내용이 선택되지 않았습니다.");
        }   // 수정 버튼 클릭 전 선택한 리스트뷰 행이 없을경우 실행 안됨

        private void button_readdata_Click(object sender, EventArgs e)
        {
         //   string s = "DELETE FROM LOG";
         //  Callcmd(s);

            string path = @"C:\Users\응솔\Desktop\으윽\3-1\DB\DB프로젝트\KakaoTalk_20180514_0912_47_578_카카오페이.txt";
            string textValue = System.IO.File.ReadAllText(path);
            string[] splitText = textValue.Split(new string[] { "결제가 완료" }, StringSplitOptions.RemoveEmptyEntries);
            int len = splitText.Length;
            string[] date = new string[len], detail = new string[len], amount = new string[len], cardname = new string[len];


            for (int i = 0; i< len-1; i++)
            {
                int first_index = splitText[i + 1].IndexOf("일시: ") + 4 ;
                date[i] = splitText[i + 1].Substring(first_index, 16);
                  //MessageBox.Show(date[i]);                    
            }

            for (int i = 0; i < len-1; i++)
            {
                int first_index = splitText[i + 1].IndexOf("구매처: ") + 5, last_index = splitText[i + 1].IndexOf("-", first_index);
                detail[i] = splitText[i + 1].Substring(first_index, last_index - first_index).Trim();
             //   MessageBox.Show(detail[i]);
            }

            for (int i = 0; i < len-1; i++)
            {
                int first_index = splitText[i + 1].IndexOf("금액: ") + 4, last_index = splitText[i + 1].IndexOf("원", first_index);
                amount[i] = splitText[i + 1].Substring(first_index, last_index - first_index);
                amount[i] = amount[i].Replace(",", "");

        // MessageBox.Show(amount[i]);
            }

          //  MessageBox.Show(date.Length)
            for (int i = 0; i < len-1; i++)
            {
                int first_index = splitText[i + 1].IndexOf("수단: ") + 4;

                if (first_index == 3) // "수단: "이 없을 경우
                    cardname[i] = "";

                else
                {
                    int last_index = splitText[i + 1].IndexOf("\n", first_index);
                    cardname[i] = splitText[i + 1].Substring(first_index, last_index - first_index);
                }

                //MessageBox.Show(date[i]);
                string sql = "SELECT * FROM CARD WHERE MEM_id='" + id + "' and C_name='" + cardname[i] + "'";
                MySqlDataReader rdr = Readercmd(sql);

                while (rdr.Read())
                {
                    cardname[i] = rdr.GetString(2);
                }
                rdr.Close();
                
                if(cardname[i] =="" || cardname[i] ==null)
                    cardname[i] = "1566-16518-818"; // 디폴트는 카카오머니
            }

            for (int i = 0; i < len - 1; i++)
            {
                string sql = "INSERT INTO LOG VALUES ('" + date[i] + "','"
                   + detail[i] + "','"
                   + amount[i] + "','"
                   + cardname[i] + "', '지출' ,'기타')";    //cardname에 무조건 계좌번호가 들어가야됨

                Callcmd(sql);
            }
            Drawchart();
            Readlog();
        }

        private void tabControl_TabIndexChanged(object sender, EventArgs e)
        {
            Drawchart();
            Readlog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM LOG";
            Callcmd(sql);

            Readlog();
        }

        private void tabControl_Click(object sender, EventArgs e)
        {
            Readlog();
            Drawchart();
        }
    }
}

