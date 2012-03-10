using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchwarzesBrett
{
    public partial class RegisterKunde : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btButton_Click(object sender, EventArgs e)
        {
            mystik.Default.kunde.writeToDB(this.txtName.Text, this.txtVorname.Text);
        }
    }
}