using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lebra.Entidades;
using Lebra.Modelos;

namespace Lebra.Controlador
{
    class CEmpleados
    {
        MEmpleados mEmpleados = new MEmpleados();


        public void Insertar(Empleados empleados)
        {
            mEmpleados.Insertar(empleados);
        }

        public void Actualizar(Empleados empleados)
        {
            mEmpleados.Actualizar(empleados);
        }

        public void Eliminar(Empleados empleados)
        {
            mEmpleados.Eliminar(empleados);
        }

        public List<Empleados> ConsultarListado()
        {
            return mEmpleados.ConsultarListado();
        }
        //public Usuarios ConsultarUna(int id)
        //{
        //    //    return mUsuarios.ConsultarUna(id);
        //    //}
        //}
    }
}
