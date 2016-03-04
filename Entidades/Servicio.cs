using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPagina.Models
{
    public class Servicio
    {
        public virtual int ServicioId { get; set; }
        public virtual string Nombre { get; set; }
        
        public virtual decimal Precio { get; set; }

        public virtual int CantidadIconos { get; set; }

        public Servicio() {

            this.Features = new HashSet<Feature>();
        }
        public ICollection<Feature> Features { get; set; }
    }
}