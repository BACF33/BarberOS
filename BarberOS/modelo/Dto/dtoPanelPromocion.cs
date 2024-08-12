using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Modelo.Dto
{
    public class dtoPanelPromocion
    {
        private int promocionId;
        private string promocionName;
        private string promocionPrecio;
        private string promocionTipo;
        private string promocionPoder;

        public string PromocionName { get => promocionName; set => promocionName = value; }
        public string ProductoPrecio { get => promocionPrecio; set => promocionPrecio = value; }
        public string PromocionTipo { get => promocionTipo; set => promocionTipo = value; }
        public string PromocionPoder { get => promocionPoder; set => promocionPoder = value; }
        public int PromocionId { get => promocionId; set => promocionId = value; }
    }
}
