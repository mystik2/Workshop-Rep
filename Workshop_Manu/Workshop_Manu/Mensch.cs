using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workshop_Manu
{
    public abstract class Mensch
    {
        protected String sName;//Nachname vom Kunde 
        protected int iAlter;//Alter vom Kunden


        public void setName(String name){            
            this.sName = name;
        }        
       
        public void setVorname()
        {

        }

        /// <summary>
        ///  Überprüft den Namen auf min. 10 Ziffern
        /// </summary>
        /// <param name="name">Kunden Namen</param>
        /// <returns>Hat min. 10 Ziffern ?</returns>
        internal Boolean ueberPruefeName(String name){
            if (name.Length < 10)
            {
                return false;
            }
            else
            {                
                return true;
            }
        }


        public String getName(){
            return this.sName;
        }
    }
}
