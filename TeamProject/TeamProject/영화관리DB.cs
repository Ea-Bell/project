using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;

namespace TeamProject
{
    public class 영화관리DB
    {
        private  static 영화관리DB 디비관리;
        private  string conn = null;

        //4개 만들기. 어떻게? 언제나 디비를 항상 연결해서 쓰기. 잘 모르면 배껴쓰셈. 받아오는건 어떻게? 배열로.
        public void 검색() { }
        public void 추가() { }
        public void 삭제() { }
        public void 수정() { }

        //싱글톤 영화관리 디비 불러올떄 getInstance()로 불러오면된다.
        public static 영화관리DB getInstance()
        {
            if (디비관리 == null)
            {
                디비관리 = new 영화관리DB();
            }
            return 디비관리;
        }
    }
   

}
