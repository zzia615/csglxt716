using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace csglxt716
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void b_login_Click(object sender, EventArgs e)
        {
            try
            {
                string msg;
                new BLL.UserBLL().LoginSys(t_code.Text, t_pwd.Text, out msg);
                Response.Write(GlobalFunc.GetAlert(msg));
            }
            catch (Exception ex)
            {
                Response.Write(GlobalFunc.GetAlert(ex.Message));
            }
        }
    }
}