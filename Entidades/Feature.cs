using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace MVCPagina.Models
{
    public class Feature
    {
        public virtual int FeatureId { get; set; }

        public virtual string  Descripcion { get; set; }

        public Nullable<int> ServicioId { get; set; }
        public Feature() { }

        
        public virtual Servicio Servicio { get; set; }
    }
}
