using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebra.Entidades
{
    public class Usuarios

    {

        public int IdUsuario;
        private string Nombre_Apellido;
        private string Usua;
        private string Password;



        public string nombre_Apellido
        {
            get { return Nombre_Apellido; }
            set { Nombre_Apellido = value; }
        }

       
        
        public string usua
        {
            get { return Usua; }
            set { Usua = value; }
        }

      
        

        public string password
        {
            get { return Password; }
            set { Password = value; }
        }




        public int idUsuario
        {
            get { return IdUsuario; }
            set { IdUsuario = value; }
        }



        public Usuarios() { }


    }

}
