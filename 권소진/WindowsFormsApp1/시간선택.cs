using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace WindowsFormsApp1
{
    public partial class 시간선택 : Form
    {
        string userid = ""; //로그인한 회원의 id 값을 저장 받음
        string times = ""; //해당 영화의 회차에 대한 값을 받음
        string seat = ""; // 현재 선택한 좌석의 값을 받음
        string connectionString = "User Id=LPK; Password=1234; Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.142.16)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
                    
        private void 자리점멸(string seat, bool dbCheck) //dbCheck는 DB에서 호출한 함수인지 폼에서 호출한 함수인지 구분하는 변수임.
        {//좌석이 선택될 때마다 불려지는 함수. db에서 불려진 함수일 경우 dbCheck = true, 폼에서 불려진 함수일 경우 dbCheck = false이다
            Button [] btnArray;
            btnArray = new Button[] { 좌석1, 좌석2, 좌석3, 좌석6, 좌석5, 좌석4, 좌석7, 좌석8, 좌석9, 좌석10 };
            //버튼타입 배열로 좌석들을 배치            

            for (int i = 0; i < btnArray.Length; i++)
            {
                if (dbCheck == true) // DB에서 불러온 함수라면
                {
                    if (btnArray[i].Name == seat)
                    {// (이미 예약된) 좌석의 배경을 RED로 변경
                        btnArray[i].ForeColor = Color.White;
                        btnArray[i].BackColor = Color.Red;
                        btnArray[i].Enabled = false;  // 예약된 자리는 선택할 수 없게 만듬.
                    }
                }                
                else if (btnArray[i].Name != seat && (btnArray[i].BackColor == Color.Purple)) //DB상에 있는 값과 다르고 배경색이 보라면 원래색으로 돌아간다.
                {
                     btnArray[i].BackColor = DefaultBackColor;
                     btnArray[i].ForeColor = DefaultForeColor;
                }
                else if(btnArray[i].Name == seat)
                {// 선택한 좌석과 이름이 같은 좌석은 버튼배경이 보라색으로 변함
                    btnArray[i].ForeColor = Color.White;
                    btnArray[i].BackColor = Color.Purple;
                    this.seat = seat;
                }
            }            
        }
        private void 좌석DB연동()
        {
            Button[] btnArray;
            btnArray = new Button[] { 좌석1, 좌석2, 좌석3, 좌석6, 좌석5, 좌석4, 좌석7, 좌석8, 좌석9, 좌석10 };
            for (int i = 0; i < btnArray.Length; i++)
            {
                btnArray[i].BackColor = DefaultBackColor;
                btnArray[i].ForeColor = DefaultForeColor;
                btnArray[i].Enabled = true;
            }
            OracleConnection conn = new OracleConnection(connectionString);
            conn.Open();
            string strqry = "select 좌석1,좌석2,좌석3,좌석4,좌석5,좌석6,좌석7,좌석8,좌석9,좌석10 " +
                "from 예약내역 where 회차번호='"+times+"' and 상영일='"+ DateTime.Now.ToString("yyyyMMdd") + "'";
            OracleCommand comm = new OracleCommand(strqry, conn);
            OracleDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                if (dr["좌석1"].ToString() == "O")
                {
                    자리점멸("좌석1", true);
                }
                if (dr["좌석2"].ToString() == "O")
                {
                    자리점멸("좌석2", true);
                }
                if (dr["좌석3"].ToString() == "O")
                {
                    자리점멸("좌석3", true);
                }
                if (dr["좌석4"].ToString() == "O")
                {
                    자리점멸("좌석4", true);
                }
                if (dr["좌석5"].ToString() == "O")
                {
                    자리점멸("좌석5", true);
                }
                if (dr["좌석6"].ToString() == "O")
                {
                    자리점멸("좌석6", true);
                }
                if (dr["좌석7"].ToString() == "O")
                {
                    자리점멸("좌석7", true);
                }
                if (dr["좌석8"].ToString() == "O")
                {
                    자리점멸("좌석8", true);
                }
                if (dr["좌석9"].ToString() == "O")
                {
                    자리점멸("좌석9", true);
                }
                if (dr["좌석10"].ToString() == "O")
                {
                    자리점멸("좌석10", true);
                }
            }
            conn.Close();
        }
        public 시간선택(string userid)
        {
            InitializeComponent();
            this.userid = userid;
            times = "1";
            좌석DB연동();

            //1회차 선택한 것처럼 보이기            
            button1.BackColor = Color.Gray;
            button1.ForeColor = Color.White;
        }
        // ↑ 사용자 함수
        // ↓ 이벤트 처리기
        private void button1_Click(object sender, EventArgs e)
        {// 1회차 선택            
            times = "1";            
            button1.BackColor = Color.Gray;
            button1.ForeColor = Color.White;

            button2.BackColor = Control.DefaultBackColor;
            button2.ForeColor = Control.DefaultForeColor;
            button3.BackColor = Control.DefaultBackColor;
            button3.ForeColor = Control.DefaultForeColor;
            좌석DB연동();
        }
        private void button2_Click(object sender, EventArgs e)
        {// 2회차 선택
            times = "2";
            button2.BackColor = Color.Gray;
            button2.ForeColor = Color.White;

            button1.BackColor = Control.DefaultBackColor;
            button1.ForeColor = Control.DefaultForeColor;
            button3.BackColor = Control.DefaultBackColor;
            button3.ForeColor = Control.DefaultForeColor;
            좌석DB연동();
        }
        private void button3_Click(object sender, EventArgs e)
        {// 3회차 선택
            times = "3";
            button3.BackColor = Color.Gray;
            button3.ForeColor = Color.White;

            button2.BackColor = Control.DefaultBackColor;
            button2.ForeColor = Control.DefaultForeColor;
            button1.BackColor = Control.DefaultBackColor;
            button1.ForeColor = Control.DefaultForeColor;
            좌석DB연동();
        }

        private void btn_commit_Click(object sender, EventArgs e)
        {//commit 버튼클릭
            if (seat == "")
            {
                MessageBox.Show("좌석을 선택해주세요");
            }else if(times == "")
            {
                MessageBox.Show("시간을 선택해주세요");
            }
            else
            {
                OracleConnection conn = new OracleConnection(connectionString);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO 예약내역(예약내역, 회차번호, 상영관코드, 상영영화코드, 상영일, 회원번호, "+seat+") VALUES(seq_예약내역.nextval, '"+times+"', '미정', '미정', '"+ DateTime.Now.ToString("yyyyMMdd") + "','"+ userid+"' , 'O')";
                //seat 는 버튼을 누를 때, 버튼마다 주어진 문자열
                //cmd.CommandText = "INSERT INTO 예약내역(예약내역, 회차번호, 상영관코드, 상영영화코드, 상영일, 회원번호, 좌석1) VALUES(seq_예약내역.nextval, '"+times+"', '2', '3', '4', '5', '6')";
                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("성공");
            }            
        }
        

        private void 좌석1_Click(object sender, EventArgs e)
        {// 좌석 A03                       
            자리점멸(좌석1.Name, false);
        }
        private void 좌석2_Click(object sender, EventArgs e)
        {// 좌석 A04
            자리점멸(좌석2.Name, false);
        }
        private void 좌석3_Click(object sender, EventArgs e)
        {// 좌석 A05
            자리점멸(좌석3.Name, false);
        }

        private void 좌석4_Click(object sender, EventArgs e)
        {// 좌석 A06
            자리점멸(좌석4.Name, false);
        }

        private void 좌석5_Click(object sender, EventArgs e)
        {// 좌석 A07
            자리점멸(좌석5.Name, false);
        }

        private void 좌석6_Click(object sender, EventArgs e)
        {// 좌석 A08
            자리점멸(좌석6.Name, false);
        }

        private void 좌석7_Click(object sender, EventArgs e)
        {// 좌석 A09
            자리점멸(좌석7.Name, false);
        }

        private void 좌석8_Click(object sender, EventArgs e)
        {// 좌석 A10
            자리점멸(좌석8.Name, false);
        }

        private void 좌석9_Click(object sender, EventArgs e)
        {// 좌석 A11
            자리점멸(좌석9.Name, false);
        }
        private void 좌석10_Click(object sender, EventArgs e)
        {// 좌석 B02
            자리점멸(좌석10.Name, false);
        }
    }
}
