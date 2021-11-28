using System;
//using System.ComponentModel.DataAnnotations;

namespace Emigrant.App.Dominio{
    public class GererenciaDeProyecto
    {
        public DateTime FechaNovedad { get; set; }
        public int DiasActividad { get; set; }
        public string TextoExplicativo { get; set; }
        public DateTime FechaInicioReporte { get; set; }
        public DateTime FechaFinalReporte { get; set; }

    }
}