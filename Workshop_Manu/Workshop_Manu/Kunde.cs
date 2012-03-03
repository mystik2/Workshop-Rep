using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workshop_Manu
{
    public class Kunde : Mensch
    {
        int iAnzahlHuete;

        public Kunde()
        {
            this.iAnzahlHuete = 10;
            //throw new Exception("Fehler, weil du Depp");
        }


        public void setName(String name)
        {           
            if (this.ueberPruefeName(name))
            {
                this.sName = (String)name;
            }
        }

        public void setHuete(params Object[] Hut)
        {
            //this.setHuete(new Object(), new Object(), new Object(), new Object(), new Object());

            //foreach (Object h in Hut)
            //{
            //    h = null;
            //}
        }
    }
}
