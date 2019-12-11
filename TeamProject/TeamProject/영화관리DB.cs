using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;

namespace TeamProject
{

    //디비 접속합시다!
    public class 영화관리DB
    {
        OracleDataAdapter DBAdapter;
        DataSet DS;
        OracleCommandBuilder myCommandBuilder;
      //  DataTable mTabel;



        private  static 영화관리DB 디비관리;
      //  private  string conn = null;

        //싱글톤 영화관리 디비 불러올떄 getInstance()로 불러오면된다.
        public static 영화관리DB getInstance()
        {
            if (디비관리 == null)
            {
                디비관리 = new 영화관리DB();
            }
            return 디비관리;
        }
        private void DB_Open()
        {
            try
            {
                string connectionString = "User Id=LPK; Password=1234; Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.142.16)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
                string commandString = "select * from 회원";
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                myCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
            }
            catch (DataException DE)
            {
             
                Console.WriteLine(DE.StackTrace);
                DBAdapter.Fill(DS, "영화");
            }

        }

        //4개 만들기. 어떻게? 언제나 디비를 항상 연결해서 쓰기. 잘 모르면 배껴쓰셈. 받아오는건 어떻게? 배열로?아 요기서 받지말고 함수(get set)으로 불러오자!
        public void 검색() { }
        public void 추가(String [] 데이터)
        {
            DB_Open();
            try
            {
                DS.Clear();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }

        }
        public void 삭제() { }
        public void 수정() { }
    }
   

}
