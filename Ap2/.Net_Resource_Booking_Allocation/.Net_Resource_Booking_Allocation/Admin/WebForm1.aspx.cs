using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;

namespace Net_Resource_Booking_Allocation.Admin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod()]
        public static int getresourcedata()
        {
            //implementation code

            //return obj.Get_Resource_Data();
            return 1;
        }
    }
}