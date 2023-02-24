using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.EnterpriseServices.CompensatingResourceManager;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace MileStone3
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void login(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["MileStone3"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String usernames = username.Text;
            String pass = password.Text;
            int checks = -1;
            SqlCommand command = new SqlCommand("select dbo.ChecksFan(@username,@password)", conn);
           
            command.CommandType = CommandType.Text;

            command.Parameters.AddWithValue("@username", usernames);
            command.Parameters.AddWithValue("@password", pass);
            
            conn.Open();
            checks = (int)command.ExecuteScalar();
            conn.Close();
               
            if (checks == 1)
            {
                Session["user"] = usernames;
                Response.Redirect("fans.aspx");
            }

            else if (checks == 2) {
                Session["user"] = usernames;
                Response.Redirect ("ClubRepresentitve.aspx");
            }
            else if (checks == 3)
            {
                Session["user"] = usernames;
                Response.Redirect ("StadiumManager.aspx");
            }
            else if (checks == 4)
            {
                Session["user"] = usernames ;
                Response.Redirect("AssociationManger.aspx");
            }
            else if (checks == 5)
            {
                Session["user"] = usernames ;
                Response.Redirect("admin.aspx");
            }
            else
                Response.Write("This username or password is incorrect");
        }
    }
}