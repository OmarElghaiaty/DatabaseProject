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
    public partial class logins : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void login(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MileStone3"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String usernames = (username.Text);
            String pass = password.Text;
            SqlCommand loginproc = new SqlCommand("Checksfan", conn);
            loginproc.Parameters.Add(new SqlParameter("@username", usernames));
            loginproc.Parameters.Add(new SqlParameter("@password", pass));
            int checks = -1;
            using (SqlCommand command = new SqlCommand("SELECT dbo.checkadmin(@username,@password)", conn))
            {
                command.CommandType = CommandType.Text;

                command.Parameters.AddWithValue("@username", usernames);
                command.Parameters.AddWithValue("@password", pass);

                object result = command.ExecuteScalar();
                checks = (int)result;


            }
            if (checks == 1)
                Response.Redirect("fans.aspx");
            else if (checks == 2)
                Response.Redirect("ClubRepresentitve.aspx");
            else if (checks == 3)
                Response.Redirect("StadiumManager.aspx");
            else if (checks == 4)
                Response.Redirect("AssociationManger.aspx");
            else
                Response.Write("This username or password is incorrect");

        }
    }
}