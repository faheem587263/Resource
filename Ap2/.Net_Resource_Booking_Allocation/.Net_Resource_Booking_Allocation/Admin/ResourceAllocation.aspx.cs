using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Services;
using System.Data;
using Net_Resource_Booking_Allocation.Admin.DL;
using System.Web.Services;

namespace Net_Resource_Booking_Allocation.Admin
{
    public partial class ResourceAllocation : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod(), ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = false)]
        //[System.Web.Services.WebMethod(BufferResponse = false)]
        //[System.Web.Services.WebMethod()]
        //[ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet=false)] 
        //[WebMethod()]
        public static DataTable getresourcedata()
        {
            //implementation code
            DataHelpers obj = new DataHelpers();
            return obj.Get_Resource_Data();
            //return 1;
        }
    }
}