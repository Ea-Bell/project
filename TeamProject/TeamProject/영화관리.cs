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



//이미지를 넣었다면 이미지가 항상 같은 경로가 있는지 확인할것. 없으면 없다는 그림을 보여줄것.(내 임의의 그림을 넣어서 확인하자)
namespace TeamProject
{
    public partial class 영화관리 : Form
    {
        private String[] 데이터넘기기 = new string[6];
        private string image_file = string.Empty;
        private string 경로 = "";

        OracleConnection odpConn = new OracleConnection();

        private int SelectedRowIndex;

        public 영화관리()
        {
            InitializeComponent();
        }

        private void showDataGridview()
        {
            try
            {
                odpConn.ConnectionString = "User Id=LPK; Password=1234; Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.142.16)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
                odpConn.Open();

                OracleDataAdapter oda = new OracleDataAdapter();
                oda.SelectCommand = new OracleCommand("select * from 영화", odpConn);

                DataTable dt = new DataTable();
                oda.Fill(dt);
                odpConn.Close();

                DBGrid.DataSource = dt;

                DBGrid.AutoResizeColumns();
                DBGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                DBGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DBGrid.AllowUserToAddRows = false;
                odpConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("에러 발생: " + ex.ToString());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //URL = Convert.ToString(DBGrid.SelectedCells[3].Value);
            //Form2 form2 = new Form2(this);
            //form2.ShowDialog();
            //form2.Dispose();
        }











        private void 그림찾기btn_Click(object sender, EventArgs e)
        {
            //파일 불러오기
            //string image_file = string.Empty;
            // string 경로 = "";
            파일열기 opfl = new 파일열기();
            image_file = opfl._파일열기();
            if (image_file == "")
            {
                //이거 오류 해결 하기 위한 코드
            }
            else
                영화포스터.Image = Bitmap.FromFile(image_file);
            경로 = opfl.파일경로명();
            경로명.Text = "@\"" + 경로 + "\"";
        }

        private void 취소_Click(object sender, EventArgs e)
        {

            //버튼 소리낼때 딜레이 걸어서 버튼 종료 시켜야한다.
            Dispose();
        }


        private void 저장_Click(object sender, EventArgs e)
        {
            영화유효성검사();

            //데이터 넘기기는 영화관리에있는 모든 txt를 영화관리DB클래스로 넘길려고한다.
            데이터넘기기[0] = 영화코드txt.Text;
            데이터넘기기[1] = 영화명txt.Text;
            데이터넘기기[2] = 감독명txt.Text;
            데이터넘기기[3] = 예고편URLtxt.Text;
            데이터넘기기[4] = 경로;
            데이터넘기기[5] = 가격txt.Text;

            //데이터넘기기{영화코드, 영화명, 감독명, 예고편URL, 포스터 사진 경로}
            테스트용_Label.Text = 데이터넘기기[0] + " " + 데이터넘기기[1] + " " + 데이터넘기기[2] + " " + 데이터넘기기[3] + " " + 데이터넘기기[4];

            OracleConnection conn = new OracleConnection("User Id=LPK; Password=1234; Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.142.16)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ");
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO 영화 (영화코드, 영화명, 감독명, 예고편URL, 그림경로, 가격) VALUES ('" + 데이터넘기기[0] + "', '" + 데이터넘기기[1] + "', '" + 데이터넘기기[2] + "', '" + 데이터넘기기[3] + "', '" + 데이터넘기기[4] + "', '" + 데이터넘기기[5] + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            //asdfasdfasdfasdfasdf
            //영화관리DB에 데이터를 넘길때 데이터들을 set, get시키자. 

            showDataGridview();
        }

        private void 상영영화관리_Click(object sender, EventArgs e)
        {
            그림배치 그림배치 = new 그림배치();
            그림배치.ShowDialog();
            그림배치.Dispose();
        }

        private void 영화관리_Load(object sender, EventArgs e)
        {
            showDataGridview();
        }

        private void DBGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //테스트용_Label.Text = a;
            영화코드txt.Text = Convert.ToString(DBGrid.SelectedCells[0].Value);
            영화명txt.Text = Convert.ToString(DBGrid.SelectedCells[1].Value);
            감독명txt.Text = Convert.ToString(DBGrid.SelectedCells[2].Value);
            예고편URLtxt.Text = Convert.ToString(DBGrid.SelectedCells[3].Value);
            // Convert.ToString(DBGrid.SelectedCells[4].Value);
            영화포스터.Image = Bitmap.FromFile(@"" + Convert.ToString(DBGrid.SelectedCells[4].Value) + "");
            가격txt.Text = Convert.ToString(DBGrid.SelectedCells[5].Value);

        }


        private void 수정하기_Click(object sender, EventArgs e)
        {
            영화유효성검사();
            try
            {
                string connectionString = "User Id=LPK; Password=1234; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL=TCP)(HOST = 192.168.142.16)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";

                string commandString = "select * from 영화";


                //ds는 데이터 기본 제약 조건이 설정이 안되어 있어서 프로그래머가 제약조건 설정을 해줘야한다.

                // string commandString = "select * from Phone";
                OracleDataAdapter DBAdapter = new OracleDataAdapter(commandString, connectionString);
                OracleCommandBuilder myCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DataSet DS = new DataSet("영화");
                DBAdapter.Fill(DS, "영화");
                DataTable phoneTable = DS.Tables["영화"];

                DataRow currRow = phoneTable.Rows.Find(SelectedRowIndex);
                //수정 시작과 끝을 알려주는 메소드들.
                currRow.BeginEdit();
                currRow["영화코드"] = 영화코드txt.Text;
                currRow["영화명"] = 영화명txt.Text;
                currRow["감독명"] = 감독명txt.Text;
                currRow["예고편URL"] = 예고편URLtxt.Text;
                currRow["그림경로"] = 경로명.Text;
                currRow["가격"] = 가격txt.Text;
                currRow.EndEdit();


                DataSet UpdatedSet = DS.GetChanges(DataRowState.Modified);//수정을 완료했으면 DataRowState라는 새로운 열이 생기고 튜블 마지막에 Modified라는것이 들어간다.
                if (UpdatedSet.HasErrors)
                { MessageBox.Show("변경된 데이터에 문제가 있습니다."); }
                else
                {
                    DBAdapter.Update(UpdatedSet, "영화");
                    DS.AcceptChanges(); //commit이랑 같다 항상 수정이 완료되면 commit이라는 것을해야해서 acceptChanges()라는 함수를 꼭 써야한다.
                }
                DBGrid.DataSource = DS.Tables["Phone"].DefaultView;

            }
            catch (DataException DE)
            { MessageBox.Show(DE.Message); }
            catch (Exception DE)
            { MessageBox.Show(DE.Message); }
        }

        private void 영화유효성검사()
        {
            if (image_file == "")
            {

                // MessageBox.Show("이미지를 넣지 않으셨습니다.");
                DialogResult result1 = MessageBox.Show("정말로 이미지를 넣지 않으시겠습니까?", "이미지 입력확인란", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result1 == System.Windows.Forms.DialogResult.Yes)
                {
                    //예를 하면 내가 올린 임의의 사진이 올라가도록 한다.
                    영화포스터.Image = Bitmap.FromFile(@"C:\Users\user\Documents\GitHub\project\TeamProject\TeamProject\img\오류이미지\파일없음.jpg");
                    //경로 = @"C:\Users\user\Documents\GitHub\project\TeamProject\TeamProject\img\오류이미지\파일없음.jpg";
                }
                else
                { }
            }
            else if (영화코드txt.Text == "")
            {
                MessageBox.Show("영화코드를 넣지 않으셨습니다.");
            }
            else if (영화명txt.Text == "")
            {
                MessageBox.Show("영화명를 넣지 않으셨습니다.");
            }
            else if (감독명txt.Text == "")
            {
                MessageBox.Show("감독명를 넣지 않으셨습니다.");
            }
            else if (예고편URLtxt.Text == "")
            {
                //현재 메시지 박스를 열고서 행하는 행동.
                DialogResult result1 = MessageBox.Show("정말로 예고편URL을 넣지 않으시겠습니까?", "URL입력확인란", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result1 == System.Windows.Forms.DialogResult.Yes)
                {
                }
            }

            //영화관리DB 영화 = 영화관리DB.getInstance();
            //영화.추가(데이터넘기기);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        //private void ClearTextBoxes()
        //   {
        //           영화코드txt.Clear();
        //           영화명txt.Clear();
        //           감독명txt.Clear();
        //           예고편urlTxt.Clear();
        //   }

        //
    }
    }
   

