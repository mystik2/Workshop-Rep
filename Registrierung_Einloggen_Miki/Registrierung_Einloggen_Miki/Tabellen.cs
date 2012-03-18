using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Registrierung_Einloggen_Miki
{
    class Tabellen
    {
        public static DataTable GetTable(String Username, String Password)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Username", typeof(String));
            table.Columns.Add("Password", typeof(String));

            table.Rows.Add(Username, Password);
            return table;

        }
    }
}
