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
                Binddropdowns();
                chkCommonActive.Checked = true;
            }
        }

        public void Binddropdowns()
        {
            string Load = "CommonMaster";
            DataSet ds = CM_DataHelpers.GetDropdowns(Load);

            if (ds.Tables[0].Rows.Count > 0)
            {
                drpgroupID.DataSource = ds.Tables[0];
                drpgroupID.DataValueField = "Common Group ID";
                drpgroupID.DataTextField = "Common Group Name";
                drpgroupID.DataBind();
            }
            drpgroupID.Items.Insert(0, new ListItem("Select", "NA"));

            if (ds.Tables[1].Rows.Count > 0)
            {
                drpInsertUserID.DataSource = ds.Tables[1];
                drpInsertUserID.DataValueField = "Common Insert User ID";
                drpInsertUserID.DataTextField = "Common Insert User Name";
                drpInsertUserID.DataBind();
            }
            drpInsertUserID.Items.Insert(0, new ListItem("Select", "NA"));

            if (ds.Tables[2].Rows.Count > 0)
            {
                drpUpdateuserId.DataSource = ds.Tables[2];
                drpUpdateuserId.DataValueField = "Common Update User ID";
                drpUpdateuserId.DataTextField = "Common Update User Name";
                drpUpdateuserId.DataBind();
            }
            drpUpdateuserId.Items.Insert(0, new ListItem("Select", "NA"));
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
            Flag = "Add";
            string Com_Name = txtCommonName.Text;
            string Com_Description = txtCommonDescription.Text;

            int Com_Grp_Id = Convert.ToInt16(drpgroupID.SelectedValue);
            int Com_Insert_Usr_Id = drpInsertUserID.SelectedValue == "NA" ? 0:Convert.ToInt16(drpInsertUserID.SelectedValue); //check 
            int Com_Yr_Id = txtCommonYrId.Text == "" ? 0 : Convert.ToInt16(txtCommonYrId.Text);

            int Com_Active = chkCommonActive.Checked == true ? 1 : 0;
            int Com_Del = chkCommonActive.Checked == true ? 0 : 1;


            CM_DataHelpers.AddCommon(Flag, Com_Name, Com_Description, Com_Grp_Id, Com_Insert_Usr_Id, Com_Yr_Id, Com_Active, Com_Del);
        }

        public void dtynEdit_Click(object sender, EventArgs e)
        {
            int Com_Id = txtCommonID.Text == "" ? 0 : Convert.ToInt16(txtCommonID.Text);
            Flag = "Edit";
            DataTable dt = CM_DataHelpers.EditCommont(Com_Id, Flag);
            BindControls(dt);
        }

        public void btnSubmit_Click(object sender, EventArgs e)
        {
            Flag = "Update";
            int Com_Id = txtCommonID.Text == "" ? 0 : Convert.ToInt16(txtCommonID.Text);
            string Com_Name = txtCommonName.Text;
            string Com_Description = txtCommonDescription.Text;

            int Com_Grp_Id = Convert.ToInt16(drpgroupID.SelectedValue);
            int Com_Update_Usr_Id = drpUpdateuserId.SelectedValue == "NA" ? 0: Convert.ToInt16(drpUpdateuserId.SelectedValue);
            int Com_Yr_Id = txtCommonYrId.Text == "" ? 0 : Convert.ToInt16(txtCommonYrId.Text);

            int Com_Active = chkCommonActive.Checked == true ? 1 : 0;
            int Com_Del = chkCommonActive.Checked == true ? 0 : 1;

            CM_DataHelpers.UpdateCommon(Flag, Com_Id, Com_Name, Com_Description, Com_Grp_Id, Com_Update_Usr_Id, Com_Yr_Id, Com_Active, Com_Del);
        }

        public void BindControls(DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                //Binding Textboxes
                txtCommonID.Text = dt.Rows[0]["Common ID"].ToString();
                txtCommonName.Text = dt.Rows[0]["Common Name"].ToString();
                txtCommonDescription.Text = dt.Rows[0]["Common Description"].ToString();
                txtCommonYrId.Text = dt.Rows[0]["Common Yr ID"].ToString();

                //bind chekcboxes 
                chkCommonActive.Checked = dt.Rows[0]["Common Active"].ToString() == "1" ? false : true;
                chkCommonActive.Checked = dt.Rows[0]["Common Delete"].ToString() == "1" ? false : true;

                drpgroupID.SelectedValue = dt.Rows[0]["Common Group ID"].ToString();
                drpUpdateuserId.SelectedValue = dt.Rows[0]["Common Update User ID"].ToString();
                drpInsertUserID.SelectedValue = dt.Rows[0]["Common Insert User ID"].ToString();

            }
            else
            {
                txtCommonID.Text = "";
                txtCommonName.Text = "";
                txtCommonDescription.Text = "";
                txtCommonYrId.Text = "";
                drpgroupID.SelectedIndex = 1;
                drpInsertUserID.SelectedIndex = 1;
                drpUpdateuserId.SelectedIndex = 1;
                chkCommonActive.Checked = false;
                chkCommonActive.Checked = false;
            }
        }

    }
}