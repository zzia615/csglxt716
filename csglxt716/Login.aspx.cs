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
            if (!IsPostBack)
            {
                if (Request.Cookies["RemembeMe"] != null)
                {
                    CheckBox1.Checked = Request.Cookies["RemembeMe"].Value.AsInt() == 1 ? true : false;

                    if (CheckBox1.Checked)
                    {
                        if (Request.Cookies["Code"] != null)
                        {
                            t_code.Text = Request.Cookies["Code"].Value.AsString();
                        }
                        if (Request.Cookies["Pwd"] != null)
                        {
                            t_pwd.Attributes.Add("value", Request.Cookies["Pwd"].Value.AsString());
                        }
                    }

                }

            }
        }

        protected void b_login_Click(object sender, EventArgs e)
        {
            try
            {
                string msg;
                bool isRemembeMe = CheckBox1.Checked;
                bool ret = new BLL.UserBLL().LoginSys(t_code.Text, t_pwd.Text, out msg);
                if (ret)
                {
                    if (isRemembeMe)
                    {
                        Response.Cookies["RemembeMe"].Value = "1";
                        Response.Cookies["Code"].Value = t_code.Text;
                        Response.Cookies["Pwd"].Value = t_pwd.Text;
                    }
                    else
                    {
                        Response.Cookies.Clear();
                        Response.Cookies["RemembeMe"].Value = "0";
                    }
                }
                Response.Write(GlobalFunc.GetAlert(msg));
            }
            catch (Exception ex)
            {
                Response.Write(GlobalFunc.GetAlert(ex.Message));
            }
        }
    }
}