using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Net_Resource_Booking_Allocation.Admin.DL;
using System.Data;
using System.Globalization;

namespace Net_Resource_Booking_Allocation
{
    public partial class OrderMaster : System.Web.UI.Page
    {
        DataHelpers DataHelpers = new DataHelpers();
        string Flag;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void dtynAdd_Click(object sender, EventArgs e)
        {
            Flag = "Add";
            string Prj_Client_Nam = txtClientDetails.Text;
            string Prj_Name = txtProjectName.Text;
            string Prj_Details = txtProjectOverView.Text;
            string Prj_OnShore_EM_SDM = ddlOnShoreEMSDM.SelectedValue;
            string Prj_OffShore_EM_SDM = ddlOffShoreEM.SelectedValue;
            int Prj_Revenue =txtRevenue.Text=="" ? 0: Convert.ToInt16(txtRevenue.Text);
            decimal Prj_Contribution_Margin =txtContributionMargin.Text=="" ? 0: decimal.Parse(txtContributionMargin.Text, CultureInfo.InvariantCulture);
            decimal Prj_Expected_Rightshore_penetration =txtpenetration.Text=="" ? 0: decimal.Parse(txtpenetration.Text, CultureInfo.InvariantCulture);
            DateTime Prj_Exp_StartDate = IDdatepicker1.Value == "" ? DateTime.MaxValue : Convert.ToDateTime(IDdatepicker1.Value); //check
            DateTime Prj_Exp_EndDate = IDdatepicker2.Value == "" ? DateTime.MaxValue : Convert.ToDateTime(IDdatepicker2.Value);
            string Prj_Effort = txtEfforts.Text;
            string Prj_FTE = txtFTE.Text;
            string Prj_Comments = txtComment.Text;

            DataHelpers.AddProject(Flag, Prj_Client_Nam, Prj_Name, Prj_Details, Prj_OnShore_EM_SDM, Prj_OffShore_EM_SDM, Prj_Exp_StartDate, Prj_Exp_EndDate, Prj_Effort, Prj_FTE, Prj_Revenue, Prj_Contribution_Margin, Prj_Expected_Rightshore_penetration, Prj_Comments);
        }

        protected void dtynEdit_Click(object sender, EventArgs e)
        {
            int Prj_Id = txtProjID.Text == "" ? 0 : Convert.ToInt16(txtProjID.Text);
            Flag = "Edit";
            DataTable dt = DataHelpers.EditProject(Prj_Id, Flag);
            BindControls(dt);
        }

        protected void dtynSubmit_Click(object sender, EventArgs e)
        {
            Flag = "Update";
            int Prj_Id = txtProjID.Text == "" ? 0 : Convert.ToInt16(txtProjID.Text);
            string Prj_Client_Nam = txtClientDetails.Text;
            string Prj_Name = txtProjectName.Text;
            string Prj_Details = txtProjectOverView.Text;
            string Prj_OnShore_EM_SDM = ddlOnShoreEMSDM.SelectedValue;
            string Prj_OffShore_EM_SDM = ddlOffShoreEM.SelectedValue;
            int Prj_Revenue = txtRevenue.Text == "" ? 0 : Convert.ToInt16(txtRevenue.Text); ;
            decimal Prj_Contribution_Margin = txtContributionMargin.Text == "" ? 0 : decimal.Parse(txtContributionMargin.Text, CultureInfo.InvariantCulture);
            decimal Prj_Expected_Rightshore_penetration = txtpenetration.Text == "" ? 0 : decimal.Parse(txtpenetration.Text, CultureInfo.InvariantCulture);
            DateTime Prj_Exp_StartDate = IDdatepicker1.Value == "" ? DateTime.MaxValue : Convert.ToDateTime(IDdatepicker1.Value); //check
            DateTime Prj_Exp_EndDate = IDdatepicker2.Value == "" ? DateTime.MaxValue : Convert.ToDateTime(IDdatepicker2.Value);
            string Prj_Effort = txtEfforts.Text;
            string Prj_FTE = txtFTE.Text;
            string Prj_Comments = txtComment.Text;

            DataHelpers.UpdateProject(Flag, Prj_Id, Prj_Client_Nam, Prj_Name, Prj_Details, Prj_OnShore_EM_SDM, Prj_OffShore_EM_SDM, Prj_Exp_StartDate, Prj_Exp_EndDate, Prj_Effort, Prj_FTE, Prj_Revenue, Prj_Contribution_Margin, Prj_Expected_Rightshore_penetration, Prj_Comments);
        }

        protected void BindControls(DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                //Binding Textboxes
                txtProjID.Text = dt.Rows[0]["Project Id"].ToString();
                txtClientDetails.Text = dt.Rows[0]["Client Details"].ToString();
                txtProjectName.Text = dt.Rows[0]["Name of Project"].ToString();
                txtProjectOverView.Text = dt.Rows[0]["Project OverView"].ToString();

                IDdatepicker1.Value = dt.Rows[0]["Expected Start Date"].ToString();
                IDdatepicker2.Value = dt.Rows[0]["Expected End Date"].ToString();
                txtEfforts.Text = dt.Rows[0]["Efforts (in Hrs)"].ToString();
                txtFTE.Text = dt.Rows[0]["FTE"].ToString();
                txtComment.Text = dt.Rows[0]["Comment"].ToString();
                txtContributionMargin.Text = dt.Rows[0]["Contribution Margin (%)"].ToString();
                txtpenetration.Text = dt.Rows[0]["Expected Rightshore penetration (%)"].ToString();

                //bind dropdows 
                ddlOnShoreEMSDM.DataSource = dt;
                ddlOnShoreEMSDM.DataValueField = "OnShore EM/SDM";
                ddlOnShoreEMSDM.DataBind();

                ddlOffShoreEM.DataSource = dt;
                ddlOffShoreEM.DataValueField = "OffShore EM/SDM";
                ddlOffShoreEM.DataBind();
            }
            else 
            {
                txtProjID.Text ="";
                txtClientDetails.Text ="";
                txtProjectName.Text ="";
                txtProjectOverView.Text ="";
                ddlOnShoreEMSDM.SelectedValue = "";
                ddlOffShoreEM.SelectedValue = "";
                IDdatepicker1.Value = "";
                IDdatepicker2.Value = "";
                txtEfforts.Text = "";
                txtFTE.Text = "";
                txtComment.Text = "";
                txtContributionMargin.Text ="";
                txtpenetration.Text = "";
            }
        }
    }
}