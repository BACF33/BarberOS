using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberOS.Controlador
{
    internal class controlAgregarCliente
    {
        vistaAgregarCliente controladaVista = null;
        public controlAgregarCliente(vistaAgregarCliente pasadaVista)
        {
            controladaVista = pasadaVista;
            controladaVista.btnAgregar.Click += (sender, e) => agregarProducto();
        }

        public void agregarProducto()
        {
            daoAgregarCliente daoThis = new daoAgregarCliente(controladaVista);
        }
    }
}
