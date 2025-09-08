using System;

namespace Gestor_de_Tareas
{
    internal class Tarea
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public string Lugar { get; set; }
        public string Estado { get; set; }
    }
}