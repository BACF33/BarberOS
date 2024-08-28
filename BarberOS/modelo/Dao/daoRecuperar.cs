using BarberOS.Modelo.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Modelo.Dao
{
    public class daoRecuperar
    {
        public string Recuperar(string solicitando)
        {
            return new dtoRecuperar().restablecer(solicitando);
        }
    }
}
