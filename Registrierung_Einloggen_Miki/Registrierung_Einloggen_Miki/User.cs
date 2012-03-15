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
        /// 
        /// </summary>
        /// <param name="eingabePassword"></param>
        public void minZeichenlaengePassword(String eingabePassword)
        {
            int iLenght;
            iLenght = eingabePassword.Length;
            if (iLenght < 6)
            {
                MessageBox.Show("Ihre Eingabe muss mindestens 6 Zeichen besitzen!");
            }
            else
            {
                this.setPassword(eingabePassword);
            }

        }

        public void maxZeichenlaengeUsername(String eingabeUsername)
        {
            int iLenght;
            iLenght = eingabeUsername.Length;
            if (iLenght > 15)
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

        private void getUsername(string p)
        {
            this.sPassword = p;
        }

        private void getPassword(string p)
        {
            this.sPassword = p;
        }
    }

}
