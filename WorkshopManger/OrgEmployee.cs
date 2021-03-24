using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;//
using System.Data;//

namespace WorkshopManger
{
    class OrgEmployee
    {

        SqlConnection con;
        SqlCommand cmd;
        
        public OrgEmployee()
        {
            // default constructor
            // con = new SqlConnection("data source=.;database=WorkshopDB;integrated security=true;");
            con = new SqlConnection("data source=LEEN-DESKTOP\\MSSQLSERVER01;database=WorkshopDB;integrated security=true;");
            cmd = new SqlCommand();
        }



        public DataTable GetEmployeeById(int id)
        {
            con.Open();
            cmd.CommandText = "select * from Organaizer_Employee where ID =" + id;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();// read from database
            DataTable dt = new DataTable();
            dt.Load(dr);// fill dt with data from dr
            con.Close();
            return dt;
        }

        public int GetOrgIdByEmpId(int id)
        {
            con.Open();
            cmd.CommandText = "select OrganizerID from Organaizer_Employee where ID =" + id;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();// read from database
            DataTable dt = new DataTable();
            dt.Load(dr);// fill dt with data from dr
            DataRow TR = dt.Rows[0];
            int OrgId = (int)TR["OrganizerID"];
            con.Close();
            return OrgId;
        }


        public DataTable GetAllEmpInOrg(int id)
        {
            con.Open();
            cmd.CommandText = "Select * from Organaizer_Employee where OrganizerID =" + id;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Parameters.Clear();
            SqlDataReader dr = cmd.ExecuteReader();// read from database
            DataTable dt = new DataTable();
            dt.Load(dr);// fill dt with data from dr
            con.Close();
            return dt;
        }

        public void AddEmp(string Fname,string Lname, string phone, string email, string password,int orgId)
        {
            con.Open();
            cmd.CommandText = "AddNewOrgEmp";//sproc name or tsql
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;// determin the connecton to command 
            cmd.Parameters.Clear();///

            cmd.Parameters.AddWithValue("@FName", Fname);
            cmd.Parameters.AddWithValue("@LName", Lname);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@Phone", phone);
            cmd.Parameters.AddWithValue("@OrganizerID", orgId);

            cmd.ExecuteNonQuery();// execute tsql 
            con.Close();

        }




        public int UpdateEmp(int id, string Fname, string Lname ,string phone, string email,int orgid)
        {
            con.Open();
            cmd.CommandText = "UpdteOrgEmployee";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Clear();///
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@FName", Fname);
            cmd.Parameters.AddWithValue("@LName", Lname);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Phone", phone);
            cmd.Parameters.AddWithValue("@OrganizerID", orgid);
            int r = cmd.ExecuteNonQuery();

            con.Close();
            return r;
        }



        public int DeleteEmp(int id)
        {
            con.Open();
            cmd.CommandText = "DeleteOrgEmployee";
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


