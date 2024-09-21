using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberOS.Controlador
{
    internal class ControlListaPromocionesG
    {
        private vistaMenu menuForm;
        private VistaListaPromocionesG controladaVista;
        private DaoListaPromocionesG dao = new DaoListaPromocionesG();

        public ControlListaPromocionesG(VistaListaPromocionesG vistaPasada, vistaMenu passedMenuForm)
        {
            controladaVista = vistaPasada;
            menuForm = passedMenuForm;

            controladaVista.listPromociones.SelectedIndexChanged += (sender, e) => ShowData();


            //Cuando se presionen los botones marcados en la izquierda se ejecutaran las funciones a la derech
            //por ejemplo si se presiona agregar se ejecutara la funcion insertData
            controladaVista.btnBorrar.Click += (sender, e) => deleteData();
            controladaVista.btnAgregar.Click += (sender, e) => InsertData();
            controladaVista.btnActualizar2.Click += (sender, e) => UpdateData();
            controladaVista.btnBuscar.Click += (sender, e) => searchData();
            controladaVista.btnVolver.Click += (sender, e) => passedMenuForm.controladorMenu.AbrirFormulario(new VistaInicioGestion(passedMenuForm));
            dao.Populate(controladaVista);
        }

        //Esto se ejecuta cuando el usuario presione una fila, los valores de la fila se aplicaran a los texboxes del panel izquierdo
        public void ShowData()
        {
            if (controladaVista.listPromociones.SelectedItems.Count > 0)
            {
                ListViewItem seleccionado = controladaVista.listPromociones.SelectedItems[0];
                controladaVista.txtId.Text = seleccionado.SubItems[0].Text;
                controladaVista.txtNombre.Text = seleccionado.SubItems[1].Text;
                controladaVista.txtPrecio.Text = seleccionado.SubItems[2].Text;
                controladaVista.txtPoder.Text = seleccionado.SubItems[3].Text;
                controladaVista.cmbTipo.Text = seleccionado.SubItems[4].Text;
            }
            else
            {
                controladaVista.txtId.Text = null;
                controladaVista.txtNombre.Text = null;
                controladaVista.txtPrecio.Text = null;
                controladaVista.txtPoder.Text = null;
                controladaVista.cmbTipo.Text = null;
            }
        }

        //Se ejecutara la funcion insert del dao y obtener para actualizar la tabla
        public void InsertData()
        {
            if (controladaVista.txtNombre.Text.Equals("") || controladaVista.txtPoder.Text.Equals("") || controladaVista.txtPrecio.Text.Equals("") || controladaVista.cmbTipo.Equals(""))
            {
                MessageBox.Show("Hay campos vacios");
            }
            else
            {
                dao.Insert(controladaVista);
                dao.Populate(controladaVista);
            }
        }

        //Se ejecutara la funcion update del dao y obtener para actualizar la tabla
        public void UpdateData()
        {
            if (controladaVista.txtNombre.Text.Equals("") || controladaVista.txtPoder.Text.Equals("") || controladaVista.txtPrecio.Text.Equals("") || controladaVista.cmbTipo.Equals(""))
            {
                MessageBox.Show("Hay campos vacios");
            }
            else
            {
                dao.Update(controladaVista);
                dao.Populate(controladaVista);
            }
        }

        //Se ejecutara la funcion delete del dao y obtener para actualizar la tabla
        public void deleteData()
        {
            //1 Si existe una fila en la tabla de la vista que el usuario haya seleccionado se ejecutara lo siguiente
            if (controladaVista.listPromociones.SelectedItems.Count > 0)
                //2 Se ejecutara la funcion delete del dao
                dao.Delete(controladaVista);

            dao.Populate(controladaVista);
        }

        public void searchData()
        {
            //1 Se obtendran los datos que el usuario ingreso en la barra de busqueda
            string searchingFor = controladaVista.txtSearchingFor.Text;
            //2 Se ejecutara la funcion searchData del dao
            dao.searchData(searchingFor, controladaVista);
        }
    }
}
