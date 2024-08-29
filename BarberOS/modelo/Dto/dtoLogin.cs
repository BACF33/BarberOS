using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Modelo.Dto
{
    public class DtoLogin
    {
        private string username;
        private string password;
        private string role;
        private int points;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        public int Points { get => points; set => points = value;}
        
    }
}
