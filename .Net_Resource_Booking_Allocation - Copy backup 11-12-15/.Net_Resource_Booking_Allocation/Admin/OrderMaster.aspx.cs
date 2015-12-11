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
        OrderMaster_DataHelper OM_DataHelper = new OrderMaster_DataHelper();
        string Flag;

        public void Page_Load(object sender, EventArgs e)
        {
          
          
            if (!IsPostBack)
            {
                // written by faheem 
                OrderMaster_DataHelper x = new OrderMaster_DataHelper();
                rptrDetails.DataSource = x.EditProject();
                rptrDetails.DataBind();
                 //end


             

             

             
                string Load = "OrderMaster";
                DataSet ds = OM_DataHelper.BindDropdowns(Load);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    ddlOnShoreEMSDM.DataSource = ds.Tables[0];
                    ddlOnShoreEMSDM.DataValueField = "Prj_OnShore_EM_SDM ID";
                    ddlOnShoreEMSDM.DataTextField = "Prj_OnShore_EM_SDM Name";
                    ddlOnShoreEMSDM.DataBind();
                }

                ddlOnShoreEMSDM.Items.Insert(0, new ListItem("Select", "NA"));

                if (ds.Tables[1].Rows.Count > 0)
                {
                    ddlOffShoreEM.DataSource = ds.Tables[1];
                    ddlOffShoreEM.DataValueField = "Prj_OffShore_EM_SDM ID";
                    ddlOffShoreEM.DataTextField = "Prj_OffShore_EM_SDM Name";
                    ddlOffShoreEM.DataBind();
                }

                ddlOffShoreEM.Items.Insert(0, new ListItem("Select", "NA"));

                if (ds.Tables[2].Rows.Count > 0)
                {
                    ddlStatus.DataSource = ds.Tables[2];
                    ddlStatus.DataValueField = "Status ID";
                    ddlStatus.DataTextField = "Status Name";
                    ddlStatus.DataBind();
                }

                ddlStatus.Items.Insert(0, new ListItem("Select", "NA"));
            }
        }

        protected void dtynAdd_Click(object sender, EventArgs e)
        {
            Flag = "Add";
            string Prj_Client_Nam = txtClientDetails.Text;
            string Prj_Name = txtProjectName.Text;
            string Prj_Details = txtProjectOverView.Text;
            string Prj_OnShore_EM_SDM = ddlOnShoreEMSDM.SelectedValue == "NA" ? "0" : (ddlOnShoreEMSDM.SelectedValue).ToString();
            string Prj_OffShore_EM_SDM = ddlOffShoreEM.SelectedValue == "NA" ? "0" : (ddlOffShoreEM.SelectedValue).ToString();
            string Prj_Status = ddlStatus.SelectedValue == "NA" ? "0" : (ddlStatus.SelectedValue).ToString();
            int Prj_Revenue = txtRevenue.Text == "" ? 0 : Convert.ToInt16(txtRevenue.Text);
            decimal Prj_Contribution_Margin = txtContributionMargin.Text == "" ? 0 : decimal.Parse(txtContributionMargin.Text, CultureInfo.InvariantCulture);
            decimal Prj_Expected_Rightshore_penetration = txtpenetration.Text == "" ? 0 : decimal.Parse(txtpenetration.Text, CultureInfo.InvariantCulture);
            DateTime Prj_Exp_StartDate = IDdatepicker1.Value == "" ? DateTime.MaxValue : Convert.ToDateTime(IDdatepicker1.Value); //check
            DateTime Prj_Exp_EndDate = IDdatepicker2.Value == "" ? DateTime.MaxValue : Convert.ToDateTime(IDdatepicker2.Value);
            string Prj_Effort = txtEfforts.Text;
            string Prj_FTE = txtFTE.Text;
            string Prj_Comments = txtComment.Text;
            int Prj_Active = chkOrdActive.Checked == true ? 1 : 0;
            int Prj_Del = chkOrdDel.Checked == true ? 1 : 0;

            OM_DataHelper.AddProject(Flag, Prj_Client_Nam, Prj_Name, Prj_Details, Prj_OnShore_EM_SDM, Prj_OffShore_EM_SDM, Prj_Status, Prj_Exp_StartDate, Prj_Exp_EndDate, Prj_Effort, Prj_FTE, Prj_Revenue, Prj_Contribution_Margin, Prj_Expected_Rightshore_penetration, Prj_Comments, Prj_Active, Prj_Del);
        }

        protected void dtynEdit_Click(object sender, EventArgs e)
        {
            //faheem
            txtProjID.Text = Session["prjId"].ToString();
            //end
            int Prj_Id = txtProjID.Text == "" ? 0 : Convert.ToInt16(txtProjID.Text);
            Flag = "Edit";
            DataTable dt = OM_DataHelper.EditProject(Prj_Id, Flag);
            BindControls(dt);
        }

        protected void dtynSubmit_Click(object sender, EventArgs e)
        {
            Flag = "Update";
            int Prj_Id = txtProjID.Text == "" ? 0 : Convert.ToInt16(txtProjID.Text);
            string Prj_Client_Nam = txtClientDetails.Text;
            string Prj_Name = txtProjectName.Text;
            string Prj_Details = txtProjectOverView.Text;
            string Prj_OnShore_EM_SDM = ddlOnShoreEMSDM.SelectedValue == "NA" ? "0" : (ddlOnShoreEMSDM.SelectedValue).ToString();
            string Prj_OffShore_EM_SDM = ddlOffShoreEM.SelectedValue == "NA" ? "0" : (ddlOffShoreEM.SelectedValue).ToString();
            string Prj_Status = ddlStatus.SelectedValue == "NA" ? "0" : (ddlStatus.SelectedValue).ToString();
            int Prj_Revenue = txtRevenue.Text == "" ? 0 : Convert.ToInt16(txtRevenue.Text);
            decimal Prj_Contribution_Margin = txtContributionMargin.Text == "" ? 0 : decimal.Parse(txtContributionMargin.Text, CultureInfo.InvariantCulture);
            decimal Prj_Expected_Rightshore_penetration = txtpenetration.Text == "" ? 0 : decimal.Parse(txtpenetration.Text, CultureInfo.InvariantCulture);
            DateTime Prj_Exp_StartDate = IDdatepicker1.Value == "" ? DateTime.MaxValue : Convert.ToDateTime(IDdatepicker1.Value); //check
            DateTime Prj_Exp_EndDate = IDdatepicker2.Value == "" ? DateTime.MaxValue : Convert.ToDateTime(IDdatepicker2.Value);
            string Prj_Effort = txtEfforts.Text;
            string Prj_FTE = txtFTE.Text;
            string Prj_Comments = txtComment.Text;
            int Prj_Active = chkOrdActive.Checked == true ? 1 : 0;
            int Prj_Del = chkOrdDel.Checked == true ? 1 : 0;

            OM_DataHelper.UpdateProject(Flag, Prj_Id, Prj_Client_Nam, Prj_Name, Prj_Details, Prj_OnShore_EM_SDM, Prj_OffShore_EM_SDM, Prj_Status, Prj_Exp_StartDate, Prj_Exp_EndDate, Prj_Effort, Prj_FTE, Prj_Revenue, Prj_Contribution_Margin, Prj_Expected_Rightshore_penetration, Prj_Comments, Prj_Active, Prj_Del);
        }

        protected void BindControls(DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                //Binding Textboxes
                txtProjID.Text = dt.Rows[0]["Project ID"].ToString();
                txtClientDetails.Text = dt.Rows[0]["Client Details"].ToString();
                txtProjectName.Text = dt.Rows[0]["Name of Project"].ToString();
                txtProjectOverView.Text = dt.Rows[0]["Project OverView"].ToString();

                IDdatepicker1.Value = dt.Rows[0]["Expected Start Date"].ToString() == (DateTime.MaxValue).ToString() ? "" : dt.Rows[0]["Expected Start Date"].ToString();
                IDdatepicker2.Value = dt.Rows[0]["Expected End Date"].ToString() == (DateTime.MaxValue).ToString() ? "" : dt.Rows[0]["Expected End Date"].ToString();
                txtEfforts.Text = dt.Rows[0]["Efforts (in Hrs)"].ToString();
                txtFTE.Text = dt.Rows[0]["FTE"].ToString();
                txtRevenue.Text = dt.Rows[0]["Revenue"].ToString();
                txtComment.Text = dt.Rows[0]["Comment"].ToString();
                txtContributionMargin.Text = dt.Rows[0]["Contribution Margin (%)"].ToString();
                txtpenetration.Text = dt.Rows[0]["Expected Rightshore penetration (%)"].ToString();

                //bind dropdows 
                ddlOnShoreEMSDM.SelectedValue = dt.Rows[0]["Prj_OnShore_EM_SDM ID"].ToString() == "0" ? "NA" : dt.Rows[0]["Prj_OnShore_EM_SDM ID"].ToString();
                ddlOffShoreEM.SelectedValue = dt.Rows[0]["Prj_OffShore_EM_SDM ID"].ToString() == "0" ? "NA" : dt.Rows[0]["Prj_OffShore_EM_SDM ID"].ToString();
                ddlStatus.SelectedValue = dt.Rows[0]["Status ID"].ToString() == "0" ? "NA" : dt.Rows[0]["Status ID"].ToString();

                //bind checkbox
                chkOrdActive.Checked = dt.Rows[0]["Project Active"].ToString() == "1" ? true : false;
                chkOrdDel.Checked = dt.Rows[0]["Project Delete"].ToString() == "1" ? true : false;

            }
            else
            {
                txtProjID.Text = "";
                txtClientDetails.Text = "";
                txtProjectName.Text = "";
                txtProjectOverView.Text = "";
                ddlOnShoreEMSDM.SelectedIndex = 0;
                ddlOffShoreEM.SelectedIndex = 0;
                ddlStatus.SelectedIndex = 0;
                IDdatepicker1.Value = "";
                IDdatepicker2.Value = "";
                txtEfforts.Text = "";
                txtFTE.Text = "";
                txtComment.Text = "";
                txtContributionMargin.Text = "";
                txtpenetration.Text = "";
                txtRevenue.Text = "";
                chkOrdActive.Checked = true;
                chkOrdActive.Checked = false;
            }
        }
        //code written by faheem ahmad
        protected void rptrDetails_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
        
          if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem) {

           
               string s= ((LinkButton)e.Item.FindControl("lnkbtn")).Text ;
               Session["prjId"] = s;
               if (s != "" || s!=null)
               {
                   txtProjID.Text = Session["prjId"].ToString();

                   int Prj_Id = txtProjID.Text == "" ? 0 : Convert.ToInt16(txtProjID.Text);
                   Flag = "Edit";
                   DataTable dt = OM_DataHelper.EditProject(Prj_Id, Flag);
                   BindControls(dt);
               }
          }
       }

        protected void btngto_Click(object sender, EventArgs e)
        {
            if (txtProjID.Text != "")
            {
                if (Session["prjId"].ToString() != null)
                {
                    string p = Session["prjId"].ToString();

                    Response.Redirect("/admin/ResourceAllocations.aspx");
                }
                else
                {
                    Response.Write("Session Variable value blank");

                }
            }
            else
            {
                string script = "alert('Session variable is blank');";
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script, true);
            }

        }    
        }
    }
