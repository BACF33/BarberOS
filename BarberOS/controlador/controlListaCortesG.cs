﻿using BarberOS.Modelo.Dao;
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
            controladaVista.btnActualizar2.Click += (sender, e) => UpdateData();
            controladaVista.btnBuscar.Click += (sender, e) => searchData();
            controladaVista.btnVolver.Click += (sender, e) => passedMenuForm.controladorMenu.AbrirFormulario(new VistaInicioGestion(passedMenuForm));

            controladaVista.picProducto.Click += (sender, e) => LoadImage();
            dao.Populate(controladaVista);
        }

        //Funcion para que cuando el usuario presione la picturebox abra el explorador de archivos y el usuario suba una imagen al picturebox
        public void LoadImage()
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            DialogResult resultado = dialogo.ShowDialog();

            if (resultado == DialogResult.OK) 
            {
                controladaVista.picProducto.Image = Image.FromFile(dialogo.FileName);
                controladaVista.picProducto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        //Esto se ejecuta cuando el usuario presione una fila, los valores de la fila se aplicaran a los texboxes del panel izquierdo
        public void ShowData()
        {
            if (controladaVista.listCortes.SelectedItems.Count > 0)
            {
                ListViewItem seleccionado = controladaVista.listCortes.SelectedItems[0];
                controladaVista.txtId.Text = seleccionado.SubItems[0].Text;
                controladaVista.txtNombre.Text = seleccionado.SubItems[1].Text;
                controladaVista.txtPrecio.Text = seleccionado.SubItems[2].Text;
                controladaVista.cmbTipo.Text = seleccionado.SubItems[3].Text;
            }
            else
            {
                controladaVista.txtId.Text = null;
                controladaVista.txtNombre.Text = null;
                controladaVista.txtPrecio.Text = null;
                controladaVista.cmbTipo.Text = null;
            }
        }

        //Se ejecutara la funcion insert del dao y obtener para actualizar la tabla
        public void InsertData()
        {
            if (controladaVista.txtNombre.Text.Equals("") || controladaVista.txtPrecio.Text.Equals("") || controladaVista.cmbTipo.Text.Equals(""))
            {
                MessageBox.Show($"Hay Campos vacíos, asegurate de haber llenado todos los campos antes de insertar", "¡CUIDADO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (controladaVista.txtNombre.Text.Equals("") || controladaVista.txtPrecio.Text.Equals("") || controladaVista.cmbTipo.Text.Equals(""))
            {
                MessageBox.Show($"Hay campos vacíos, asegurate de haber llenado todos los campos antes de actualizar", "¡CUIDADO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (controladaVista.listCortes.SelectedItems.Count > 0)
                //2 Se ejecutara la funcion delete del dao
                dao.Delete(controladaVista);

            dao.Populate(controladaVista);
        }

        public void searchData()
        {
            //1 Se obtendran los datos que el usuario ingreso en la barra de busquedas
            string searchingFor = controladaVista.txtSearchingFor.Text;
            //2 Se ejecutara la funcion searchData del dao
            dao.searchData(searchingFor, controladaVista);
        }
    }
}