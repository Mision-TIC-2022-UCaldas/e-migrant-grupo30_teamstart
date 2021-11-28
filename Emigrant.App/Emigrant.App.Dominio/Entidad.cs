using System;
using System.ComponentModel.DataAnnotations;

namespace Emigrant.App.Dominio{
    
    public class Entidad{
        public int id { get; set; }
       [Required]
        public string razón_social { get; set; }
        [Required]
        public string nit { get; set; }
        [Required]
        public string direccion { get; set; }
        [Required]
        public string ciudad { get; set; }
        [Required]
        public string telefono { get; set; }
       [Required]
        public string direccion_electronica { get; set; }
        public string pagina_web { get; set; }
        public string sector { get; set; }
        public string tipo_servicio { get; set; }
       
    }
 
}
