using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Net_Resource_Booking_Allocation.Admin.DL;

namespace Net_Resource_Booking_Allocation.Admin
{
    public partial class CommonMasterForm : System.Web.UI.Page
    {
        CommonMaster_DataHelper CM_DataHelpers = new CommonMaster_DataHelper();
        string Flag;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string Load = "CommonMaster";
                DataSet ds = CM_DataHelpers.GetDropdowns(Load);
                Binddropdowns(ds);
                chkCommonActive.Checked = true;
            }
        }

        private void Binddropdowns(DataSet ds)
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                drpgroupID.DataSource = ds.Tables[0];
                drpgroupID.DataValueField = "Group ID";
                drpgroupID.DataTextField = "Group Name";
                drpgroupID.DataBind();
            }

            if (ds.Tables[1].Rows.Count > 0)
            {
                drpInsertUserID.DataSource = ds.Tables[1];
                drpInsertUserID.DataValueField = "Resource ID";
                drpInsertUserID.DataTextField = "Resource Name";
                drpInsertUserID.DataBind();

                drpUpdateuserId.DataSource = ds.Tables[1];
                drpUpdateuserId.DataValueField = "Resource ID";
                drpUpdateuserId.DataTextField = "Resource Name";
                drpUpdateuserId.DataBind();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Flag = "Add";
            string Com_Name = txtCommonName.Text;
            string Com_Description = txtCommonDescription.Text;

            int Com_Insert_Usr_Id = Convert.ToInt16(drpInsertUserID.SelectedValue);
            int Com_Update_Usr_Id = Convert.ToInt16(drpUpdateuserId.SelectedValue);
            int Com_Yr_Id = txtCommonYrId.Text ==""? 0:Convert.ToInt16(txtCommonYrId.Text);

            int Com_Active = chkCommonActive.Checked == true ? 1 : 0;
            int Com_Del = chkCommonActive.Checked == true ? 0 : 1;
            

            //CommonMaster_DataHelper.AddCommon(Flag, Com_Name, Com_Description, Com_Insert_Usr_Id, Com_Update_Usr_Id, Com_Yr_Id, Com_Active, Com_Del);
           

            
        }
    }
}