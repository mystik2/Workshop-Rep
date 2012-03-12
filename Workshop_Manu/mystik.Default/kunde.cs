using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyStik.Default;
using System.Data;

namespace mystik.Default
{
    public class kunde
    {
        int ID;
        String sNachname;
        String sVorname;

        //SQL Adapter
        MySQLAdapter db = new MySQLAdapter();

        public kunde(int id)
        {
            DataTable DT = this.db.Query("SELECT * FROM kunde WHERE ID = " + id);

            this.setName(DT.Rows[0]["name"].ToString());
            this.setVorname(DT.Rows[0]["vorname"].ToString());
        }

        private void setVorname(string p)
        {
            this.sVorname = p;
        }

        private void setName(String p)
        {
            this.sNachname = p;
        }

        public static void writeToDB(String name, String vorname)
        {
            MySQLAdapter db = new MySQLAdapter();

            db.Query("INSERT INTO kunde(vorname, nachname) VALUES('" + name + "', '" + vorname + "')");

        }
    }
}
