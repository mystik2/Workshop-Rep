using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using myStik.Default;
using System.Windows.Forms;



namespace myStik.Default
{
   public class User
    {
        int ID;
        String sUserNachname;
        String sUserVorname;
        String sUserEmail;
        String sUserUsername;
        String sUserPassword;
        String sUserBirthday;
      
        //SQL Adapter
        MySQLAdapter db = new MySQLAdapter();

       /// <summary>
       /// Ein User wird erstellt mit einem Nachnamen und Vornamen aus der Datenbank
       /// </summary>
       /// <param name="ID">Die ID des Users in der Datenbank muss uebergeben werden</param>
        public User(int ID)
        {
            DataTable DT = this.db.Query("SELECT * FROM user WHERE ID = " + ID);

            this.setNachname(DT.Rows[0]["nachname"].ToString());
            this.setVorname(DT.Rows[0]["vorname"].ToString());
            this.setEmail(DT.Rows[0]["email"].ToString());
            this.setUsername(DT.Rows[0]["username"].ToString());
            this.setPassword(DT.Rows[0]["password"].ToString());
            this.setBirthday(DT.Rows[0]["geburtsdatum"].ToString());//noch in einheitliches Datum umwandeln, evtl. über einheitliche Eingabe
            //sBirthDate = DateTime.Now.ToString("yyyy-MM-dd");
        }
        private void setVorname(string p)
        {
            this.sUserVorname = p;
        }
        private void setNachname(String p)
        {
            this.sUserNachname = p;
        }
        private void setEmail(String p)
        {
            this.sUserEmail = p;
        }
        private void setUsername(String p)
        {
            this.sUserUsername = p;
        }
        private void setPassword(String p)
        {
            this.sUserPassword = p;
        }
        private void setBirthday(String p)
        {
            this.sUserBirthday = p;
        }
        public String getNachname()
        {
            return sUserNachname;
        }
        public String getVorname()
        {
            return sUserVorname;
        }
        public String getEmail()
        {
            return sUserEmail;
        }
        public String getUsername()
        {
            return sUserUsername;
        }
        public String getPassword()
        {
            return sUserPassword;
        }
        public String getBirthday()
        {
            return sUserBirthday;
        }

    /// <summary>
    /// Daten werden in die Datenbank geschrieben.
    /// </summary>
    /// <param name="Nachname"></param>
    /// <param name="Vorname"></param>
    /// <param name="Geburtsdatum"></param>
    /// <param name="Username"></param>
    /// <param name="Password"></param>
    /// <param name="Email"></param>
        public static void writeToDB(String Nachname, String Vorname, String Geburtsdatum, String Username, String Password, String Email)
        {
            MySQLAdapter db = new MySQLAdapter();

            db.Query("INSERT INTO user(nachname, vorname, geburtsdatum, username, password, email) VALUES('" + Nachname + "', '" + Vorname + "', '" + Geburtsdatum + "', '" + Username +  "', '" + Password + "', '" + Email + "')");

        }
       /// <summary>
        /// Anhand von UserID wird Nachname und Vorname geaendert.
       /// </summary>
       /// <param name="ChangeNachname"></param>
       /// <param name="ChangeVorname"></param>
       /// <param name="UserID"></param>
        public void changeNameInDB(String ChangeNachname, String ChangeVorname, int UserID)
        {
            this.db.Query("UPDATE user SET nachname = '" + ChangeNachname + "', vorname = '" + ChangeVorname + "' WHERE ID = " + UserID);
        }
       /// <summary>
       /// Anhand von UserID wird Password geaendert.
       /// </summary>
       /// <param name="ChangePassword"></param>
       /// <param name="UserID"></param>
        public void changePWInDB(String ChangePasswordneu, String ChangePasswordneuWdh, String ChangePasswordAlt, int UserID)
        {
            if (checkPWInDB(ChangePasswordAlt) && checkPWequal(ChangePasswordneu, ChangePasswordneuWdh))
            {
                this.db.Query("UPDATE user SET password = '" + ChangePasswordneu + "' WHERE ID = " + UserID);
            }
            else
            {
                MessageBox.Show("Passworteingabe fehlerhaft!");
            }
        }

        private Boolean checkPWInDB(String inputPassword)
        {
            if (inputPassword == getPassword())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       private Boolean checkPWequal(String inputPassword, String checkPassword)
       {
            if (inputPassword == checkPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
       }
    }
}
