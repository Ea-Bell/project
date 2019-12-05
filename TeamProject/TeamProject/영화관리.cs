using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//이미지를 넣었다면 이미지가 항상 같은 경로가 있는지 확인할것. 없으면 없다는 그림을 보여줄것.(내 임의의 그림을 넣어서 확인하자)
namespace TeamProject
{
    public partial class 영화관리 : Form
    {
        private String[] 데이터넘기기= new string[5];
        private string image_file = string.Empty;
        private string 경로 = "";
      
        public 영화관리()
        {
            InitializeComponent();
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
                {}
            }
            else if(영화코드txt.Text == ""){
                MessageBox.Show("영화코드를 넣지 않으셨습니다.");
            }
            else if (영화명txt.Text == "")
            {
                MessageBox.Show("영화명를 넣지 않으셨습니다.");
            }
            else if (감독명txt.Text == "")
            {
                MessageBox.Show("감독명를 넣지 않으셨습니다.");
            }else if (예고편urlTxt.Text == "")
            {
                //현재 메시지 박스를 열고서 행하는 행동.
                DialogResult result1 =MessageBox.Show("정말로 예고편URL을 넣지 않으시겠습니까?", "URL입력확인란", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result1 == System.Windows.Forms.DialogResult.Yes)
                { }                            
            }

            //데이터 넘기기는 영화관리에있는 모든 txt를 영화관리DB클래스로 넘길려고한다.
            데이터넘기기[0] = 영화코드txt.Text;
            데이터넘기기[1] = 영화명txt.Text;
            데이터넘기기[2] = 감독명txt.Text;
            데이터넘기기[3] = 예고편urlTxt.Text;
            데이터넘기기[4] = 경로;
            //데이터넘기기{영화코드, 영화명, 감독명, 예고편URL, 포스터 사진 경로}
            테스트용_Label.Text = 데이터넘기기[0] +" "+ 데이터넘기기[1] + " " + 데이터넘기기[2] + " " + 데이터넘기기[3] + " " + 데이터넘기기[4];

            //asdfasdfasdfasdfasdf
            //영화관리DB에 데이터를 넘길때 데이터들을 set, get시키자. 

<<<<<<< HEAD
        }

        private void 상영영화관리_Click(object sender, EventArgs e)
        {
            그림배치 그림배치 = new 그림배치();
            그림배치.ShowDialog();
        }
=======
            영화관리DB 영화 = 영화관리DB.getInstance();
            영화.추가(데이터넘기기);
            }
 private void ClearTextBoxes()
    {
            영화코드txt.Clear();
            영화명txt.Clear();
            감독명txt.Clear();
            예고편urlTxt.Clear();
    }
>>>>>>> dc3f6c1480909823adadf6be1750752d2a8b5bcf
    }
   
}

