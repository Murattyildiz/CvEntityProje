using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class İletisim : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            DBCVENTITYEntities1 db=new DBCVENTITYEntities1();
            var mesajlar=db.TBLILETISIM.ToList();
            Repeater1.DataSource = mesajlar;
            Repeater1.DataBind();

        }
    }
}