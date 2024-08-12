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

        private int id;
        private string userName2;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        public string NewName { get => newName; set => newName = value; }
        public string NewPass { get => newPass; set => newPass = value; }
        public string AUserName { get => aUserName; set => aUserName = value; }
        public int Id { get => id; set => id = value; }
        public string UserName2 { get => userName2; set => userName2 = value; }
    }
}
