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
    public partial class ResourceForm : System.Web.UI.Page
    {
        DataHelpers DataHelpers = new DataHelpers();
        string Flag;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void dtynEdit_Click(object sender, EventArgs e)
        {
            int Res_Id = txtResourceId.Text == "" ? 0 : Convert.ToInt16(txtResourceId.Text);
            Flag = "Edit";
            DataTable dt = DataHelpers.EditRes(Res_Id, Flag);
            BindControls(dt);
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Flag = "Update";
            int Res_Id =txtResourceId.Text=="" ? 0: Convert.ToInt16(txtResourceId.Text);
            string Res_Name = txtResName.Text;
            string Res_Hrs_Per_Week = txtHrPrWk.Text;
            string Res_Comments = txtResComment.Text;
            string Res_Profile_Link = txtProfileLink.Text;
            string Res_Role = txtResRoll.Text;

            //BindCheckboxes
            int Res_Active = chkResActive.Checked == true ? 1 : 0;
            int Res_Del = chkResDel.Checked == true ? 1 : 0;

            //Binding Dropdowsns
            string Res_Glb_Com_Id = drpgroupName.SelectedValue;
            string Res_Ind_Com_Id = drpIncomanpyName.SelectedValue;
            string Res_Con_Id = drpConName.SelectedValue;
            string Res_Skl_Id = drpSkillName.SelectedValue;
            string Res_Insert_Usr_Id = drpInsertUserID.SelectedValue;
            string Res_Update_Usr_Id = drpUpdateuserId.SelectedValue;
            string Res_Yr_Id = DrpResYrId.SelectedValue;
            DataHelpers.UpdateRes(Res_Id, Res_Name, Res_Hrs_Per_Week, Res_Comments, Res_Profile_Link, Res_Role, Res_Active, Res_Del, Res_Glb_Com_Id, Res_Ind_Com_Id, Res_Con_Id, Res_Skl_Id, Res_Insert_Usr_Id, Res_Update_Usr_Id, Res_Yr_Id, Flag);
        }

        protected void BindControls(DataTable dt)
        {
            //Binding Textboxes
            if (dt.Rows.Count > 0)
            {
                txtResourceId.Text = dt.Rows[0]["Resource Id"].ToString();
                txtResName.Text = dt.Rows[0]["Resource Name"].ToString();
                txtHrPrWk.Text = dt.Rows[0]["Resource Hour Per Week"].ToString();
                txtResComment.Text = dt.Rows[0]["Resource Comment"].ToString();
                txtProfileLink.Text = dt.Rows[0]["Resource Profile Link"].ToString();
                txtResRoll.Text = dt.Rows[0]["Resource Roll"].ToString();

                //BindCheckboxes
                chkResActive.Checked = dt.Rows[0]["Resource Active"].ToString() == "1" ? true : false;
                chkResDel.Checked = dt.Rows[0]["Resource Delete"].ToString() == "1" ? true : false;


                //Binding Dropdowsns
                drpgroupName.DataSource = dt;
                drpgroupName.DataValueField = "Resource Global Company ID";
                drpgroupName.DataBind();

                drpIncomanpyName.DataSource = dt;
                drpIncomanpyName.DataValueField = "Resource India Company ID";
                drpIncomanpyName.DataBind();

                drpConName.DataSource = dt;
                drpConName.DataValueField = "Resource Country ID";
                drpConName.DataBind();

                drpSkillName.DataSource = dt;
                drpSkillName.DataValueField = "Resource Skill ID";
                drpSkillName.DataBind();

                drpInsertUserID.DataSource = dt;
                drpInsertUserID.DataValueField = "Resource Insert User ID";
                drpInsertUserID.DataBind();

                drpUpdateuserId.DataSource = dt;
                drpUpdateuserId.DataValueField = "Resource Update User ID";
                drpUpdateuserId.DataBind();

                DrpResYrId.DataSource = dt;
                DrpResYrId.DataValueField = "Resource Yr ID";
                DrpResYrId.DataBind();
            }
        }

        protected void dtynAdd_Click(object sender, EventArgs e)
        {
            Flag = "Add";
            string Res_Name = txtResName.Text;
            string Res_Hrs_Per_Week = txtHrPrWk.Text;
            string Res_Comments = txtResComment.Text;
            string Res_Profile_Link = txtProfileLink.Text;
            string Res_Role = txtResRoll.Text;

            //BindCheckboxes
            int Res_Active = chkResActive.Checked == true ? 1 : 0;
            int Res_Del = chkResDel.Checked == true ? 1 : 0;

            //Binding Dropdowsns
            string Res_Glb_Com_Id = drpgroupName.SelectedValue;
            string Res_Ind_Com_Id = drpIncomanpyName.SelectedValue;
            string Res_Con_Id = drpConName.SelectedValue;
            string Res_Skl_Id = drpSkillName.SelectedValue;
            string Res_Insert_Usr_Id = drpInsertUserID.SelectedValue;
            string Res_Update_Usr_Id = drpUpdateuserId.SelectedValue;
            string Res_Yr_Id = DrpResYrId.SelectedValue;
            DataHelpers.AddRes(Res_Name, Res_Hrs_Per_Week, Res_Comments, Res_Profile_Link, Res_Role, Res_Active, Res_Del, Res_Glb_Com_Id, Res_Ind_Com_Id, Res_Con_Id, Res_Skl_Id, Res_Insert_Usr_Id, Res_Update_Usr_Id, Res_Yr_Id, Flag);
        }
    }
}