using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace TeamProject
{
    public partial class 그림배치 : Form
    {
        public 그림배치()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            예매하기 예매 = new 예매하기("123");
            예매.Show();
          
        }

        private void 수정하기_Click(object sender, EventArgs e)
        {

        }



    }
}
