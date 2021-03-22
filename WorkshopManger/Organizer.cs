using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//
using System.Data;//

namespace WorkshopManger
{
    class Organizer
    {

        SqlConnection con;
        SqlCommand cmd;
        public Organizer()
        {
            // default constructor
            con = new SqlConnection("data source=.;database=WorkshopDB;integrated security=true;");
            cmd = new SqlCommand();
        }

        public void AddOrganizer(string name, string phone,
    string email, string password)
        {
            con.Open();
            cmd.CommandText = "AddNewOrganaizer_Admin";//sproc name or tsql
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@Phone", phone);
            cmd.Connection = con;// determin the connecton to command 
            cmd.ExecuteNonQuery();// execute tsql 
            con.Close();

        }

        public DataTable GetAllOrganizer()
        {
            con.Open();
            cmd.CommandText = "select * from Organaizer_Admin";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();// read from database
            DataTable dt = new DataTable();
            dt.Load(dr);// fill dt with data from dr
            con.Close();
            return dt;
        }
        public DataTable GetOrganizerById(int id)
        {
            con.Open();
            cmd.CommandText = "select * from Organaizer_Admin where Id =" + id;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();// read from database
            DataTable dt = new DataTable();
            dt.Load(dr);// fill dt with data from dr
            con.Close();
            return dt;
        }

        public int UpdateOrganizer(int id, string name, string phone,
    string email, string password)
        {
            con.Open();
            cmd.CommandText = "UpdteOrgAdmin";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Clear();///
            cmd.Parameters.AddWithValue("@OrgID", id);
            cmd.Parameters.AddWithValue("@OrgName", name);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@OrgAdmPassword", password);
            cmd.Parameters.AddWithValue("@Phone", phone);
            int r = cmd.ExecuteNonQuery();

            con.Close();
            return r;
        }

        public int DeleteOrganizer(int id)
        {
            con.Open();
            cmd.CommandText = "DeleteOrgAdmin";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Id", id);
            int r = cmd.ExecuteNonQuery();
            con.Close();
            return r;
        }



    }

}
