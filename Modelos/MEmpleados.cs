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
            string consulta = "Update Empleados set Nombre_Apellido='" + empleados.nombres_Apellidos + "' where IdEmpleados=" + empleados.idEmpleado;
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

        public List<Empleados> ConsultarListado()
        {
            List<Empleados> empleados = new List<Empleados>();
            string consulta = "Select * from Empleados";
            cn.Open();
            empleados = cn.Query<Empleados>(consulta).ToList();
            cn.Close();
            return empleados;



        }
      

    }
}