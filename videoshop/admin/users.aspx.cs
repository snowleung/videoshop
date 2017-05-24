using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;


namespace videoshop.admin
{
    public partial class users : System.Web.UI.Page
    {
        protected void Bind_DataSource() {
            SqlDataSource1.ConnectionString = ConfigurationManager.ConnectionStrings["videoshop"].ConnectionString;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Bind_DataSource();
            string nickName = Request.QueryString["nickname"];
            if (nickName != null) {
                SqlDataSource1.SelectCommand = "select * from users where nickname='" + nickName + "'";

            }
        }
    }
}