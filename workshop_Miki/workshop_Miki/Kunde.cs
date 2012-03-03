using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workshop_Miki
{
    class Kunde
    {
        String sName; //Nachname von Kunde
        int iAlter; //Alter von Kunden


        public void setName(String name) //nur "name", da Parameter, der übergeben wird und nicht als globale Variable vorkommt
        {
            if (name.Length < 50)
            {

            }
            this.sName = name; // this. -> Variable aus der Klasse wird hergenommen.
        }

        public String getName()
        {
            return this.sName;
        }
    }
}
