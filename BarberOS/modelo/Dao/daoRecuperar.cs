﻿using BarberOS.Modelo.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Modelo.Dao
{
    public class DaoRecuperar
    {
        public string Recuperar(string solicitando)
        {
            return new DtoRecuperar().restablecer(solicitando);
        }
    }
}
