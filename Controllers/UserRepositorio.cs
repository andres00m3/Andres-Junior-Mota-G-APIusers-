using APIuser1.Entities;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace APIuser1.Controllers
{
    public class UserRepositorio
    {
        private string conn;

        public UserRepositorio()
        {
            conn = @"Data Source= MSI\EXPRESS; Initial Catalog=usuarios; User Id=sa; Password=1234;";
        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(conn);
            }
        }

        public void Update(Usuario usuario)
        {
            using (IDbConnection dbConnection = Connection)
            {
               // string sql = @"INSERT Usuario set Nombres=@Nombres,Apellidos=@Apellidos, Genero=@Genero,Cedula=@Cedula,FechaDeNacimiento=@FechaDeNacimiento,Cargo=@Cargo,SupervisorInmediato=@SupervisorInmediato,IdDepartamentos=@IdDepartamentos WHERE id=@id";
                //string sql = @"UPDATE EMPLEADO set Nombres=" + empleado.Nombres + ",Apellidos= " + empleado.Apellidos + " WHERE Codigo_empleado=" + empleado.CodigoEmpleado + "";
               string sql = " INSERT INTO usuario(Nombres) Values(@Nombres)";
                dbConnection.Open();
                dbConnection.Query(sql, usuario);
                dbConnection.Close();
            }
        }
    }


}

