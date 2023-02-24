using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Reflection;
using System.Text.RegularExpressions;
using System.ComponentModel;

namespace MileStone3
{
    public partial class ClubRepresentitve : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String cr = (String)Session["user"];
            Response.Write(cr);
        }


        protected void Register(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MileStone3"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String name = TextBox1.Text;
            String username = TextBox2.Text;
            String password = TextBox3.Text;
            String clubName = TextBox4.Text;
            SqlCommand command = new SqlCommand("addRepresentative", conn);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@RepName", name));
            command.Parameters.Add(new SqlParameter("@ClubName", clubName));
            command.Parameters.Add(new SqlParameter("@UserName", username));
            command.Parameters.Add(new SqlParameter("@Password", password));



            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        protected void ViewInfo(object sender, EventArgs e)
        {
           
                String cr = (String)Session["user"];

                String connStr = WebConfigurationManager.ConnectionStrings["MileStone3"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                String sqlview = "SELECT c.* FROM Clubrepresentative cr INNER JOIN Club c ON cr.ClubID = c.ID WHERE cr.username = '" + cr +"'";
                SqlCommand sqlcomm = new SqlCommand(sqlview, conn);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                StringBuilder sb = new StringBuilder();
                sb.Append("<center>");
                sb.Append("<table border=1>");
                sb.Append("<thead>");
                sb.Append("<tr>");
                foreach (DataColumn dc in dt.Columns)
                {
                    sb.Append("<th>");
                    sb.Append(dc.ColumnName.ToUpper());
                    sb.Append("</th>");
                }
                sb.Append("</tr>");
                sb.Append("</thead>");
                sb.Append("<br>");
                foreach (DataRow dr in dt.Rows)
                {
                    sb.Append("<tr>");
                    foreach (DataColumn dc in dt.Columns)
                    {
                        sb.Append("<td>");
                        sb.Append(dr[dc.ColumnName].ToString());
                        sb.Append("</td>");
                    }
                    sb.Append("</tr>");
                    sb.Append("<br>");
                }
                sb.Append("</table>");
                sb.Append("</center>");
                Panel1.Controls.Add(new Label { Text = sb.ToString() });
            }
        protected void ViewMatch(object sender, EventArgs e)
        {
            String cr = (String)Session["user"];
            String connStr = WebConfigurationManager.ConnectionStrings["MileStone3"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String sqlview = "SELECT host.name AS nameofhost, guest.name AS nameofguest, m.Start_time AS starttime, m.Endtime as endtime, s.name AS stadiumname FROM match m INNER JOIN club host ON m.host_club_ID = host.id INNER JOIN club guest ON guest.id = m.guest_club_ID INNER JOIN stadium s ON s.id = m.StadiumID inner join Clubrepresentative cr on cr.ClubID = host.ID WHERE (@name = host.name OR @name = guest.name) AND m.Start_time > CURRENT_TIMESTAMP and cr.username = '" + cr +"'";
            SqlCommand sqlcomm = new SqlCommand(sqlview, conn);
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            StringBuilder sb = new StringBuilder();
            sb.Append("<center>");
            sb.Append("<table border=1>");
            sb.Append("<thead>");
            sb.Append("<tr>");
            foreach (DataColumn dc in dt.Columns)
            {
                sb.Append("<th>");
                sb.Append(dc.ColumnName.ToUpper());
                sb.Append("</th>");
            }
            sb.Append("</tr>");
            sb.Append("</thead>");
            sb.Append("<br>");
            foreach (DataRow dr in dt.Rows)
            {
                sb.Append("<tr>");
                foreach (DataColumn dc in dt.Columns)
                {
                    sb.Append("<td>");
                    sb.Append(dr[dc.ColumnName].ToString());
                    sb.Append("</td>");
                }
                sb.Append("</tr>");
                sb.Append("<br>");
            }
            sb.Append("</table>");
            sb.Append("</center>");
            Panel2.Controls.Add(new Label { Text = sb.ToString() });
        }

        protected void viewStadium(object sender, EventArgs e)
        {
            String date = TextBox9.Text;
            DateTime date1 =  DateTime.Parse(date);
            String connStr = WebConfigurationManager.ConnectionStrings["MileStone3"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String sqlview = "select Name,Location,Capacity from Stadium s inner join Match m on m.StadiumID = s.ID where ('" +date+"' not between m.Start_time and m.Endtime) and s.Status = 1";
            SqlCommand sqlcomm = new SqlCommand(sqlview, conn);
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            StringBuilder sb = new StringBuilder();
            sb.Append("<center>");
            sb.Append("<table border=1>");
            sb.Append("<thead>");
            sb.Append("<tr>");
            foreach (DataColumn dc in dt.Columns)
            {
                sb.Append("<th>");
                sb.Append(dc.ColumnName.ToUpper());
                sb.Append("</th>");
            }
            sb.Append("</tr>");
            sb.Append("</thead>");
            sb.Append("<br>");
            foreach (DataRow dr in dt.Rows)
            {
                sb.Append("<tr>");
                foreach (DataColumn dc in dt.Columns)
                {
                    sb.Append("<td>");
                    sb.Append(dr[dc.ColumnName].ToString());
                    sb.Append("</td>");
                }
                sb.Append("</tr>");
                sb.Append("<br>");
            }
            sb.Append("</table>");
            sb.Append("</center>");
            Panel3.Controls.Add(new Label { Text = sb.ToString() });
        }

        protected void SendReq(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MileStone3"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String ClubName = TextBox6.Text;
            String StadiumName = TextBox7.Text;
            String StartTime = TextBox8.Text;
            SqlCommand command = new SqlCommand("addHostRequest", conn);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@ClubName", ClubName));
            command.Parameters.Add(new SqlParameter("@StadiumName", StadiumName));
            command.Parameters.Add(new SqlParameter("@StartTime", StartTime));



            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }




    } 


    }
