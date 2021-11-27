using System;
using System.ComponentModel.DataAnnotations;

namespace Emigrant.App.Dominio{
    public class Persona{
        public int id { get; set; }
       [Required]
        public string nombre { get; set; }
        [Required]
        public string apellidos { get; set; }
        [Required]
        public string tipodocumento { get; set; }
        [Required]
        public string numeroidentificacion { get; set; }
        [Required]
        public string paisorigen { get; set; }
       [Required]
        public string fechanacimiento { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string direccionactual { get; set; }
        public string ciudad { get;set; }
        public string situacionlaboral { get; set; }
    }
 
}
