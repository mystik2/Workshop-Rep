using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyStik.Default;
using System.Data;

namespace mystik.Default
{
    class product
    {
        int ID;
        String sName;
        String sBeschreibung;
        String sbildURL;

        //SQL Adapter
        MySQLAdapter db = new MySQLAdapter();

        public product(int id)
        {
            DataTable DT = this.db.Query("SELECT * FROM product WHERE ID = " + id);

            //this.setName(DT.Rows[0]["name"].ToString());
            //this.setBeschreibung(DT.Rows[0]["beschreibung"].ToString());
            //this.setBildURL(DT.Rows[0]["bildurl"].ToString());
        }
    }
}
