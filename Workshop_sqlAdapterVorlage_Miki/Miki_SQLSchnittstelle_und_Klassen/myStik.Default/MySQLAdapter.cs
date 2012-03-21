using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myStik.Default;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;

namespace myStik.Default
{
   public class MySQLAdapter
    {
        private MySqlConnection myConnection;

        public MySQLAdapter()
        {
            this.myConnection = new MySqlConnection
                                        (
                                            "UID=root;" +
                                            "PASSWORD=;" +
                                            "SERVER=localhost;" +
                                            "PORT=3306;" +
                                            "DATABASE=mystik;"
                                        );


        }

        /// <summary>
        /// Führt einen Query aus, ersetzt Platzhalter mit Values
        /// </summary>
        /// <param name="qry">BSP: SELECT * FROM `VVKUserDatabase` WHERE cardkey=@cardkey;</param>
        /// <param name="args">Argumente mit @wert=value</param>
        public DataTable Query(String qry, params String[] args)
        {
            try
            {
                this.connect();

                MySqlCommand command = this.myConnection.CreateCommand();

                //String resultQRY = String.Format(qry, args);
                //foreach (String arg in args)
                //{
                //    //params splitten
                //    String[] tmpParam = arg.Split('=');
                //    command.Parameters.AddWithValue(tmpParam[0], tmpParam[1]);
                //}

                command.CommandText = qry;

                MySqlDataReader objDataReader = command.ExecuteReader();

                DataTable objDT = new DataTable();

                objDT.Load(objDataReader);

                return objDT;

                //objDataReader.NextResult()
            }
            finally
            {
                this.myConnection.Close();
            }
        }

        private void connect()
        {
            try
            {
                this.myConnection.Open();
            }
            catch (SqlException e)
            {

            }
        }

    }
}
