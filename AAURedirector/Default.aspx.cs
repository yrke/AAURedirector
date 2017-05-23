using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AAURedirector
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"] ?? ""; // ?? "": return empty string if null value


            if (id.StartsWith("IR", StringComparison.CurrentCultureIgnoreCase))
            {
                //Is incident
                Response.Redirect("https://service.aau.dk/Incident/Edit/" + id);
            }
            else if (id.StartsWith("SR", StringComparison.CurrentCultureIgnoreCase))
            {
                Response.Redirect("https://service.aau.dk/ServiceRequest/Edit/" + id);
            }
            else if (id.StartsWith("PR", StringComparison.CurrentCultureIgnoreCase))
            {
                Response.Redirect("https://service.aau.dk/Problem/Edit/" + id);
            }
            else if (id.StartsWith("C-", StringComparison.CurrentCultureIgnoreCase))
            {
                Response.Redirect("https://srv-webmgmt01.srv.aau.dk/IDtoSystem.aspx?id="+id);
            }
            else if (id.StartsWith("EC-", StringComparison.CurrentCultureIgnoreCase))
            {
                Response.Redirect("https://srv-webmgmt01.srv.aau.dk/IDtoSystem.aspx?id=" + id);
            }
            else if (id.StartsWith("SC-", StringComparison.CurrentCultureIgnoreCase))
            {
                Response.Redirect("https://srv-webmgmt01.srv.aau.dk/IDtoSystem.aspx?id=" + id);
            }

            else
            {
                result.Text = "<h1>Type not found</h1>";
            }
        }
    }
}