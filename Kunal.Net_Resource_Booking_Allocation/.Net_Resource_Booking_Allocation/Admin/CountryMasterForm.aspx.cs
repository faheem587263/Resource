using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Net_Resource_Booking_Allocation.Admin
{
    public partial class CountryMasterForm : System.Web.UI.Page
    {
        string Flag;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void dtynSubmit_Click(object sender, EventArgs e)
        {
           
           
          

        
        }
        protected void dtynEdit_Click(object sender, EventArgs e)
        {
            Flag = "Edit";

            

        }
        protected void dtynAdd_Click(object sender, EventArgs e)
        {
            Flag = "Add";

            string Prj_Country_Name = txtCountryName.Text;
            int Prj_Country_Active = chkCountryActive.Checked == true ? 1 : 0;
            int Prj_Country_Delete = chkCountryDel.Checked == true ? 1 : 0;
            string Prj_Insert_User_ID = drpInsertUserID.SelectedValue;
            string Prj_User_User_ID = drpUpdateUserId.SelectedValue;
            string Prj_Country_Yr_ID = drpCountryYrId.SelectedValue;



        }

        
    }
}