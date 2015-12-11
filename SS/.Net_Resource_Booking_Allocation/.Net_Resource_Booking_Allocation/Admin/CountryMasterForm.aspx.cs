using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Net_Resource_Booking_Allocation.Admin.DL;

namespace Net_Resource_Booking_Allocation.Admin
{
    public partial class CountryMasterForm : System.Web.UI.Page
    {
        CountryMaster_DataHelper CM_DataHelpers = new CountryMaster_DataHelper();
        string Flag;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            //    string Load = "CommonMaster";
            //    DataSet ds = CM_DataHelpers.GetDropdowns(Load);
            //    Binddropdowns(ds);
            //    chkCommonActive.Checked = true;
            }
        }

        protected void dtynSubmit_Click(object sender, EventArgs e)
        {
            Flag = "Update";
           
            string Prj_Country_Name = txtCountryName.Text;
            int Prj_Country_Active = chkCountryActive.Checked == true ? 1 : 0;
            int Prj_Country_Delete = chkCountryDel.Checked == true ? 1 : 0;
            string Prj_Insert_User_ID = drpInsertUserID.SelectedValue;
            string Prj_Update_User_ID = drpUpdateUserId.SelectedValue;
            string Prj_Country_Yr_ID = drpCountryYrId.SelectedValue;

            CM_DataHelpers.AddCountry(Flag, Prj_Country_Name, Prj_Country_Active, Prj_Country_Delete, Prj_Insert_User_ID, Prj_Update_User_ID, Prj_Country_Yr_ID);

        }
        protected void dtynEdit_Click(object sender, EventArgs e)
        {
            Flag = "Edit";

            

        }
    }
}