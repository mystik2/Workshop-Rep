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
        /// Ueberpruefung des Usernames auf maximal 15 Zeichen.
        /// </summary>
        /// <param name="eingabeUsername"></param>
        public void maxZeichenlaengeUsername(String eingabeUsername)
        {
            int iLenghtUsername;
            iLenghtUsername = eingabeUsername.Length;
            if (iLenghtUsername > 15)
            {
                MessageBox.Show("Ihr Username darf maximal 15 Zeichen besitzen!", "Fehler");
            }
            else
            {
                setUsername(eingabeUsername);
            }

        }

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
                MessageBox.Show("Ihr Passwort muss mindestens 6 Zeichen besitzen!", "Fehler");
            }
            else
            {
                setPassword(eingabePassword);
            }

        }
       public void setUsername(string p)
        {
            this.sUsername = p;
        }

        public void setPassword(string p)
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
