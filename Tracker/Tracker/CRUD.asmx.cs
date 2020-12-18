﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Web.UI.DataVisualization.Charting;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace Tracker
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CVRB3RF\\AMIRSQLSERVER;Initial Catalog=Tracker;Integrated Security=True");
        [WebMethod]
        public void register(string name, string gender, int age, float weight, float blood_pressure
            , string username, string password)
        {
            con.Open();
            DateTime d = DateTime.Now;
            SqlCommand cmd = new SqlCommand("insert into dbo.users(name,gender,age,weight,bloodPressure,username,password)" +
                " values(@name,@gender,@age,@weight,@blood_pressure,@username,@password)", con);

            SqlParameter p1 = new SqlParameter("@name", name);
            SqlParameter p2 = new SqlParameter("@gender", gender);
            SqlParameter p3 = new SqlParameter("@age", age);
            SqlParameter p4 = new SqlParameter("@weight", weight);
            SqlParameter p5 = new SqlParameter("@blood_pressure", blood_pressure);
            SqlParameter p6 = new SqlParameter("@username", username);
            SqlParameter p7 = new SqlParameter("@password", password);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("select id from dbo.users where username=@username;", con);
            cmd.Parameters.Add(new SqlParameter("@username", username));
            int id = 0;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
            }
            reader.Close();
            cmd=new SqlCommand("insert into dbo.readings (id , bloodPressure,date) values (@id,@blood_pressure,@d);", con);
            cmd.Parameters.Add(new SqlParameter("@id", id));
            cmd.Parameters.Add(new SqlParameter("@blood_pressure", blood_pressure));
            cmd.Parameters.Add(new SqlParameter("@d", d));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        [WebMethod]
        public bool login(ref int id, string username, string password)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select id,username , password from dbo.users where username=@username and password = @password;", con);
            SqlParameter p6 = new SqlParameter("@username", username);
            SqlParameter p7 = new SqlParameter("@password", password);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }

        [WebMethod]
        public void update_info(int id, string name, string gender, int age, float weight, float blood_pressure
            , string username, string password)
        {

            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("update dbo.users set name=@name , gender=@gender , age=@age , weight=@weight, bloodPressure=@blood_pressure , username=@username , password=@password where id=@id;", con);
            SqlParameter p1 = new SqlParameter("@name", name);
            SqlParameter p2 = new SqlParameter("@gender", gender);
            SqlParameter p3 = new SqlParameter("@age", age);
            SqlParameter p4 = new SqlParameter("@weight", weight);
            SqlParameter p5 = new SqlParameter("@blood_pressure", blood_pressure);
            SqlParameter p6 = new SqlParameter("@username", username);
            SqlParameter p7 = new SqlParameter("@password", password);
            SqlParameter p8 = new SqlParameter("@id", id);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            cmd.Parameters.Add(p8);
            adapter.UpdateCommand = cmd;
            adapter.UpdateCommand.ExecuteNonQuery();
            con.Close();
        }
        [WebMethod]
        public void view_info(int id, ref string name, ref string gender, ref int age, ref double weight, ref double blood_pressure
            , ref string username, ref string password)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select name,gender,age,weight,bloodPressure,username , password from dbo.users where id=@id;", con);
            SqlParameter p8 = new SqlParameter("@id", id);
            cmd.Parameters.Add(p8);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    name = reader.GetString(0);
                    gender = reader.GetString(1);
                    age = reader.GetInt32(2);
                    weight = Convert.ToDouble(reader["weight"]);
                    blood_pressure = Convert.ToDouble(reader["bloodPressure"]);
                    username = reader.GetString(5);
                    password = reader.GetString(6);
                }

            }
            con.Close();
        }

        [WebMethod]
        public void saveReading(int id, float blood_pressure)
        {
            con.Open();
            DateTime d = DateTime.Now;
            SqlCommand cmd = new SqlCommand("insert into dbo.readings (id , bloodPressure,readingDate) values (@id,@blood_pressure,@d);", con);
            cmd.Parameters.Add(new SqlParameter("@id", id));
            cmd.Parameters.Add(new SqlParameter("@blood_pressure", blood_pressure));
            cmd.Parameters.Add(new SqlParameter("@d", d));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        [WebMethod]
        public DateTime bpReminder(int id)
        {
            con.Open();
            DateTime d = DateTime.Now;
            DateTime received = DateTime.Now;
            SqlCommand cmd = new SqlCommand("select max(readingDate) from dbo.readings where id=@id;", con);
            cmd.Parameters.Add(new SqlParameter("@id", id));
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    received = reader.GetDateTime(0);
                }
            }
            con.Close();
            TimeSpan temp = new TimeSpan(0, 0, 20, 0);
            if (d.Subtract(received) > temp)
            {
                return received;
            }
            DateTime fault = new DateTime(2001, 1, 1);
            return fault;
        }

        [WebMethod]
        public DataSet graphPlotting(int id)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select bloodPressure,readingDate from dbo.readings where id=@id order by readingDate asc", con);
            cmd.Parameters.Add(new SqlParameter("@id", id));
            SqlDataAdapter dA = new SqlDataAdapter();
            dA.SelectCommand = cmd;
            DataSet ds = new DataSet();
            dA.Fill(ds);
            return ds;
        }
    }
}
