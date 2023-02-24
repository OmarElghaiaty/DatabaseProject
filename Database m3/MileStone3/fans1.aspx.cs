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
    public partial class fans1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MileStone3"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String Name = TextBox1.Text;
            String UserName = TextBox2.Text;
            String Password = TextBox3.Text;
            String NationalIdNumber = TextBox4.Text;
            String PhoneNumber = TextBox5.Text;
            String BirthDate = TextBox6.Text;
            String Address = TextBox7.Text;
            SqlCommand command = new SqlCommand("addFan", conn);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@Name", Name));
            command.Parameters.Add(new SqlParameter("@UserName", UserName));
            command.Parameters.Add(new SqlParameter("@Password", Password));
            command.Parameters.Add(new SqlParameter("@NationalID", NationalIdNumber));
            command.Parameters.Add(new SqlParameter("@PhoneNum", PhoneNumber));
            command.Parameters.Add(new SqlParameter("@birthdate", BirthDate));
            command.Parameters.Add(new SqlParameter("@address", Address));


            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}