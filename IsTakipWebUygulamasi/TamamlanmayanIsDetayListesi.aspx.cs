using IsTakip.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IsTakipWebUygulamasi
{
    public partial class TamamlanmayanIsDetayListesi : System.Web.UI.Page
    {
        PersonelServiceRepository service = new PersonelServiceRepository();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            Repeater1.DataSource = service.TamamlanmayanIsler();
            Repeater1.DataBind();
        }
    }
}