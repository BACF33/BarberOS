using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System.Configuration;
using System.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace BarberOS.Controlador
{
    internal class ControlListaRegistros
    {
        private vistaMenu menuForm;
        private VistaListaRegistros controladaVista;
        private DaoListaRegistrosG dao = new DaoListaRegistrosG();

        public ControlListaRegistros(VistaListaRegistros vistaPasada, vistaMenu passedMenuForm)
        {
            controladaVista = vistaPasada;
            menuForm = passedMenuForm;

            controladaVista.listRegistros.SelectedIndexChanged += (sender, e) => ShowData();


            //Cuando se presionen los botones marcados en la izquierda se ejecutaran las funciones a la derech
            //por ejemplo si se presiona agregar se ejecutara la funcion insertData
            controladaVista.btnBorrar.Click += (sender, e) => deleteData();
            controladaVista.btnInsertar.Click += (sender, e) => InsertData();
            controladaVista.btnActualizar.Click += (sender, e) => UpdateData();
            controladaVista.btnBorrar.Click += (sender, e) => searchData();
            controladaVista.btnVolver.Click += (sender, e) => passedMenuForm.controladorMenu.AbrirFormulario(new VistaInicioGestion(passedMenuForm));
            dao.Populate(controladaVista);
        }

        public void ShowData()
        {
            if (controladaVista.listRegistros.SelectedItems.Count > 0)
            {
                ListViewItem seleccionado = controladaVista.listRegistros.SelectedItems[0];
                controladaVista.txtId.Text = seleccionado.SubItems[1].Text;
                controladaVista.txtUser.Text = seleccionado.SubItems[2].Text;
                controladaVista.txtProduct.Text = seleccionado.SubItems[3].Text;
                controladaVista.txtPromotion.Text = seleccionado.SubItems[4].Text;
            }
            else
            {
                controladaVista.txtId.Text = null;
                controladaVista.txtUser.Text = null;
                controladaVista.txtProduct.Text = null;
                controladaVista.txtPromotion.Text = null;
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
            if (controladaVista.listRegistros.SelectedItems.Count > 0)
                //2 Se ejecutara la funcion delete del dao
                dao.Delete(controladaVista);

            dao.Populate(controladaVista);
        }

        public void searchData()
        {
            //1 Se obtendran los datos que el usuario ingreso en la barra de busqueda
            string searchingFor = controladaVista.txtSearch.Text;
            //2 Se ejecutara la funcion searchData del dao
            dao.searchData(searchingFor, controladaVista);
        }
    }
}