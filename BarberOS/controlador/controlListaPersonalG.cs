   using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberOS.Controlador
{
    internal class ControlListaPersonalG
    {
        private vistaMenu menuForm;
        private VistaListaPersonalG controladaVista;
        private DaoListaPersonalG dao = new DaoListaPersonalG();
        //test
        public ControlListaPersonalG(VistaListaPersonalG vistaPasada, vistaMenu passedMenuForm)
        {
            controladaVista = vistaPasada;
            menuForm = passedMenuForm;

            controladaVista.listEmpleados.SelectedIndexChanged += (sender, e) => ShowData();

            //Cuando se presionen los botones marcados en la izquierda se ejecutaran las funciones a la derech
            //por ejemplo si se presiona agregar se ejecutara la funcion insertData
            controladaVista.btnBorrar.Click += (sender, e) => deleteData();
            controladaVista.btnAgregar.Click += (sender, e) => InsertData();
            controladaVista.btnActualizar2.Click += (sender, e) => UpdateData();
            controladaVista.btnBuscar.Click += (sender, e) => searchData();
            controladaVista.btnVolver.Click += (sender, e) => passedMenuForm.controladorMenu.AbrirFormulario(new VistaInicioGestion(passedMenuForm));
            controladaVista.picPersonal.Click += (sender, e) => LoadImage();

            dao.Populate(controladaVista);
        }

        //Funcion para que cuando el usuario presione la picturebox abra el explorador de archivos y el usuario suba una imagen al picturebox
        public void LoadImage()
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            DialogResult resultado = dialogo.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                controladaVista.picPersonal.Image = Image.FromFile(dialogo.FileName);
                controladaVista.picPersonal.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        //Esto se ejecuta cuando el usuario presione una fila, los valores de la fila se aplicaran a los texboxes del panel izquierdo
        public void ShowData()
        {
            if (controladaVista.listEmpleados.SelectedItems.Count > 0)
            {
                ListViewItem seleccionado = controladaVista.listEmpleados.SelectedItems[0];
                controladaVista.txtId.Text = seleccionado.SubItems[0].Text;
                controladaVista.txtName.Text = seleccionado.SubItems[1].Text;
                //controladaVista.txtContraseña.Text = seleccionado.SubItems[2].Text;
                controladaVista.txtPuntos.Text = seleccionado.SubItems[3].Text;
                controladaVista.cmbCargo.Text = seleccionado.SubItems[4].Text;
                controladaVista.txtEmail.Text = seleccionado.SubItems[5].Text;
                //controladaVista.txtLugar.Text = seleccionado.SubItems[6].Text;
            }
            else
            {
                controladaVista.txtId.Text = null;
                controladaVista.txtName.Text = null;
                //controladaVista.txtContraseña.Text = null;
                controladaVista.txtPuntos.Text = null;
                controladaVista.cmbCargo.Text = null;
                controladaVista.txtEmail.Text = null;
                //controladaVista.txtLugar.Text = null;
            }
        }

        //Se ejecutara la funcion insert del dao y obtener para actualizar la tabla
        public void InsertData()
        {
            if (controladaVista.txtContraseña.Text.Equals("") || controladaVista.txtEmail.Text.Equals("") || controladaVista.cmbCargo.Text.Equals("") || controladaVista.txtName.Text.Equals("") || controladaVista.txtPuntos.Text.Equals(""))
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
            if (controladaVista.txtContraseña.Text.Equals("") || controladaVista.txtEmail.Text.Equals("") || controladaVista.txtId.Text.Equals("") || controladaVista.cmbCargo.Text.Equals("") || controladaVista.txtName.Text.Equals("") || controladaVista.txtPuntos.Text.Equals(""))
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
            if (controladaVista.listEmpleados.SelectedItems.Count > 0)
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