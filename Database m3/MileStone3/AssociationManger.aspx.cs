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

namespace MileStone3
{
    public partial class AssociationManger : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged2(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MileStone3"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String name = TextBox1.Text;
            String username = TextBox2.Text;
            String password = TextBox3.Text;
            SqlCommand command = new SqlCommand("addAssociationManager ", conn);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@name", name));
            command.Parameters.Add(new SqlParameter("@userName", username));
            command.Parameters.Add(new SqlParameter("@password", password));


            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MileStone3"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String HostClubName = TextBox4.Text;
            String GuestClubName = TextBox5.Text;
            String StartTime = TextBox6.Text;
            String EndTime = TextBox7.Text;
            SqlCommand command = new SqlCommand("addNewMatch", conn);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@hostName", HostClubName));
            command.Parameters.Add(new SqlParameter("@GuestName", GuestClubName));
            command.Parameters.Add(new SqlParameter("@startTime", StartTime));
            command.Parameters.Add(new SqlParameter("@EndTime", EndTime));


            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MileStone3"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String HostClubName = TextBox8.Text;
            String GuestClubName = TextBox9.Text;
            String StartTime = TextBox10.Text;
            String EndTime = TextBox11.Text;
            SqlCommand command = new SqlCommand("deleteMatch", conn);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@hostName", HostClubName));
            command.Parameters.Add(new SqlParameter("@GuestName", GuestClubName));
            command.Parameters.Add(new SqlParameter("@startTime", StartTime));
            command.Parameters.Add(new SqlParameter("@EndTime", EndTime));


            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            String connStr = WebConfigurationManager.ConnectionStrings["MileStone3"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String sqlview = "SELECT host.name AS nameofhost, guest.name AS nameofguest, m.Start_time AS starttime, m.Endtime AS endtime FROM match m INNER JOIN club host ON m.host_club_ID = host.id INNER JOIN club guest ON guest.id = m.guest_club_ID INNER JOIN stadium s ON s.id = m.StadiumID WHERE m.Start_time > CURRENT_TIMESTAMP";
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

        protected void Button5_Click(object sender, EventArgs e)
        {

            String connStr = WebConfigurationManager.ConnectionStrings["MileStone3"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String sqlview = "SELECT host.name AS nameofhost, guest.name AS nameofguest, m.Start_time AS starttime, m.Endtime AS endtime FROM match m INNER JOIN club host ON m.host_club_ID = host.id INNER JOIN club guest ON guest.id = m.guest_club_ID INNER JOIN stadium s ON s.id = m.StadiumID WHERE m.Start_time < CURRENT_TIMESTAMP";
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

        protected void Button6_Click(object sender, EventArgs e)
        {

            String connStr = WebConfigurationManager.ConnectionStrings["MileStone3"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String sqlview = "SELECT one.Name as FirstName ,two.Name as SecondName\r\nfrom Club one,\r\n\tClub two\r\nwhere not exists (select m.host_club_ID,m.guest_club_ID from Match m where (host_club_ID = one.id and guest_club_ID = two.id) or (host_club_ID = two.id and guest_club_ID = one.id) ) \r\nand one.id > two.id ";
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



    }
}