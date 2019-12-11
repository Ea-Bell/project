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
        string seat = "";
        OracleDataAdapter DBAdapter;
        DataSet DS;
        OracleCommandBuilder myCommandBuilder;
        DataTable MemberTable;
        private void DB_Open()
        { // DB연결
            try
            {
                string connectionString = "User Id=LPK; Password=1234; Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.142.16)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
                string commandString = "select * from 예약내역";
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                myCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }


        public 시간선택()
        {
            InitializeComponent();
            DB_Open();
        }

        private void button4_Click(object sender, EventArgs e)
        { // 좌석 A03

            button4.ForeColor = Color.White;
            button4.BackColor = Color.Purple;
        }

        private void button5_Click(object sender, EventArgs e)
        {// 좌석 A04
            seat = button5.Text;
            button4.ForeColor = Color.White;
            button4.BackColor = Color.Purple;
        }

        private void button1_Click(object sender, EventArgs e)
        {// 1회차 선택

        }

        private void button2_Click(object sender, EventArgs e)
        {// 2회차 선택

        }

        private void button3_Click(object sender, EventArgs e)
        {// 3회차 선택

        }

        private void btn_commit_Click(object sender, EventArgs e)
        {
            if (seat == "")
            {
                MessageBox.Show("좌석을 선택해주세요");
            }
            else
            {
                DS.Clear();
                DBAdapter.Fill(DS, "예약내역"); // 현재 phone 테이블 전체 내용 fill

                MemberTable = DS.Tables["회원"]; // DS의 phone 테이블에 새로운 줄 추가
                DataRow newRow = MemberTable.NewRow();

                //newRow["예약내역"] = 0;
                newRow["회차번호"] = 0;
                newRow["상영관코드"] = 0;
                newRow["상영영화코드"] = 0;
                newRow["상영일"] = DateTime.Now.ToString("yyyyMMdd");
                newRow["회원번호"] = 0;
                if (seat == "A03")
                {
                    newRow["좌석1"] = 0;
                }
                else if (seat == "A04")
                {
                    newRow["좌석2"] = 0;
                }
                else if (seat == "A05")
                {
                    newRow["좌석3"] = 0;
                }
                else if (seat == "A06")
                {
                    newRow["좌석4"] = 0;
                }
                else if (seat == "A07")
                {
                    newRow["좌석5"] = 0;
                }
                else if (seat == "A08")
                {
                    newRow["좌석6"] = 0;
                }
                else if (seat == "A09")
                {
                    newRow["좌석7"] = 0;
                }
                else if (seat == "A10")
                {
                    newRow["좌석8"] = 0;
                }
                else if (seat == "A11")
                {
                    newRow["좌석9"] = 0;
                }
                else if (seat == "B02")
                {
                    newRow["좌석10"] = 0;
                }

                if (MessageBox.Show(seat + " 좌석을 예매하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MemberTable.Rows.Add(newRow);

                    DBAdapter.Update(DS, "회원");
                    DS.AcceptChanges();
                }
                else
                {
                    DS.Clear();
                }
            }
        }
    }
}
