using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class 예매하기 : Form
    {
        string userid = "";
        public 예매하기(string id)
        {
            InitializeComponent();
            userid = id;
        }
         //포스터 클릭하면 예고편 나오기
        private void 극한직업_Click(object sender, EventArgs e)
        {

        }

        private void 범죄도시_Click(object sender, EventArgs e)
        {

        }

        private void 라라랜드_Click(object sender, EventArgs e)
        {

        }

        private void 타짜_Click(object sender, EventArgs e)
        {

        }

        private void 청년경찰_Click(object sender, EventArgs e)
        {

        }

        private void 엑시트_Click(object sender, EventArgs e)
        {

        }
         
        //해당 영화의 시간선택 폼으로 넘어감
        private void 극한btn_Click(object sender, EventArgs e)
        {
            시간선택 시간 = new 시간선택(userid);
            시간.ShowDialog();

            시간.Dispose();
        }

        private void 범죄btn_Click(object sender, EventArgs e)
        {

        }

        private void 라라btn_Click(object sender, EventArgs e)
        {

        }

        private void 타짜btn_Click(object sender, EventArgs e)
        {

        }

        private void 청년btn_Click(object sender, EventArgs e)
        {

        }

        private void 엑시btn_Click(object sender, EventArgs e)
        {

        }
    }
}
