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
    internal class ControlListaPregunas
    {
        DaoListaPreguntas daoThis = new DaoListaPreguntas();
        vistaListaPreguntas vistaControlada;
        public ControlListaPregunas(vistaListaPreguntas vistaPasada, vistaMenu menuPasado)
        {
            daoThis.Populate(vistaPasada);
            vistaControlada = vistaPasada;
            vistaPasada.btnAgregar.Click += (sender, e) => Insertar();
            vistaPasada.btnBorrar.Click += (sender, e) => Borrar();
            vistaControlada.btnARespuestas.Click += (sender, e) => menuPasado.controladorMenu.AbrirFormulario(new VistaListaRespuestas());

            vistaControlada.listPreguntas.SelectedIndexChanged += (sender, e) => ShowData();
        }

        public void Insertar()
        {
            daoThis.insertar(vistaControlada);
            daoThis.Populate(vistaControlada);
        }

        public void Borrar() 
        {
            daoThis.Delete(vistaControlada);
            daoThis.Populate(vistaControlada);
        }

        public void ShowData()
        {
            if (vistaControlada.listPreguntas.SelectedItems.Count > 0)
            {
                ListViewItem seleccionado = vistaControlada.listPreguntas.SelectedItems[0];
                vistaControlada.txtId.Text = seleccionado.SubItems[0].Text;
                vistaControlada.txtPregunta.Text = seleccionado.SubItems[1].Text;
            }
            else
            {
                vistaControlada.txtId.Text = null;
                vistaControlada.txtPregunta.Text = null;
            }
        }

    }
}
