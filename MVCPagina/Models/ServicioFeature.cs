using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace MVCPagina.Models
{
    public class ServicioFeature
    {
        [Key, Column(Order = 0)]
        public int ServicioId { get; set; }
        [Key, Column(Order = 1)]
        public int FeatureId { get; set; }

        public virtual Servicio Servicio { get; set; }
        public virtual Feature Feature { get; set; }

    }
}
