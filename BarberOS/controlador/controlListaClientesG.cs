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
    internal class ControlListaClientesG
    {
        private vistaMenu menuForm;
        private VistaListaClientesG controladaVista;
        private DaoListaClientesG dao = new DaoListaClientesG();

        public ControlListaClientesG(VistaListaClientesG vistaPasada, vistaMenu passedMenuForm)
        {
            controladaVista = vistaPasada;
            menuForm = passedMenuForm;

            //Cuando se presione una fila se ejecutara showdata
            controladaVista.listClientes.SelectedIndexChanged += (sender, e) => ShowData();


            //Cuando se presionen los botones marcados en la izquierda se ejecutaran las funciones a la derech
            //por ejemplo si se presiona agregar se ejecutara la funcion insertData
            controladaVista.btnBorrar.Click += (sender, e) => deleteData();
            controladaVista.btnAgregar.Click += (sender, e) => InsertData();
            controladaVista.btnACortes.Click += (sender, e) => passedMenuForm.controladorMenu.AbrirFormulario(new vistaListaPreguntas(passedMenuForm));
            controladaVista.btnActualizar2.Click += (sender, e) => UpdateData();
            controladaVista.btnBuscar.Click += (sender, e) => searchData();
            controladaVista.btnVolver.Click += (sender, e) => passedMenuForm.controladorMenu.AbrirFormulario(new VistaInicioGestion(passedMenuForm));
            controladaVista.picClientes.Click += (sender, e) => LoadImage();

            dao.Populate(controladaVista);
        }

        //Funcion para que cuando el usuario presione la picturebox abra el explorador de archivos y el usuario suba una imagen al picturebox
        public void LoadImage()
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            DialogResult resultado = dialogo.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                controladaVista.picClientes.Image = Image.FromFile(dialogo.FileName);
                controladaVista.picClientes.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        public void ShowData()
        {
            if (controladaVista.listClientes.SelectedItems.Count > 0)
            {
                ListViewItem seleccionado = controladaVista.listClientes.SelectedItems[0];
                controladaVista.txtId.Text = seleccionado.SubItems[0].Text;
                controladaVista.txtName.Text = seleccionado.SubItems[1].Text;
                //controladaVista.txtContraseña.Text = seleccionado.SubItems[2].Text;
                controladaVista.txtPuntos.Text = seleccionado.SubItems[3].Text;
                controladaVista.txtEmail.Text = seleccionado.SubItems[5].Text;
                //controladaVista.txtLugar.Text = seleccionado.SubItems[6].Text;
            }
            else
            {
                controladaVista.txtId.Text = null;
                controladaVista.txtName.Text = null;
                //controladaVista.txtContraseña.Text = null;
                controladaVista.txtPuntos.Text = null;
                controladaVista.txtEmail.Text = null;
                //controladaVista.txtLugar.Text = null;
            }
        }

        public void InsertData()
        {
            //Se verificara que no haya campos vacios
            if(controladaVista.txtName.Text.Equals("") || controladaVista.txtContraseña.Text.Equals("") || controladaVista.txtPuntos.Text.Equals("") || controladaVista.txtEmail.Text.Equals("") || controladaVista.txtPuntos.Text.Equals(""))
            {
                MessageBox.Show($"Hay Campos vacíos, asegurate de haber llenado todos los campos antes de insertar", "¡CUIDADO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Se ejecutara la funcion insert y populate del dao para actualizar la tabla
                dao.Insert(controladaVista);
                dao.Populate(controladaVista);

            }
        }

        public void UpdateData()
        {
            //Se verificara que no haya campos vacios
            if (controladaVista.txtName.Text.Equals("") || controladaVista.txtContraseña.Text.Equals("") || controladaVista.txtPuntos.Text.Equals("") || controladaVista.txtEmail.Text.Equals("") || controladaVista.txtPuntos.Text.Equals(""))
            {
                MessageBox.Show($"Hay Campos vacíos, asegurate de haber llenado todos los campos antes de actualizar", "¡CUIDADO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Se ejecutara la funcion update y populate del dao para actualizar la tabla
                dao.Update(controladaVista);
                dao.Populate(controladaVista);
            }
        }

        public void deleteData()
        {
            //1 Si existe una fila en la tabla de la vista que el usuario haya seleccionado se ejecutara lo siguiente
            if (controladaVista.listClientes.SelectedItems.Count > 0)
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