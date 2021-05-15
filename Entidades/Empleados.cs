using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebra.Entidades
{
    class Empleados
    {
        private string Nombres_Apellidos;
        private double Telefono;
        private int Sueldo_dia;
        public string nombres_Apellidos
        {
            get { return Nombres_Apellidos; }
            set { Nombres_Apellidos = value; }
        }

     

        public double telefono
        {
            get { return Telefono; }
            set { Telefono = value; }
        }

        private int DUI;

        public int Dui
        {
            get { return DUI; }
            set { DUI = value; }
        }

        

        public int sueldo_dia
        {
            get { return Sueldo_dia; }
            set { Sueldo_dia = value; }
        }

        private int IdEmpleado;

        public int idEmpleado
        {
            get { return IdEmpleado; }
            set { IdEmpleado = value; }
        }

        public  Empleados() {  }
    }
}
