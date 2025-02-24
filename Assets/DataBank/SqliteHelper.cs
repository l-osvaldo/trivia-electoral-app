﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mono.Data.Sqlite;
using UnityEngine;
using System.Data;

namespace DataBank
{
    public class SqliteHelper
    {
        private const string CodistanTag = "Codistan: SqliteHelper:\t";

        private const string database_name = "Database_Trivia";

        public string db_connection_string;
        public IDbConnection db_connection;

        public SqliteHelper()
        {
            db_connection_string = "URI=file:" + Application.persistentDataPath + "/" + database_name;
            // Debug.Log("db_connection_string" + db_connection_string);
            db_connection = new SqliteConnection(db_connection_string);
            db_connection.Open();
        }

        ~SqliteHelper()
        {
            db_connection.Close();
        }

        //AppUserDB *********************************************************

        public virtual IDataReader getDataByEmailAndPassword(string email, string password)
        {
            Debug.Log(CodistanTag + "This function is not implemnted");
            throw null;
        }

        public virtual IDataReader registrados(string registro)
        {
            Debug.Log(CodistanTag + "This function is not implemnted");
            throw null;
        }

        public virtual void actualizarStatusRegistrado(string registro, string nombre, string email)
        {
            Debug.Log(CodistanTag + "This function is not implemnted");
            throw null;
        }

        public virtual void actualizarID(string registro, string nombre, string email)
        {
            Debug.Log(CodistanTag + "This function is not implemnted");
            throw null;
        }

        public virtual void actualizarScore(string score, string id)
        {
            Debug.Log(CodistanTag + "This function is not implemnted");
            throw null;
        }

        public virtual void actualizarStatus(string status, string id)
        {
            Debug.Log(CodistanTag + "This function is not implemnted");
            throw null;
        }

        public virtual IDataReader getDataByID(string id)
        {
            Debug.Log(CodistanTag + "This function is not implemnted");
            throw null;
        }

        public virtual IDataReader getDataByEmail(string email)
        {
            Debug.Log(CodistanTag + "This function is not implemnted");
            throw null;
        }

        //TemasDB ************************************************************

        public virtual IDataReader countTemas()
        {
            Debug.Log(CodistanTag + "This function is not implemnted");
            throw null;
        }

        public virtual IDataReader allTemas()
        {
            Debug.Log(CodistanTag + "This function is not implemnted");
            throw null;
        }

        public virtual IDataReader filtroTemas(string filtro)
        {
            Debug.Log(CodistanTag + "This function is not implemnted");
            throw null;
        }

        //PreguntasDB *********************************************************

        public virtual IDataReader countPreguntas()
        {
            Debug.Log(CodistanTag + "This function is not implemnted");
            throw null;
        }

        public virtual IDataReader getAllPreguntas()
        {
            Debug.Log(CodistanTag + "This function is not implemnted");
            throw null;
        }

        public virtual void deleteTable()
        {
            Debug.Log(CodistanTag + "This function is not implemnted");
            throw null;
        }

        public virtual IDataReader versionPreguntas()
        {
            Debug.Log(CodistanTag + "This function is not implemnted");
            throw null;
        }

        public virtual IDataReader filtroPorRubroAndSubrubroPreguntas(string rubro, string subrubro)
        {
            Debug.Log(CodistanTag + "This function is not implemnted");
            throw null;
        }

        public virtual IDataReader filtroPorTemaPreguntas(string tema)
        {
            Debug.Log(CodistanTag + "This function is not implemnted");
            throw null;
        }

        //MunicipiosDB *********************************************************

        public virtual IDataReader countMunicipios()
        {
            Debug.Log(CodistanTag + "This function is not implemnted");
            throw null;
        }

        public virtual IDataReader filtroMunicipios(string filtro)
        {
            Debug.Log(CodistanTag + "This function is not implemnted");
            throw null;
        }

        //EstadosDB *********************************************************

        public virtual IDataReader countEstados()
        {
            Debug.Log(CodistanTag + "This function is not implemnted");
            throw null;
        }

        public virtual IDataReader allEstados()
        {
            Debug.Log(CodistanTag + "This function is not implemnted");
            throw null;
        }

        public virtual IDataReader filtroEstados(string filtro)
        {
            Debug.Log(CodistanTag + "This function is not implemnted");
            throw null;
        }

        //ResultadosDB *********************************************************
        public virtual IDataReader existeRegistroResultado(string id_user_app, string registrado)
        {
            Debug.Log(CodistanTag + "This function is not implemnted");
            throw null;
        }
        public virtual IDataReader existeRegistroResultado2(string id_user_app)
        {
            Debug.Log(CodistanTag + "This function is not implemnted");
            throw null;
        }

        public virtual void updateResultados(string id_user_app, string aciertos, string errores, string detalle)
        {
            Debug.Log(CodistanTag + "This function is not implemnted");
            throw null;
        }

        public virtual void updateResultados2(string id_user_app)
        {
            Debug.Log(CodistanTag + "This function is not implemnted");
            throw null;
        }

        public virtual IDataReader registradoResultado(string id_user_app, string registro)
        {
            Debug.Log(CodistanTag + "This function is not implemnted");
            throw null;
        }

        public virtual void updateResultadoWS(string id_user_app, string id, string registrado)
        {
            Debug.Log(CodistanTag + "This function is not implemnted");
            throw null;
        }

        //helper functions *****************************************************
        public IDbCommand getDbCommand()
        {
            return db_connection.CreateCommand();
        }

        public IDataReader getAllData(string table_name)
        {
            IDbCommand dbcmd = db_connection.CreateCommand();
            dbcmd.CommandText =
                "SELECT * FROM " + table_name;
            IDataReader reader = dbcmd.ExecuteReader();
            return reader;
        }

        public void deleteAllData(string table_name)
        {
            IDbCommand dbcmd = db_connection.CreateCommand();
            dbcmd.CommandText = "DROP TABLE IF EXISTS " + table_name;
            dbcmd.ExecuteNonQuery();
        }

        public IDataReader getNumOfRows(string table_name)
        {
            IDbCommand dbcmd = db_connection.CreateCommand();
            dbcmd.CommandText =
                "SELECT COALESCE(MAX(id)+1, 0) FROM " + table_name;
            IDataReader reader = dbcmd.ExecuteReader();
            return reader;
        }

        public void close()
        {
            db_connection.Close();
        }
    }
}
