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
            // con = new SqlConnection("data source=.;database=WorkshopDB;integrated security=true;");
            con = new SqlConnection("data source=LEEN-DESKTOP\\MSSQLSERVER01;database=WorkshopDB;integrated security=true;");
            cmd = new SqlCommand();
        }


        public void AddWorkshop(string title, DateTime date,
                     string duration, string presenter,
                     decimal seatsCount, string location,
                     string description,
                     int OrgId)
        {
            con.Open();
            cmd.CommandText = "AddNewWorkshop";//sproc name or tsql
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Title", title);
            cmd.Parameters.AddWithValue("@Date", date.ToString());
            cmd.Parameters.AddWithValue("@Duration", duration);
            cmd.Parameters.AddWithValue("@Presenter", presenter);
            cmd.Parameters.AddWithValue("@SeatsCount", seatsCount.ToString());
            cmd.Parameters.AddWithValue("@Location", location);
            cmd.Parameters.AddWithValue("@Description", description);
            cmd.Parameters.AddWithValue("@orgID", OrgId);

            cmd.Connection = con;// determin the connecton to command 
            cmd.ExecuteNonQuery();// execute tsql 
            con.Close();

        }


        public DataTable GetAllWorkshop(String quere)
        {
            con.Open();
            cmd.CommandText = quere;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Parameters.Clear();
            SqlDataReader dr = cmd.ExecuteReader();// read from database
            DataTable dt = new DataTable();
            dt.Load(dr);// fill dt with data from dr
            con.Close();
            return dt;
        }




        public DataTable Check_reg(int aud,int wid)
        {
            con.Open();
            cmd.CommandText = "SELECT * FROM Registration WHERE WorkshopID = " + wid + " AND AudienceID ="+aud;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Parameters.Clear();
            SqlDataReader dr = cmd.ExecuteReader();// read from database
            DataTable dt = new DataTable();
            dt.Load(dr);// fill dt with data from dr
            con.Close();
            return dt;
        }




        public DataTable GetAllOrgWorkshops(int id)
        {
            con.Open();
            cmd.CommandText = "Select * from Workshop where orgID =" + id;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Parameters.Clear();
            SqlDataReader dr = cmd.ExecuteReader();// read from database
            DataTable dt = new DataTable();
            dt.Load(dr);// fill dt with data from dr
            con.Close();
            return dt;
        }


        public DataTable GetUnEnrolledWorkshop(int AudId)
        {
            con.Open();
            cmd.CommandText = "unEnrolledWorkshop";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@AudienceID", AudId);
            SqlDataReader dr = cmd.ExecuteReader();// read from database
            DataTable dt = new DataTable();
            dt.Load(dr);// fill dt with data from dr
            con.Close();
            return dt;
        }

        public DataTable GetEnrolledWorkshop(int AudId)
        {
            con.Open();
            cmd.CommandText = "EnrolledWorkshop";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@AudienceID", AudId);
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
                     decimal seatsCount, string location,
                     string description, int OrgId)
        {
            con.Open();
            cmd.CommandText = "UpdateWorkshop";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Clear();///
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@Title", title);
            cmd.Parameters.AddWithValue("@Date", date.ToString());
            cmd.Parameters.AddWithValue("@Duration", duration);
            cmd.Parameters.AddWithValue("@Presenter", presenter);
            cmd.Parameters.AddWithValue("@SeatsCount", seatsCount.ToString());
            cmd.Parameters.AddWithValue("@Location", location);
            cmd.Parameters.AddWithValue("@Description", description);
            cmd.Parameters.AddWithValue("@orgID", OrgId);
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


//Attendance method

        public DataTable GetWorkshopTitle(int id)
        {
            con.Open();
            cmd.CommandText = "Select ID,Title from Workshop where orgID =" + id;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Parameters.Clear();
            SqlDataReader dr = cmd.ExecuteReader();// read from database
            DataTable dt = new DataTable();
            dt.Load(dr);// fill dt with data from dr
            con.Close();
            return dt;
        }


        public DataTable getAllRegisrtationbyOrg(int id, String Title)
        {
            con.Open();
            cmd.CommandText = "Select Audience.ID AS AudID , Audience.FName +' '+ Audience.LName AS AudName ,Registration.Attendance ,Workshop.ID AS WID" +
                              " from Audience JOIN Registration ON Audience.ID=Registration.AudienceID " +
                              "Join Workshop ON Workshop.ID=Registration.WorkshopID " +
                              "WHERE Registration.OrganaizerID=" + id + " AND  Workshop.Title='" + Title + "'";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Parameters.Clear();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);// fill dt with data from dr
            con.Close();
            return dt;
        }

        public int Attendance_status_update(int id, int WorkshopID)
            {
                con.Open();
                cmd.CommandText = "Attendance_status";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@AudID", id);
                cmd.Parameters.AddWithValue("@WorkshopID", WorkshopID);
                int result = cmd.ExecuteNonQuery();
                con.Close();
                return result;
        }
    } 
}
