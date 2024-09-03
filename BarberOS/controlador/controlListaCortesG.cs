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
    internal class ControlListaCortesG
    {
        private vistaMenu menuForm;
        private VistaListaCortesG controladaVista;
        private DaoListaCortesG dao = new DaoListaCortesG();

        public ControlListaCortesG(VistaListaCortesG vistaPasada, vistaMenu passedMenuForm)
        {
            controladaVista = vistaPasada;
            menuForm = passedMenuForm;

            controladaVista.listCortes.SelectedIndexChanged += (sender, e) => ShowData();


            //Cuando se presionen los botones marcados en la izquierda se ejecutaran las funciones a la derech
            //por ejemplo si se presiona agregar se ejecutara la funcion insertData
            controladaVista.btnBorrar.Click += (sender, e) => deleteData();
            controladaVista.btnAgregar.Click += (sender, e) => InsertData();
            controladaVista.btnAPersonal.Click += (sender, e) => passedMenuForm.controladorMenu.AbrirFormulario(new VistaListaCortesG(passedMenuForm));
            controladaVista.btnActualizar2.Click += (sender, e) => UpdateData();
            controladaVista.btnBuscar.Click += (sender, e) => searchData();
            controladaVista.btnVolver.Click += (sender, e) => passedMenuForm.controladorMenu.AbrirFormulario(new VistaInicioGestion(passedMenuForm));
            dao.Populate(controladaVista);
        }

        public void ShowData()
        {
            if (controladaVista.listCortes.SelectedItems.Count > 0)
            {
                ListViewItem seleccionado = controladaVista.listCortes.SelectedItems[0];
                controladaVista.txtId.Text = seleccionado.SubItems[0].Text;
                controladaVista.txtNombre.Text = seleccionado.SubItems[1].Text;
                controladaVista.txtPrecio.Text = seleccionado.SubItems[2].Text;
                controladaVista.txtTipo.Text = seleccionado.SubItems[2].Text;
            }
            else
            {
                controladaVista.txtId.Text = null;
                controladaVista.txtNombre.Text = null;
                controladaVista.txtPrecio.Text = null;
                controladaVista.txtTipo.Text = null;
            }
        }

        public void InsertData()
        {
            dao.Insert(controladaVista);
            dao.Populate(controladaVista);
        }

        public void UpdateData()
        {
            dao.Update(controladaVista);
            dao.Populate(controladaVista);
        }

        public void deleteData()
        {
            //1 Si existe una fila en la tabla de la vista que el usuario haya seleccionado se ejecutara lo siguiente
            if (controladaVista.listCortes.SelectedItems.Count > 0)
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