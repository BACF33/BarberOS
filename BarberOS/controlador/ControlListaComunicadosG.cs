using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberOS.Controlador
{
    internal class ControlListaComunicadosG
    {
        DaoListaComunicadosG daoThis = new DaoListaComunicadosG();
        VistaListaComunicadosG vistaControlada;
        vistaMenu menuControlado;

        public ControlListaComunicadosG(VistaListaComunicadosG vistaPasada, vistaMenu menuPasado) 
        {
            menuControlado = menuPasado;
            vistaControlada = vistaPasada;
            daoThis.Obtener(vistaControlada);
            vistaPasada.btnAgregar.Click += (sender, e) => Agregar();
            vistaPasada.btnVolver.Click += (sender, e) => menuPasado.controladorMenu.AbrirFormulario(new VistaInicioGestion(menuPasado));
            vistaPasada.btnBorrar.Click += (sender, e) => Borrar();
        }

        public void Agregar() 
        {
            if (vistaControlada.txtText.Text.Equals(""))
            {
                MessageBox.Show("Hay campos vacios");
            }
            else
            {
                daoThis.Agregar(vistaControlada, menuControlado);
                daoThis.Obtener(vistaControlada);
            }
        }

        public void Borrar()
        {
            daoThis.Borrar(vistaControlada);
            daoThis.Obtener(vistaControlada);
        }
    }
}
