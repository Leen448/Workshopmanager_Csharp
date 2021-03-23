using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//
using System.Data;//
namespace WorkshopManger

{
    class Account
    {
        SqlConnection con;
        SqlCommand cmd;
        public Account()
        {
            // default constructor
            //  con = new SqlConnection("data source=.;database=WorkshopDB;integrated security=true;");
            con = new SqlConnection("data source=LEEN-DESKTOP\\MSSQLSERVER01;database=WorkshopDB;integrated security=true;");
            cmd = new SqlCommand();

        }

        public static int AccountType { get; set; }
        public static int AccountId { get; set; }

        public int CheckUserExists(string  _userEmail, string _password, int AccountType, out int AccountId)
        {
            con.Open();
            cmd.CommandText = "login_users";// proc name
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Clear();//
            //add paramters to proc
            cmd.Parameters.AddWithValue("@userEmail", _userEmail);
            cmd.Parameters.AddWithValue("@Password", _password);
            cmd.Parameters.AddWithValue("@TableNumber", AccountType);
            cmd.Parameters.Add("@return", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add("@Id", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();// after execute proc
            //value
            int r = (int)cmd.Parameters["@return"].Value;
            if (cmd.Parameters["@Id"].Value != DBNull.Value)
            {
                AccountId = (int)cmd.Parameters["@Id"].Value;

            }
            else
            {
                AccountId = 0;
            }
            con.Close();
            return r;
        }
        public  DataTable GetUserById(int id, int TableNumber)
        {
            con.Open();
            cmd.CommandText = "UserInfo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@TableNumber",TableNumber);
            SqlDataReader dr = cmd.ExecuteReader();// read from database
            DataTable dt = new DataTable();
            dt.Load(dr); //fill dt with data from dr
            con.Close();
            return dt;
        }
    }
}
