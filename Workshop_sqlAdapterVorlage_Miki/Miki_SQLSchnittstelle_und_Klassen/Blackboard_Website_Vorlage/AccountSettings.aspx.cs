using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using myStik.Default;

namespace Blackboard_Website_Vorlage
{
    public partial class AccountSettings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btbSettingsNamenAendern_Click(object sender, EventArgs e)
        {
            int User_ID = Convert.ToInt32(txtSettingsNamenAendernUserID.Text);
            User Benutzer1 = new User(User_ID);

            Benutzer1.changeNameInDB(txtSettingsNachname.Text, txtSettingsVorname.Text, User_ID);
        }

        protected void btbSettingsPasswortAendern_Click(object sender, EventArgs e)
        {
            int User_ID = Convert.ToInt32(txtSettingsPWaendernUserID.Text);
            User Benutzer2 = new User(User_ID);

            Benutzer2.changePWInDB(txtSettingsPasswortNeu.Text, txtSettingsPasswortNeuWdh.Text, txtSettingsPasswortalt.Text, User_ID);
        }

        
    }
}