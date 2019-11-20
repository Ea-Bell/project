using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProject
{
 
    class 파일열기 
    {
        public string open
        {
            get;set;
        }
        OpenFileDialog diglog = new OpenFileDialog();
        public string _파일열기()
        {
            diglog.InitialDirectory = @"c:\";
            diglog.Filter = "그림 파일 (*.jpg, *.gif, *.bmp) | *.jpg; *.gif; *.bmp; | 모든 파일 (*.*) | *.*";
            try
            {
                if (diglog.ShowDialog() == DialogResult.OK)
                {
                    open = diglog.FileName;
                    //return open;
                }
                else if (diglog.ShowDialog() == DialogResult.Cancel)
                {
                    return "";
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return open;

        }
        public String 파일경로명()
        {
            return open = diglog.FileName;
        }
    }
}
