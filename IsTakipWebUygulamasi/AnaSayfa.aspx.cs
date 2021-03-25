using IsTakip.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IsTakipWebUygulamasi
{
    public partial class Default : System.Web.UI.Page
    {
        PersonelServiceRepository service = new PersonelServiceRepository();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            lblToplamIsSayisi.Text = service.ToplamIsSayisi().ToString();
            lblTamamlanan.Text = service.TamamlananIsSayisi().ToString();
            lblDevamEden.Text = service.DevamEdenIsSayisi().ToString();
            lblCalismaGunSayisi.Text = service.ToplamCalismaSaati().ToString();

            Repeater1.DataSource = service.SonIsler();
            Repeater1.DataBind();
        }
    }
}