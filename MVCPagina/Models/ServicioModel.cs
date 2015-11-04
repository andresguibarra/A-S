using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPagina.Models
{
    public class ServicioModel
    {
        private List<string> features;
        public string Nombre { get; set; }

        public List<string> Features
        {
            get
            {
                if (this.features==null)
                {
                    features = new List<string>();
                    return features;
                }
                else
                {
                    return this.features;
                }
            }
            set {
                this.features = value;
            }
        }

        public string Precio { get; set; }

        public int CantidadIconos { get; set; }
    }
}