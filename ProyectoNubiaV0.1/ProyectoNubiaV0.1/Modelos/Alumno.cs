//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoNubiaV0._1.Modelos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Alumno
    {
        public Alumno()
        {
            this.Alumnos_GrupoGimnasio = new HashSet<Alumnos_GrupoGimnasio>();
        }
    
        public string Matricula { get; set; }
        public int idGrupo { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Edad { get; set; }
    
        public virtual Grupo Grupo { get; set; }
        public virtual ICollection<Alumnos_GrupoGimnasio> Alumnos_GrupoGimnasio { get; set; }
    }
}