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
            Dispose();
        }

        private void 저장_Click(object sender, EventArgs e)
        {
            if (image_file == "")
            {
                MessageBox.Show("이미지를 넣지 않으셨습니다.");
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
                MessageBox.Show("정말로 예고편URL을 넣지 않으시겠습니까?", "URL입력확인란", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //이미지를 넣었다면 이미지가 항상 같은 경로가 있는지 확인할것. 없으면 없다는 그림을 보여줄것.(내 임의의 그림을 넣어서 확인하자)

            }
            //데이터 넘기기는 영화관리에있는 모든 txt를 영화관리DB클래스로 넘길려고한다.
            데이터넘기기[0] = 영화코드txt.Text;
            데이터넘기기[1] = 영화명txt.Text;
            데이터넘기기[2] = 감독명txt.Text;
            데이터넘기기[3] = 영화명txt.Text;
            데이터넘기기[4] = 경로;

            테스트용_Label.Text = 데이터넘기기[0] +" "+ 데이터넘기기[1] + " " + 데이터넘기기[2] + " " + 데이터넘기기[3] + " " + 데이터넘기기[4];


        }

    }
}

