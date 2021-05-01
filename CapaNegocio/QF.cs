using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class QF
    {
        //Definir atributos de la clase
        private string apellidos;
        private string nombres;
        private string dni;
        private string domicilio;
        private string experienciaLaboral;
                


        //Propiedades: Como parte de la clase permite acceder a los atributos

        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string ExperienciaLaboral { get => experienciaLaboral; set => experienciaLaboral = value; }


        //Métodos
        public string Verificar()
        {
            return "El Método Verificar no está implementado";
        }

        public string Dirigir()
        {
            return "El Método Dirigir no está implementado";
        }

        public string Evaluar()
        {
            return "El Método Evaluar no está implementado";
        }

        public string Supervisar()
        {
            return "El Método Supervisar no está implementado";
        }
    }
}
