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
        public int AudienceSignUp(string Fname,string Lname, string phone,string email, string password )
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







            //    public DataTable GetAllOrganizer()
            //    {
            //        con.Open();
            //        cmd.CommandText = "select * from Organaizer_Admin";
            //        cmd.CommandType = CommandType.Text;
            //        cmd.Connection = con;
            //        SqlDataReader dr = cmd.ExecuteReader();// read from database
            //        DataTable dt = new DataTable();
            //        dt.Load(dr);// fill dt with data from dr
            //        con.Close();
            //        return dt;
            //    }
            //    public DataTable GetOrganizerById(int id)
            //    {
            //        con.Open();
            //        cmd.CommandText = "select * from Organaizer_Admin where Id =" + id;
            //        cmd.CommandType = CommandType.Text;
            //        cmd.Connection = con;
            //        SqlDataReader dr = cmd.ExecuteReader();// read from database
            //        DataTable dt = new DataTable();
            //        dt.Load(dr);// fill dt with data from dr
            //        con.Close();
            //        return dt;
            //    }

            //    public int UpdateOrganizer(int id, string name, string phone,
            //string email, string password)
            //    {
            //        con.Open();
            //        cmd.CommandText = "UpdteOrgAdmin";
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Connection = con;
            //        cmd.Parameters.Clear();///
            //        cmd.Parameters.AddWithValue("@OrgID", id);
            //        cmd.Parameters.AddWithValue("@OrgName", name);
            //        cmd.Parameters.AddWithValue("@Email", email);
            //        cmd.Parameters.AddWithValue("@OrgAdmPassword", password);
            //        cmd.Parameters.AddWithValue("@Phone", phone);
            //        int r = cmd.ExecuteNonQuery();

            //        con.Close();
            //        return r;
            //    }

            //    public int DeleteOrganizer(int id)
            //    {
            //        con.Open();
            //        cmd.CommandText = "DeleteOrgAdmin";
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Connection = con;
            //        cmd.Parameters.Clear();
            //        cmd.Parameters.AddWithValue("@Id", id);
            //        int r = cmd.ExecuteNonQuery();
            //        con.Close();
            //        return r;
            //    }




        }
}
