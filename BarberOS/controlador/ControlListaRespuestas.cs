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
    internal class ControlListaRespuestas
    {
        VistaListaRespuestas vistaControlada;
        DaoListaRespuestas daoThis = new DaoListaRespuestas();

        public ControlListaRespuestas(VistaListaRespuestas vistaPasada, vistaMenu menuForm) 
        {
            vistaControlada = vistaPasada;
            daoThis.Populate(vistaPasada);
            daoThis.PopulateUsers(vistaPasada);
            daoThis.PopulateQuestions(vistaPasada);

            vistaControlada.btnAgregar.Click += (sender, e) => Agregar();
            vistaControlada.btnActualizar2.Click += (sender, e) => Actualizar();
            vistaControlada.btnBorrar.Click += (sender, e) => Borrar();

            vistaControlada.listRespuestas.SelectedIndexChanged += (sender, e) => ShowData();
            //vistaControlada.btnBorrar += (sender, e) => 
        }

        public void Agregar()
        {
            daoThis.insertar(vistaControlada);
            daoThis.Populate(vistaControlada);
        }

        public void Actualizar()
        {
            daoThis.Update(vistaControlada);
            daoThis.Populate(vistaControlada);
        }

        public void Borrar()
        {
            daoThis.Delete(vistaControlada);
            daoThis.Populate(vistaControlada);
        }

        public void ShowData()
        {
            if (vistaControlada.listRespuestas.SelectedItems.Count > 0)
            {
                ListViewItem seleccionado = vistaControlada.listRespuestas.SelectedItems[0];
                vistaControlada.txtId.Text = seleccionado.SubItems[0].Text;
                vistaControlada.txtRespuesta.Text = seleccionado.SubItems[1].Text;
                vistaControlada.cmbPreguntas.SelectedItem = seleccionado.SubItems[2].Text;
                vistaControlada.cmbUsuarios.SelectedItem = seleccionado.SubItems[3].Text;
            }
            else
            {
                vistaControlada.txtId.Text = null;
                vistaControlada.txtRespuesta.Text = null;
                vistaControlada.cmbPreguntas.SelectedItem = null;
                vistaControlada.cmbUsuarios.SelectedItem = null;
            }
        }
    }
}
