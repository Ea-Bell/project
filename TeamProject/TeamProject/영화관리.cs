using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProject
{
    public partial class 영화관리 : Form
    {

        private String[] 데이터넘기기;
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
            }

        }

    }
}

