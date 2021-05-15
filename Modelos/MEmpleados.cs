using Lebra.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Lebra.Controlador;

namespace Lebra.Modelos
{
     public class MEmpleados
    {
        IDbConnection cn = Conexion.conectarr();

        public void Insertar(Empleados empleados)
        {
            try
            {
                string consulta = "Insert into empleados values(@Nombre_Apellido,@Telefono@DUI@Sueldo_dia)";
                //****************************
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("@Nombre_Apellido", empleados.nombres_Apellidos, DbType.String);
                parametros.Add("@Telefono",empleados.telefono, DbType.Double);
                parametros.Add("@DUI",empleados.Dui, DbType.Double);
                parametros.Add("@Sueldo_dia", empleados.sueldo_dia, DbType.Double);

                //****************************
                cn.Open();
                cn.Execute(consulta, parametros, commandType: CommandType.Text);
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public void Actualizar(Empleados empleados)
        {
            string consulta = "Update Usuarios set Nombre_Apellido='" + empleados.nombres_Apellidos + "' where IdUsuario=" + empleados.idEmpleado;
            cn.Open();
            cn.Execute(consulta);
            cn.Close();
        }

        public void Eliminar(Empleados empleados)
        {
            string consulta = "Delete from Empleados where Id=" + empleados.idEmpleado;
            cn.Open();
            cn.Execute(consulta);
            cn.Close();
        }

        public List<Usuarios> ConsultarListado()
        {
            List<Usuarios> Usuarios = new List<Usuarios>();
            string consulta = "Select * from Empleados";
            cn.Open();
            Usuarios = cn.Query<Usuarios>(consulta).ToList();
            cn.Close();
            return Usuarios;

        }


    }
}