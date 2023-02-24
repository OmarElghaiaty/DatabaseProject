using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MileStone3
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //String connStr = WebConfigurationManager.ConnectionStrings["MileStone3"].ToString();
            //SqlConnection conn = new SqlConnection(connStr);
            //String name = Name.Text;
            //String loc = Location.Text;
            //int checks = -1;
            //SqlCommand command = new SqlCommand("addClub", conn);

            //command.CommandType = CommandType.StoredProcedure;

            //command.Parameters.Add(new SqlParameter("@ClubName", name));
            //command.Parameters.Add(new SqlParameter("@location", loc));

            //conn.Open();
            //command.ExecuteNonQuery();
            //conn.Close();
        }
        protected void AddClub(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MileStone3"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String name = Name.Text;
            String loc = Location.Text;
            //int checks = -1;
            SqlCommand command = new SqlCommand("addClub", conn);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@ClubName", name));
            command.Parameters.Add(new SqlParameter("@location", loc));

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();


        }

        protected void DeleteClub(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MileStone3"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String name = Name0.Text;
            SqlCommand command = new SqlCommand("deleteClub", conn);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@ClubName", name));

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
        protected void AddStadium(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MileStone3"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String name = Name1.Text;
            String location = Location0.Text;
            String capacity = Location1.Text;
            SqlCommand command = new SqlCommand("addStadium", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@StadiumName", name));
            command.Parameters.Add(new SqlParameter("@Location", location));
            command.Parameters.Add(new SqlParameter("@Capacity", capacity));

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        protected void deleteStadium(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MileStone3"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String name = TextBox1.Text;
            SqlCommand command = new SqlCommand("deleteStadium", conn);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@StadiumName", name));

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MileStone3"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String national_id = TextBox2.Text;
            SqlCommand command = new SqlCommand("blockFan", conn);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@NationalID", national_id));

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}