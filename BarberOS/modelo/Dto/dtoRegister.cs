using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Modelo.Dto
{
    internal class dtoRegister
    {
        private string newUser;
        private string newPassword;

        public string NewUser { get => newUser; set => newUser = value; }
        public string NewPassword { get => newPassword; set => newPassword = value; }
    }
}
