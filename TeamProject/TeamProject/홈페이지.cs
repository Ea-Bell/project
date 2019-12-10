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
    public partial class 홈페이지 : Form
    {
        
        public 홈페이지()
        {
            InitializeComponent();
            //MainMenuStrip.Visible = false;
           
        }

        private void 뒤로가기_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void 앞으로가기_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void 브라우저주소링크_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.Text = webBrowser1.DocumentTitle;
            브라우저주소링크.Text = webBrowser1.Document.Url.ToString();
        }

        private void 브라우저주소링크_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.toolStripButton1_Click(sender, e);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(브라우저주소링크.Text);
        }
    }
}
