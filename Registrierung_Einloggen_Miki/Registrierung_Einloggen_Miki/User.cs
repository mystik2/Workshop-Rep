using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;



namespace Registrierung_Einloggen_Miki
{
    class User
    {
        String sUsername;
        String sPassword;
        
        /// <summary>
        /// Ueberpruefung des Passworts auf mindestens 6 Zeichen.
        /// </summary>
        /// <param name="eingabePassword"></param>
        public void minZeichenlaengePassword(String eingabePassword)
        {
            int iLenghtPassword;
            iLenghtPassword = eingabePassword.Length;
            if (iLenghtPassword < 6)
            {
                MessageBox.Show("Ihre Eingabe muss mindestens 6 Zeichen besitzen!");
            }
            else
            {
                this.setPassword(eingabePassword);
            }

        }
        /// <summary>
        /// Ueberpruefung des Usernames auf maximal 15 Zeichen.
        /// </summary>
        /// <param name="eingabeUsername"></param>
        public void maxZeichenlaengeUsername(String eingabeUsername)
        {
            int iLenghtUsername;
            iLenghtUsername = eingabeUsername.Length;
            if (iLenghtUsername > 15)
            {
                MessageBox.Show("Ihre Eingabe darf maximal 15 Zeichen besitzen!");
            }
            else
            {
                this.setUsername(eingabeUsername);
            }

        }
       private void setUsername(string p)
        {
            this.sUsername = p;
        }

        private void setPassword(string p)
        {
            this.sPassword = p;
        }

        public String getUsername()
        {
            return this.sUsername;
        }

        public String getPassword() 
        {
            return this.sPassword;
        }
        
    }

}
