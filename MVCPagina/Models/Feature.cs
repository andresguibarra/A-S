using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCPagina.Models
{
    public class Feature
    {
        public virtual int FeatureId { get; set; }

        public virtual string Nombre { get; set; }

        public virtual ICollection<ServicioFeature> ServicioFeatures { get; set; }
    }
}
