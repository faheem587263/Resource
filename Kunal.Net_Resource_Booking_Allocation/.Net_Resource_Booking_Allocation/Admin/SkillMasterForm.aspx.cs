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
    public partial class SkillMasterFrom : System.Web.UI.Page
    {
        SkillMaster_DataHelper SM_DataHelpers = new SkillMaster_DataHelper();
        string Flag;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Binddropdowns();
                chkSkillActive.Checked = true;
            }
        }

        private void Binddropdowns()
        {
            string Load = "SkillMaster";
            DataSet ds = SM_DataHelpers.GetDropdowns(Load);

            if (ds.Tables[0].Rows.Count > 0)
            {
                drpInsertUserID.DataSource = ds.Tables[0];
                drpInsertUserID.DataValueField = "Skill Insert User ID";
                drpInsertUserID.DataTextField = "Skill Insert User Name";
                drpInsertUserID.DataBind();
            }
            drpInsertUserID.Items.Insert(0, new ListItem("Select", "NA"));

            if (ds.Tables[1].Rows.Count > 0)
            {
                drpUpdateuserId.DataSource = ds.Tables[1];
                drpUpdateuserId.DataValueField = "Skill Update User ID";
                drpUpdateuserId.DataTextField = "Skill Update User Name";
                drpUpdateuserId.DataBind();
            }
            drpUpdateuserId.Items.Insert(0, new ListItem("Select", "NA"));

            if (ds.Tables[2].Rows.Count > 0)
            {
                DrpSkillYrId.DataSource = ds.Tables[2];
                DrpSkillYrId.DataValueField = "Year ID";
                DrpSkillYrId.DataTextField = "Year";
                DrpSkillYrId.DataBind();
            }
            DrpSkillYrId.Items.Insert(0, new ListItem("Select", "NA"));

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Flag = "Add";

            string Skl_Name = txtSkillName.Text;

            int Skl_Insert_Usr_Id = drpInsertUserID.SelectedValue == "NA" ? 0 : Convert.ToInt16(drpInsertUserID.SelectedValue); //check 
            int Skl_Update_Usr_Id = drpUpdateuserId.SelectedValue == "NA" ? 0 : Convert.ToInt16(drpUpdateuserId.SelectedValue); //check 
            int Skl_Yr_Id = DrpSkillYrId.SelectedValue == "NA" ? 0 : Convert.ToInt16(DrpSkillYrId.SelectedValue);

            int Skl_Active = chkSkillActive.Checked == true ? 1 : 0;
            int Skl_Del = chkSkillDel.Checked == true ? 1 : 0;


            SM_DataHelpers.AddSkill(Flag, Skl_Name, Skl_Insert_Usr_Id, Skl_Update_Usr_Id, Skl_Yr_Id, Skl_Active, Skl_Del);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Flag = "Update";
            int Skl_Id = txtSkillId.Text == "" ? 0 : Convert.ToInt16(txtSkillId.Text);
            string Skl_Name = txtSkillName.Text;

            int Skl_Update_Usr_Id = drpUpdateuserId.SelectedValue == "NA" ? 0 : Convert.ToInt16(drpUpdateuserId.SelectedValue); //check 
            int Skl_Yr_Id = DrpSkillYrId.SelectedValue == "NA" ? 0 : Convert.ToInt16(DrpSkillYrId.SelectedValue);

            int Skl_Active = chkSkillActive.Checked == true ? 1 : 0;
            int Skl_Del = chkSkillDel.Checked == true ? 1 : 0;


            SM_DataHelpers.UpdateSkill(Flag, Skl_Id, Skl_Name, Skl_Update_Usr_Id, Skl_Yr_Id, Skl_Active, Skl_Del);
        }

        protected void dtynEdit_Click(object sender, EventArgs e)
        {
            int Skl_Id = txtSkillId.Text == "" ? 0 : Convert.ToInt16(txtSkillId.Text);
            Flag = "Edit";
            DataTable dt = SM_DataHelpers.EditSkill(Skl_Id, Flag);
            BindControls(dt);
        }

        private void BindControls(DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                txtSkillId.Text = dt.Rows[0]["Skill ID"].ToString(); ;
                txtSkillName.Text = dt.Rows[0]["Skill Name"].ToString(); ;

                drpUpdateuserId.SelectedValue = dt.Rows[0]["Skill Update User ID"].ToString() == "" ? "NA" : dt.Rows[0]["Skill Update User ID"].ToString();
                drpInsertUserID.SelectedValue = dt.Rows[0]["Skill Insert User ID"].ToString() == "" ? "NA" : dt.Rows[0]["Skill Insert User ID"].ToString();
                DrpSkillYrId.SelectedValue = dt.Rows[0]["Year ID"].ToString() == "" ? "NA" : dt.Rows[0]["Year ID"].ToString();


                chkSkillActive.Checked = dt.Rows[0]["Skill Active"].ToString() == "1" ? false : true;
                chkSkillDel.Checked = dt.Rows[0]["Skill Delete"].ToString() == "1" ? false : true;
            }
            else
            {
                txtSkillId.Text ="" ;
                txtSkillName.Text = "" ;

                drpUpdateuserId.SelectedIndex = 1;
                drpInsertUserID.SelectedIndex = 1;
                DrpSkillYrId.SelectedIndex = 1;


                chkSkillActive.Checked = true;
                chkSkillDel.Checked = false ;
            }

        }
    }
}