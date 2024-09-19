using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberOS.Controlador
{
    internal class ControlInventario
    {
        vistaMenu menuControlado;
        VistaInventario vistaControlada;
        DaoInventario daoThis = new DaoInventario();

        public ControlInventario(vistaMenu menuPasado, VistaInventario vistaPasada) 
        {
            menuControlado = menuPasado;
            vistaControlada = vistaPasada;

            daoThis.Obtener(vistaControlada);

            vistaPasada.btnAgregar.Click += (sender, e) => Insert();
            vistaControlada.btnActualizar2.Click += (sender, e) => Update();
            vistaControlada.picProducto.Click += (sender, e) => LoadImage();
            vistaControlada.listEmpleados.SelectedIndexChanged += (sender, e) => ShowData();
            vistaControlada.btnBorrar.Click += (sender, e) => Delete();
            vistaControlada.btnVolver.Click += (sender, e) => menuPasado.controladorMenu.AbrirFormulario(new VistaInicioGestion(menuPasado));
        }

        public void LoadImage()
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            DialogResult resultado = dialogo.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                vistaControlada.picProducto.Image = Image.FromFile(dialogo.FileName);
                vistaControlada.picProducto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        public void Insert()
        {
            daoThis.Insert(vistaControlada);
            daoThis.Obtener(vistaControlada);
        }

        public void Delete() 
        {
            daoThis.Borrar(vistaControlada);
            daoThis.Obtener(vistaControlada);
        }

        public void Update()
        {
            daoThis.Update(vistaControlada);
            daoThis.Obtener(vistaControlada);
        }

        public void ShowData()
        {
            if (vistaControlada.listEmpleados.SelectedItems.Count > 0)
            {
                ListViewItem seleccionado = vistaControlada.listEmpleados.SelectedItems[0];
                vistaControlada.txtId.Text = seleccionado.SubItems[0].Text;
                vistaControlada.txtName.Text = seleccionado.SubItems[1].Text;
                vistaControlada.txtPrice.Text = seleccionado.SubItems[2].Text;
                vistaControlada.txtQuant.Text = seleccionado.SubItems[3].Text;
            }
            else
            {
                vistaControlada.txtId.Text = null;
                vistaControlada.txtName.Text = null;
                vistaControlada.txtPrice.Text = null;
                vistaControlada.txtQuant.Text = null;
            }
        }
    }
}
