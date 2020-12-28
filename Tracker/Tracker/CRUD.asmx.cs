using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Web.UI.DataVisualization.Charting;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;
using System.Web.Services;

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
        public static string projectMail = "tracker.Archi@gmail.com";
        public static string projectPass = "AASS4TEAM";
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RIMF1UF\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        [WebMethod]
        public void register(string name, string gender, int age,string gmail, float weight, float blood_pressure
            , string username, string password, float height)
        {
            con.Open();
            DateTime d = DateTime.Now;
            SqlCommand cmd = new SqlCommand("insert into dbo.users(name,gender,age,weight,bloodPressure,username,password,height,gmail)" +
                " values(@name,@gender,@age,@weight,@blood_pressure,@username,@password,@height,@gmail)", con);

            SqlParameter p1 = new SqlParameter("@name", name);
            SqlParameter p2 = new SqlParameter("@gender", gender);
            SqlParameter p3 = new SqlParameter("@age", age);
            SqlParameter p4 = new SqlParameter("@weight", weight);
            SqlParameter p5 = new SqlParameter("@blood_pressure", blood_pressure);
            SqlParameter p6 = new SqlParameter("@username", username);
            SqlParameter p7 = new SqlParameter("@password", password);
            SqlParameter p8 = new SqlParameter("@height", height);
            SqlParameter p9 = new SqlParameter("@gmail", gmail);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            cmd.Parameters.Add(p8);
            cmd.Parameters.Add(p9);
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
            cmd=new SqlCommand("insert into dbo.readings (id , bloodPressure,readingDate) values (@id,@blood_pressure,@d);", con);
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
        public bool update_info(int id, string name, int age, float weight
            , string username, string password, float height, string gmail)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("update dbo.users set name=@name, age=@age,weight=@weight,username=@username,password=@password,height=@height,gmail=@gmail where id=@id;", con);
            SqlParameter p1 = new SqlParameter("@name", name);
           
            SqlParameter p3 = new SqlParameter("@age", age);
            SqlParameter p4 = new SqlParameter("@weight", weight);
            SqlParameter p6 = new SqlParameter("@username", username);
            SqlParameter p7 = new SqlParameter("@password", password);
            SqlParameter p8 = new SqlParameter("@id", id);
            SqlParameter p9 = new SqlParameter("@height", height);
            SqlParameter p10 = new SqlParameter("@gmail", gmail);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            cmd.Parameters.Add(p8);
            cmd.Parameters.Add(p9);
            cmd.Parameters.Add(p10);
            bool success = true;
            try
            {
            cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                success = false;
            }
            con.Close();
            return success;
            
        }
        [WebMethod]
        public void view_info(int id, ref string name, ref string gender, ref int age, ref double weight, ref double blood_pressure
            , ref string username, ref string password,ref double height,ref string gmail)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select name,gender,age,weight,bloodPressure,username , password,height,gmail from dbo.users where id=@id;", con);
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
                    height = Convert.ToDouble(reader["height"]);
                    gmail = reader.GetString(8);
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
        [WebMethod]
        public double getLatestBP(int id)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select bloodPressure from dbo.readings where readingDate = (select MAX(readingDate) from dbo.readings where id = @id);", con);
            cmd.Parameters.Add(new SqlParameter("@id", id));
            SqlDataReader rd = cmd.ExecuteReader();
            double current_bp=0;
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    current_bp = Convert.ToDouble(rd["bloodPressure"]);
                }
            }
            con.Close();
            return current_bp;
        }
        [WebMethod]
        public void getDietPlan(string range,ref string breakfast,ref string lunch,ref string dinner,ref string notes)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select breakfast,lunch,dinner,notes from dbo.Diet_Plans where range=@range;", con);
            SqlParameter p8 = new SqlParameter("@range", range);
            cmd.Parameters.Add(p8);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    breakfast = reader.GetString(0);
                    lunch = reader.GetString(1);
                    dinner = reader.GetString(2);
                    notes = reader.GetString(3);
                }
            }
            con.Close();
        }
        [WebMethod]
        public string getGmail(int id)
        {
            con.Open();
            string gmail = null;
            SqlCommand cmd = new SqlCommand("select gmail from users where id=@id", con);
            cmd.Parameters.Add(new SqlParameter("@id", id));
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    gmail = rd.GetString(0);
                }
            }
            con.Close();
            return gmail;
        }
        [WebMethod]
        public bool sendDietPlan(string userGmail,string mailBody )
        {
            bool sent = true;
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(projectMail);
                    mail.To.Add(userGmail);
                    mail.Subject = "Your diet plan";
                    mail.Body = mailBody;
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new System.Net.NetworkCredential(projectMail, projectPass);
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }
            }
            catch (Exception e)
            {
                sent = false;
            }


            return sent;
        }

    }
}
