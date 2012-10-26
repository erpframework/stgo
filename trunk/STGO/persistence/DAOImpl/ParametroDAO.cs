using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistence.DAO;
using business;
using System.Data;
using System.Data.SqlClient;

namespace Persistence.DAOImpl
{
    public class ParametroDAO : GenericDAO, IParametroDAO
    {

        public List<Parametro> getAll()
        {
            List<Parametro> parametros = null;
            if (base.Conectar())
            {
                SqlDataReader dataReader;
                base.Command = new SqlCommand();
                Parametro parametro;

                base.Command.Connection = base.Conexion;
                Command.CommandText = "SELECT clave, valor FROM parametro";
                Command.CommandType = CommandType.Text;
                dataReader = Command.ExecuteReader();

                while (dataReader.Read())
                {
                    parametro = new Parametro();
                    parametro.Clave = dataReader.GetSqlString(0).ToString();
                    parametro.Valor = dataReader.GetSqlString(1).ToString();
                    parametros.Add(parametro);
                }

            }
            return parametros;
        }

        public Parametro getFindByClave(String clave) {
            Parametro parametro = null;
            if (base.Conectar())
            {
                SqlDataReader dataReader;
                base.Command = new SqlCommand();
                

                base.Command.Connection = base.Conexion;
                Command.CommandText = "SELECT clave, valor FROM parametro WHERE clave = @clave";
                Command.CommandType = CommandType.Text;
                dataReader = Command.ExecuteReader();

                //Deberia entrar solo una vez.
                while (dataReader.Read())
                {
                    parametro = new Parametro();
                    parametro.Clave = dataReader.GetSqlString(0).ToString();
                    parametro.Valor = dataReader.GetSqlString(1).ToString();
                    
                }

            }
            return parametro;
        
        }

    }
}
