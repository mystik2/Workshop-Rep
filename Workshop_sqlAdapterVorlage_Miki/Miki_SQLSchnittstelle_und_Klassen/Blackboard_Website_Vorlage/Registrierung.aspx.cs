using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using myStik.Default;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace Blackboard_Website_Vorlage
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btbRegistrieren_Click(object sender, EventArgs e)
        {
            if (txtRegistPasswort.Text == txtRegistWdhPasswort.Text)
            {
                myStik.Default.User.writeToDB(txtRegistNachname.Text, txtRegistVorname.Text, txtRegistGebdatum.Text, txtRegistUsername.Text, txtRegistPasswort.Text, txtRegistEmail.Text);
            }
            else
            {
                MessageBox.Show("Passwortwiederholung war fehlerhaft!"); 
            }

            txtRegistNachname.Text = Textentfernen.TextWegInTxt(txtRegistNachname.Text);
            txtRegistVorname.Text = Textentfernen.TextWegInTxt(txtRegistVorname.Text);
            txtRegistGebdatum.Text = Textentfernen.TextWegInTxt(txtRegistGebdatum.Text);
            txtRegistUsername.Text = Textentfernen.TextWegInTxt(txtRegistUsername.Text);
            txtRegistPasswort.Text = Textentfernen.TextWegInTxt(txtRegistPasswort.Text);
            txtRegistWdhPasswort.Text = Textentfernen.TextWegInTxt(txtRegistWdhPasswort.Text);
            txtRegistEmail.Text = Textentfernen.TextWegInTxt(txtRegistEmail.Text);

            //RS MANU: wie "aktivierungsemail" versenden-> eigene Klasse!!!, UND 
            //wie einrichten, dass wenn man auf den Link der Registrierungsmail klickt der User freigeschaltet wird, z.B. durch Eintrag in DB
            //wg. Geb-Datum eintragen-> vereinheitlichen

        }
    }
}