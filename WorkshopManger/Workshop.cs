using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;//
using System.Data;//

namespace WorkshopManger
{
    class Workshop
    {
        SqlConnection con;
        SqlCommand cmd;
        public Workshop()
        {
            // default constructor
            con = new SqlConnection("data source=.;database=WorkshopDB;integrated security=true;");
            cmd = new SqlCommand();
        }

        // ALL NEED TO BE FIX
        public void AddWorkshop(string title, DateTime date,
                     string duration, string presenter, 
                     string seatsCount, string location,
                     string description, string orgID)
        {
            con.Open();
            cmd.CommandText = "AddNewWorkshop";//sproc name or tsql
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Title", title);
            cmd.Parameters.AddWithValue("@Date", date);
            cmd.Parameters.AddWithValue("@Duration", duration);
            cmd.Parameters.AddWithValue("@Presenter", presenter);
            cmd.Parameters.AddWithValue("@SeatsCount", seatsCount);
            cmd.Parameters.AddWithValue("@Location", location);
            cmd.Parameters.AddWithValue("@Description", description);
            cmd.Parameters.AddWithValue("@orgID", orgID);
            cmd.Connection = con;// determin the connecton to command 
            cmd.ExecuteNonQuery();// execute tsql 
            con.Close();

        }

        public DataTable GetAllWorkshop()
        {
            con.Open();
            cmd.CommandText = "select * from Workshop";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();// read from database
            DataTable dt = new DataTable();
            dt.Load(dr);// fill dt with data from dr
            con.Close();
            return dt;
        }
        public DataTable GetWorkshopById(int id)
        {
            con.Open();
            cmd.CommandText = "select * from Workshop where ID =" + id;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();// read from database
            DataTable dt = new DataTable();
            dt.Load(dr);// fill dt with data from dr
            con.Close();
            return dt;
        }

        public int UpdateWorkshop(int id, string title, DateTime date,
                     string duration, string presenter,
                     string seatsCount, string location,
                     string description)
        {
            con.Open();
            cmd.CommandText = "UpdateWorkshop";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Clear();///
            cmd.Parameters.AddWithValue("@OrgID", id);
            cmd.Parameters.AddWithValue("@Title", title);
            cmd.Parameters.AddWithValue("@Date", date);
            cmd.Parameters.AddWithValue("@Duration", duration);
            cmd.Parameters.AddWithValue("@Presenter", presenter);
            cmd.Parameters.AddWithValue("@SeatsCount", seatsCount);
            cmd.Parameters.AddWithValue("@Location", location);
            cmd.Parameters.AddWithValue("@Description", description);


            int r = cmd.ExecuteNonQuery();

            con.Close();
            return r;
        }

        public int DeleteWorkshop(int id)
        {
            con.Open();
            cmd.CommandText = "DeleteWorkshop";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID", id);
            int r = cmd.ExecuteNonQuery();
            con.Close();
            return r;
        }








    }
}
