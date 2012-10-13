using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistence.DAO;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace Persistence.DAOImpl
{
    public abstract class GenericDAO:IGenericDAO
    {
        string sConexion;
        SqlCommand sqlComm;
        SqlConnection sqlConn;
        SqlDataAdapter sqlDA;
        DataTable dtResultado;
        SqlTransaction transaccion;
        Int32 cantidadParametros = 0;
        Int32 numeroDeRegistro = 0;

        public bool Conectar()
        {
            sConexion = CadenaConexion();

            if (sqlConn == null)
                sqlConn = new SqlConnection(sConexion);

            if (sqlConn.State == ConnectionState.Closed)
                sqlConn.Open();


            return (sqlConn.State == ConnectionState.Open);

        }

        public String CadenaConexion()
        {
            SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();
            csb.DataSource = @"(local)";
            csb.InitialCatalog = "STGO";
            csb.IntegratedSecurity = false;
            csb.UserID = "stgo";
            csb.Password = "adminadmin";

            return csb.ConnectionString;
        }

        public bool ComenzarTransaccion()
        {
            try
            {
                transaccion = sqlConn.BeginTransaction();
            }
            catch (SqlException sqlEx)
            {
                return false;
            }

            return true;

        }

        public bool FinalizarTransaccion()
        {
            try
            {
                transaccion.Commit();
            }
            catch (SqlException sqlEx)
            {
                transaccion.Rollback();
                return false;
            }

            return true;

        }

        public bool CancelarTransaccion()
        {
            try
            {
                transaccion.Rollback();
            }
            catch (SqlException sqlEx)
            {
                return false;
            }

            return true;

        }

    }
}
