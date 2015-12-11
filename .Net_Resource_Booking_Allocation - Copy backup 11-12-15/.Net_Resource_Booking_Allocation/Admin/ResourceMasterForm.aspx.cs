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
        ResourceMaster_DataHelper RM_DataHelper = new ResourceMaster_DataHelper();
        string Flag;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Binddropdowns();
                chkResActive.Checked = true;
            }
        }


        private void Binddropdowns()
        {
            string Load = "ResourceMaster";
            DataSet ds = RM_DataHelper.GetDropdowns(Load);

            if (ds.Tables[0].Rows.Count > 0)
            {
                drpgroupName.DataSource = ds.Tables[0];
                drpgroupName.DataValueField = "Resource Global Company ID";
                drpgroupName.DataTextField = "Global ID Name";
                drpgroupName.DataBind();
            }
            drpgroupName.Items.Insert(0, new ListItem("Select", "NA"));

            if (ds.Tables[1].Rows.Count > 0)
            {
                drpIncomanpyName.DataSource = ds.Tables[1];
                drpIncomanpyName.DataValueField = "Resource India Company ID";
                drpIncomanpyName.DataTextField = "India ID Name";
                drpIncomanpyName.DataBind();
            }
            drpIncomanpyName.Items.Insert(0, new ListItem("Select", "NA"));


            if (ds.Tables[2].Rows.Count > 0)
            {
                drpConName.DataSource = ds.Tables[2];
                drpConName.DataValueField = "Resource Country ID";
                drpConName.DataTextField = "Country Name";
                drpConName.DataBind();
            }
            drpConName.Items.Insert(0, new ListItem("Select", "NA"));


            if (ds.Tables[3].Rows.Count > 0)
            {
                drpSkillName.DataSource = ds.Tables[3];
                drpSkillName.DataValueField = "Resource Skill ID";
                drpSkillName.DataTextField = "Skill Name";
                drpSkillName.DataBind();
            }

            drpSkillName.Items.Insert(0, new ListItem("Select", "NA"));
            if (ds.Tables[4].Rows.Count > 0)
            {
                drpInsertUserID.DataSource = ds.Tables[4];
                drpInsertUserID.DataValueField = "Resource Insert User ID";
                drpInsertUserID.DataTextField = "Resource Insert User Name";
                drpInsertUserID.DataBind();
            }
            drpInsertUserID.Items.Insert(0, new ListItem("Select", "NA"));

            if (ds.Tables[5].Rows.Count > 0)
            {
                drpUpdateuserId.DataSource = ds.Tables[5];
                drpUpdateuserId.DataValueField = "Resource Update User ID";
                drpUpdateuserId.DataTextField = "Resource Update User Name";
                drpUpdateuserId.DataBind();
            }
            drpUpdateuserId.Items.Insert(0, new ListItem("Select", "NA"));


            if (ds.Tables[6].Rows.Count > 0)
            {
                DrpResYrId.DataSource = ds.Tables[6];
                DrpResYrId.DataValueField = "Resource Yr ID";
                DrpResYrId.DataTextField = "Year";
                DrpResYrId.DataBind();
            }
            DrpResYrId.Items.Insert(0, new ListItem("Select", "NA"));
        }
        protected void dtynEdit_Click(object sender, EventArgs e)
        {
            int Res_Id = txtResourceId.Text == "" ? 0 : Convert.ToInt16(txtResourceId.Text);
            Flag = "Edit";
            DataTable dt = RM_DataHelper.EditRes(Res_Id, Flag);
            BindControls(dt);
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Flag = "Update";
            int Res_Id = txtResourceId.Text == "" ? 0 : Convert.ToInt16(txtResourceId.Text);
            string Res_Name = txtResName.Text;
            string Res_Hrs_Per_Week = txtHrPrWk.Text;
            string Res_Comments = txtResComment.Text;
            string Res_Profile_Link = txtProfileLink.Text;
            string Res_Role = txtResRoll.Text;

            //BindCheckboxes
            int Res_Active = chkResActive.Checked == true ? 1 : 0;
            int Res_Del = chkResDel.Checked == true ? 1 : 0;

            //Binding Dropdowsns
            int Res_Glb_Com_Id = drpgroupName.SelectedValue == "NA" ? 0 : Convert.ToInt16(drpgroupName.SelectedValue);
            int Res_Ind_Com_Id = drpIncomanpyName.SelectedValue == "NA" ? 0 : Convert.ToInt16(drpIncomanpyName.SelectedValue); ;
            int Res_Con_Id = drpConName.SelectedValue == "NA" ? 0 : Convert.ToInt16(drpConName.SelectedValue);
            int Res_Skl_Id = drpSkillName.SelectedValue == "NA" ? 0 : Convert.ToInt16(drpSkillName.SelectedValue);
            int Res_Insert_Usr_Id = drpInsertUserID.SelectedValue == "NA" ? 0 : Convert.ToInt16(drpInsertUserID.SelectedValue);
            int Res_Update_Usr_Id = drpUpdateuserId.SelectedValue == "NA" ? 0 : Convert.ToInt16(drpUpdateuserId.SelectedValue);
            int Res_Yr_Id = DrpResYrId.SelectedValue == "NA" ? 0 : Convert.ToInt16(DrpResYrId.SelectedValue);
            RM_DataHelper.UpdateRes(Res_Id, Res_Name, Res_Hrs_Per_Week, Res_Comments, Res_Profile_Link, Res_Role, Res_Active, Res_Del, Res_Glb_Com_Id, Res_Ind_Com_Id, Res_Con_Id, Res_Skl_Id, Res_Insert_Usr_Id, Res_Update_Usr_Id, Res_Yr_Id, Flag);
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
                drpgroupName.SelectedValue = dt.Rows[0]["Resource Global Company ID"].ToString() == "0" ? "NA" : dt.Rows[0]["Resource Global Company ID"].ToString();
                drpIncomanpyName.SelectedValue = dt.Rows[0]["Resource India Company ID"].ToString() == "0" ? "NA" : dt.Rows[0]["Resource India Company ID"].ToString();
                drpConName.SelectedValue = dt.Rows[0]["Resource Country ID"].ToString() == "0" ? "NA" : dt.Rows[0]["Resource Country ID"].ToString();
                drpSkillName.SelectedValue = dt.Rows[0]["Resource Skill ID"].ToString() == "0" ? "NA" : dt.Rows[0]["Resource Skill ID"].ToString();
                drpInsertUserID.SelectedValue = dt.Rows[0]["Resource Insert User ID"].ToString() == "0" ? "NA" : dt.Rows[0]["Resource Insert User ID"].ToString();
                drpUpdateuserId.SelectedValue = dt.Rows[0]["Resource Update User ID"].ToString() == "0" ? "NA" : dt.Rows[0]["Resource Update User ID"].ToString();
                DrpResYrId.SelectedValue = dt.Rows[0]["Resource Yr ID"].ToString() == "0" ? "NA" : dt.Rows[0]["Resource Yr ID"].ToString();
            }
            else
            {
                txtResourceId.Text = "";
                txtResName.Text = "";
                txtHrPrWk.Text = "";
                txtResComment.Text = "";
                txtProfileLink.Text = "";
                txtResRoll.Text = "";

                //BindCheckboxes
                chkResActive.Checked = true;
                chkResDel.Checked = false;

                //Binding Dropdowsns
                drpgroupName.SelectedValue ="NA";
                drpIncomanpyName.SelectedValue = "NA";
                drpConName.SelectedValue = "NA";
                drpSkillName.SelectedValue = "NA";
                drpInsertUserID.SelectedValue = "NA";
                drpUpdateuserId.SelectedValue = "NA";
                DrpResYrId.SelectedValue = "NA";
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
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
            int Res_Glb_Com_Id = drpgroupName.SelectedValue == "NA" ? 0 : Convert.ToInt16(drpgroupName.SelectedValue);
            int Res_Ind_Com_Id = drpIncomanpyName.SelectedValue == "NA" ? 0 : Convert.ToInt16(drpIncomanpyName.SelectedValue); ;
            int Res_Con_Id = drpConName.SelectedValue == "NA" ? 0 : Convert.ToInt16(drpConName.SelectedValue);
            int Res_Skl_Id = drpSkillName.SelectedValue == "NA" ? 0 : Convert.ToInt16(drpSkillName.SelectedValue);
            int Res_Insert_Usr_Id = drpInsertUserID.SelectedValue == "NA" ? 0 : Convert.ToInt16(drpInsertUserID.SelectedValue);
            int Res_Update_Usr_Id = drpUpdateuserId.SelectedValue == "NA" ? 0 : Convert.ToInt16(drpUpdateuserId.SelectedValue);
            int Res_Yr_Id = DrpResYrId.SelectedValue == "NA" ? 0 : Convert.ToInt16(DrpResYrId.SelectedValue);
            RM_DataHelper.AddRes(Res_Name, Res_Hrs_Per_Week, Res_Comments, Res_Profile_Link, Res_Role, Res_Active, Res_Del, Res_Glb_Com_Id, Res_Ind_Com_Id, Res_Con_Id, Res_Skl_Id, Res_Insert_Usr_Id, Res_Update_Usr_Id, Res_Yr_Id, Flag);
        }


    }
}