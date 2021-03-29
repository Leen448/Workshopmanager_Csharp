using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace WorkshopManger
{
    class Audience : Account
    {

        SqlConnection con;
        SqlCommand cmd;
        public Audience()
        {
            // default constructor
            //  con = new SqlConnection("data source=.;database=WorkshopDB;integrated security=true;");
            con = new SqlConnection("data source=LEEN-DESKTOP\\MSSQLSERVER01;database=WorkshopDB;integrated security=true;");
            cmd = new SqlCommand();
        }

        public static int AudiencerId { get; set; }




        public DataTable GetAllAudience(String Query)
        {
            con.Open();
            cmd.CommandText = Query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Parameters.Clear();
            SqlDataReader dr = cmd.ExecuteReader();// read from database
            DataTable dt = new DataTable();
            dt.Load(dr);// fill dt with data from dr
            con.Close();
            return dt;
        }


        public int AudienceSignUp(string Fname, string Lname, string phone, string email, string password)
        {
            con.Open();
            cmd.CommandText = "SignUp_Audience";//sproc name or tsql
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;// determin the connecton to command 
            cmd.Parameters.Clear();//

            cmd.Parameters.AddWithValue("@FName", Fname);
            cmd.Parameters.AddWithValue("@LName", Lname);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@AudPassword", password);
            cmd.Parameters.AddWithValue("@Phone", phone);

            cmd.Parameters.Add("@return", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;

            cmd.ExecuteNonQuery();

            int r = (int)cmd.Parameters["@return"].Value;
            con.Close();
            return r;

        }


        public int UpdateAud(int id, string Fname, string Lname, string phone, string email, string password)
        {
            con.Open();
            cmd.CommandText = "UpdateAudience";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Clear();///
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@FName", Fname);
            cmd.Parameters.AddWithValue("@LName", Lname);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@AudPassword", password);
            cmd.Parameters.AddWithValue("@Phone", phone);
            int r = cmd.ExecuteNonQuery();

            con.Close();
            return r;
        }

        public int Regester(int Audid, int Wid, int OrgID)
        {
            con.Open();
            cmd.CommandText = "NewRegistration";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@audID", Audid);
            cmd.Parameters.AddWithValue("@OrgID", OrgID);
            cmd.Parameters.AddWithValue("@WorkshopID", Wid);
            int r = cmd.ExecuteNonQuery();
            con.Close();
            return r;
        }


        public int DeleteRegistration(int Audid, int Wid)
        {
            con.Open();
            cmd.CommandText = "DeleteRegistration";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@audID", Audid);
            cmd.Parameters.AddWithValue("@WorkshopID", Wid);
            int r = cmd.ExecuteNonQuery();
            con.Close();
            return r;
        }

    }
}
