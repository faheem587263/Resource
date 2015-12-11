using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Net_Resource_Booking_Allocation.Admin.DL;
using System.Data;

namespace Net_Resource_Booking_Allocation.Admin
{
    public partial class GroupMasterForm : System.Web.UI.Page
    {
        GroupMaster_DataHelper GM_DataHelpers = new GroupMaster_DataHelper();
        string Flag;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Binddropdowns();
                chkGrpActive.Checked = true;
            }
        }

        public void Binddropdowns()
        {
            string Load = "GroupMaster";
            DataSet ds = GM_DataHelpers.GetDropdowns(Load);

            if (ds.Tables[0].Rows.Count > 0)
            {
                drpInsertUserID.DataSource = ds.Tables[0];
                drpInsertUserID.DataValueField = "Group Insert User ID";
                drpInsertUserID.DataTextField = "Group Insert User Name";
                drpInsertUserID.DataBind();
            }
            drpInsertUserID.Items.Insert(0, new ListItem("Select", "NA"));

            if (ds.Tables[1].Rows.Count > 0)
            {
                drpUpdateuserId.DataSource = ds.Tables[1];
                drpUpdateuserId.DataValueField = "Group Update User ID";
                drpUpdateuserId.DataTextField = "Group Update User Name";
                drpUpdateuserId.DataBind();
            }
            drpUpdateuserId.Items.Insert(0, new ListItem("Select", "NA"));


            if (ds.Tables[2].Rows.Count > 0)
            {
                DrpGrpYrId.DataSource = ds.Tables[2];
                DrpGrpYrId.DataValueField = "Year ID";
                DrpGrpYrId.DataTextField = "Year";
                DrpGrpYrId.DataBind();
            }
            DrpGrpYrId.Items.Insert(0, new ListItem("Select", "NA"));
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Flag = "Add";
            string Grp_Name = txtGrpName.Text;
            string Grp_Description = txtGrpDescription.Text;

            int Grp_Insert_Usr_Id = drpInsertUserID.SelectedValue == "NA" ? 0: Convert.ToInt16(drpInsertUserID.SelectedValue);
            int Grp_Update_Usr_Id = drpUpdateuserId.SelectedValue == "NA" ? 0 : Convert.ToInt16(drpUpdateuserId.SelectedValue);
            int Grp_Yr_Id = DrpGrpYrId.SelectedValue == "NA" ? 0 : Convert.ToInt16(DrpGrpYrId.SelectedValue);

            int Grp_Active = chkGrpActive.Checked == true ? 1 : 0;
            int Grp_Del = chkGrpDel.Checked == true ? 1 : 0;


            GM_DataHelpers.AddGroup(Flag, Grp_Name, Grp_Description, Grp_Insert_Usr_Id, Grp_Update_Usr_Id, Grp_Yr_Id, Grp_Active, Grp_Del);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Flag = "Update";
            int Grp_Id = txtGroupID.Text == "" ? 0 : Convert.ToInt16(txtGroupID.Text);
            string Grp_Name = txtGrpName.Text;
            string Grp_Description = txtGrpDescription.Text;

            int Grp_Update_Usr_Id = drpUpdateuserId.SelectedValue == "NA" ? 0 : Convert.ToInt16(drpUpdateuserId.SelectedValue);
            int Grp_Yr_Id = DrpGrpYrId.SelectedValue == "NA" ? 0 : Convert.ToInt16(DrpGrpYrId.SelectedValue);

            int Grp_Active = chkGrpActive.Checked == true ? 1 : 0;
            int Grp_Del = chkGrpDel.Checked == true ? 1 : 0;
            GM_DataHelpers.UpdateGroup(Flag, Grp_Id, Grp_Name, Grp_Description, Grp_Update_Usr_Id, Grp_Yr_Id, Grp_Active, Grp_Del);
        }

        protected void dtynEdit_Click(object sender, EventArgs e)
        {
            int Grp_Id = txtGroupID.Text == "" ? 0 : Convert.ToInt16(txtGroupID.Text);
            Flag = "Edit";
            DataTable dt = GM_DataHelpers.EditGroup(Grp_Id, Flag);
            BindControls(dt);
        }

        private void BindControls(DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                txtGroupID.Text = dt.Rows[0]["Group ID"].ToString();
                txtGrpName.Text = dt.Rows[0]["Group Name"].ToString();
                txtGrpDescription.Text = dt.Rows[0]["Group Description"].ToString();
                DrpGrpYrId.SelectedValue = dt.Rows[0]["Year ID"].ToString() == "0" ? "NA" : dt.Rows[0]["Year ID"].ToString();
                
                //bind chekcboxes 
                chkGrpActive.Checked = dt.Rows[0]["Group Active"].ToString() == "1" ? true : false;
                chkGrpDel.Checked = dt.Rows[0]["Group Delete"].ToString() == "1" ? true : false;

                drpUpdateuserId.SelectedValue = dt.Rows[0]["Group Update User ID"].ToString() == "0" ? "NA" : dt.Rows[0]["Group Update User ID"].ToString();
                drpInsertUserID.SelectedValue = dt.Rows[0]["Group Insert User ID"].ToString() == "0" ? "NA" : dt.Rows[0]["Group Insert User ID"].ToString();
            }
            else
            {
                txtGroupID.Text = "";
                txtGrpName.Text = "";
                txtGrpDescription.Text = "";
                DrpGrpYrId.SelectedIndex = 0;
                drpInsertUserID.SelectedIndex = 0;
                drpUpdateuserId.SelectedIndex = 0;
                chkGrpActive.Checked = false;
                chkGrpDel.Checked = false;
                chkGrpActive.Checked = true;
            }
        }
    }
}