using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myStik.Default;
using System.Data;

namespace myStik.Default
{
    class Product
    {
        int ID;
        String sTitel;
        String sBeschreibung;
        String sBildURL; // evtl. Bild als als eigene Klasse (siehe DB-Modell), vllt. auch anders lösbar
        int iPreis;
        String sEinstellungsDatum; //eigene Variable??;vorgefertigte Methode "public date heute()"
        String sProduktkategorie;
        DataTable dtKontaktinformationen; //ratsam eine eigene DatenbankTabelle zu erstellen?


        //SQL Adapter
        MySQLAdapter db = new MySQLAdapter();

        public Product(int id)
        {
            DataTable DT = this.db.Query("SELECT * FROM product WHERE ID = " + id);

            this.setTitel(DT.Rows[0]["titel"].ToString());
            this.setBeschreibung(DT.Rows[0]["beschreibung"].ToString());
            this.setProduktkategorie(DT.Rows[0]["produktkategorie"].ToString());
            this.setBildURL(DT.Rows[0]["bildurl"].ToString());
            this.setPreis(Convert.ToInt32(DT.Rows[0]["preis"]));
            this.setEinstellungsDatum(DT.Rows[0]["einstellungsdatum"].ToString());
            //this.setKontaktinformationen();
        }

        private void setEinstellungsDatum(string p)
        {
            this.sEinstellungsDatum = p;
        }
        private void setTitel(string p)
        {
            this.sTitel = p;
        }
        private void setBeschreibung(string p)
        {
            this.sBeschreibung = p;
        }
        private void setProduktkategorie(string p)
        {
            this.sProduktkategorie = p;
        }
        private void setBildURL(string p)
        {
            this.sBildURL = p;
        }
        private void setPreis(int p)
        {
            this.iPreis = p;
        }
        private void setKontaktinformationen()
        {

        }
        public String getTitel()
        {
            return sTitel;
        }
        public String getBeschreibung()
        {
            return sBeschreibung;
        }
        public String getBildURL()
        {
            return sBildURL;
        }
        public String getEinstellungsDatum()
        {
            return sEinstellungsDatum;
        }
        public int getPreis()
        {
            return iPreis;
        }

        //Suchfunktion einfügen, Beachten: was passiert, wenn: mehr als 10 Ergebnisse angezeigt
        //keine suchergebnisse gefunden werden, suche abbrechen, suche starten, etc.
    }
}
