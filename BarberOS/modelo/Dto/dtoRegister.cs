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
        private string newEmail;

        public string NewUser { get => newUser; set => newUser = value; }
        public string NewPassword { get => newPassword; set => newPassword = value; }
        public string NewEmail { get => newEmail; set => newEmail = value; }
    }
}
