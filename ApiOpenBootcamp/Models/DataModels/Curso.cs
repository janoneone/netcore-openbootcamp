using System.ComponentModel.DataAnnotations;

namespace ApiOpenBootcamp.Models.DataModels
{
    public class Curso: BaseEntity
    {
        public string Nombre { get; set; }=String.Empty;
        [StringLength(280)]
        public string DescripcionCorta { get; set; }=string.Empty;

        public string DescripcionLarga { get; set; }=string.Empty;
        public string PublicoObjetivo{ get; set; }=string.Empty;
        public string Objetivos { get; set; }=string.Empty;
        public string Requisitos { get; set; }=string.Empty;

        public int Nivel { get; set; }=0;


    }
}
