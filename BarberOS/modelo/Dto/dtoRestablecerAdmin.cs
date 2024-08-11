using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Modelo.Dto
{
    internal class dtoRestablecerAdmin
    {
        private string username;
        private string password;
        private string role;

        private string newName;
        private string newPass;
        private string aUserName;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        public string NewName { get => newName; set => newName = value; }
        public string NewPass { get => newPass; set => newPass = value; }
        public string AUserName { get => aUserName; set => aUserName = value; }
    }
}
