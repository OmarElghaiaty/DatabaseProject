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
            SqlCommand command = new SqlCommand("addAssociationManager", conn);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@name", name));
            command.Parameters.Add(new SqlParameter("@userName", username));
            command.Parameters.Add(new SqlParameter("@password", password));


            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}