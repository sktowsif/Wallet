using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Money_Tracker.Websites
{
    public partial class MainPage : System.Web.UI.Page
    {
        public void Download(int intRandom)
        {
            
            byte[] bytArrFileContent = File.ReadAllBytes(@"C:\Users\Swathi Manindra\Documents\GitHub\Wallet\Money-Tracker\Money-Tracker\Downloads\ExcelData" + intRandom + ".xlsx");
            Response.ContentType = "application/application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            Response.AddHeader("content-disposition", "attachment; filename=ExcelData" + intRandom + ".xlsx");
            Response.BufferOutput = true;
            Response.OutputStream.Write(bytArrFileContent, 0, bytArrFileContent.Length);
            Response.End();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //hdnId.Value = Session["UserId"].ToString();
            //int ID;
            //int.TryParse(hdnId.Value, out ID);
            //if (ID < 0)
            //    Response.Redirect("Home.aspx");
        }
    }
}