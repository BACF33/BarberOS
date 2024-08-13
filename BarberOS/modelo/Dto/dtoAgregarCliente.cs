using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Modelo.Dto
{
    internal class dtoAgregarCliente
    {
        private string userName;
        private string password;
        private int points;
        private string phone;

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public int Points { get => points; set => points = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}
