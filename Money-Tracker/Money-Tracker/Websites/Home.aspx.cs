using Money_Tracker.EntityClasses;
using System;
using System.Web.Services;

namespace Money_Tracker.Websites
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static int CheckLoginDetails(object[] objCred)
        {
            User objUser = new User();
            int intUserID = objUser.IsValidLogin(objCred);
            return intUserID;
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
        //    string strEmail=txt_email.Text;
        //    string strPwd = txt_pwd.Text;
        //    object[] objLoginUser = new object[] { strEmail, strPwd };
        //    User objUser = new User();
        //    Session["UserID"] = objUser.IsValidLogin(objLoginUser);
        }
    }
}