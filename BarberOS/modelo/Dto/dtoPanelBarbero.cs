using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BarberOS.Modelo.Dto
{
    internal class DtoPanelBarbero
    {
        private string barberoId;
        private string barberoName;
        private string barberoRole;

        public string BarberoId { get => barberoId; set => barberoId = value; }
        public string BarberoName { get => barberoName; set => barberoName = value; }
        public string BarberoRole { get => barberoRole; set => barberoRole = value; }
    }
}
