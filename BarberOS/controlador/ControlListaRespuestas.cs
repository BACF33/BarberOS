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

            //Cuando se presionen los botones marcados en la izquierda se ejecutaran las funciones a la derech
            //por ejemplo si se presiona agregar se ejecutara la funcion insertData
            vistaControlada.btnAgregar.Click += (sender, e) => Agregar();
            vistaControlada.btnActualizar2.Click += (sender, e) => Actualizar();
            vistaControlada.btnBorrar.Click += (sender, e) => Borrar();
            vistaControlada.btnBuscar.Click += (sender, e) => Buscar();

            vistaControlada.listRespuestas.SelectedIndexChanged += (sender, e) => ShowData();
            vistaControlada.btnVolver.Click += (sender, e) => menuForm.controladorMenu.AbrirFormulario(new VistaInicioGestion(menuForm));
            //vistaControlada.btnBorrar += (sender, e) => 
        }

        public void Agregar()
        {
            //Valida que no haya campos vacios
            if (vistaControlada.txtRespuesta.Text.Equals("") || vistaControlada.txtRespuesta.Text.Equals(""))
            {
                MessageBox.Show("Hay campos vacios");
            }
            else
            {
                //Se ejecuta la funcion insertar y populate del dao para actualizar la tabla
                daoThis.insertar(vistaControlada);
                daoThis.Populate(vistaControlada);
            }
        }

        public void Actualizar()
        {
            //Valida que no haya campos vacios
            if (vistaControlada.txtRespuesta.Text.Equals("") || vistaControlada.cmbPreguntas.Text.Equals("") || vistaControlada.cmbUsuarios.Text.Equals(""))
            {
                MessageBox.Show("Hay campos vacios");
            }
            else
            {
                //Se ejecuta la funcion update y populate del dao para actualizar la tabla
                daoThis.Update(vistaControlada);
                daoThis.Populate(vistaControlada);
            }
        }

        //Se ejecutara la funcion delete del dao y obtener para actualizar la tabla
        public void Borrar()
        {
            daoThis.Delete(vistaControlada);
            daoThis.Populate(vistaControlada);
        }

        //Esto se ejecuta cuando el usuario presione una fila, los valores de la fila se aplicaran a los texboxes del panel izquierdo
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

        public void Buscar()
        {
            string searchingFor = vistaControlada.txtSearchingFor.Text;
            daoThis.Search(searchingFor, vistaControlada);
        }
    }
}
