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

            //Cuando se abra este formulario se ejecutara la funcion obtener del dao
            daoThis.Obtener(vistaControlada);

            //Cuando se presione el boton agregar se ejecutara insert
            vistaPasada.btnAgregar.Click += (sender, e) => Insert();
            //Cuando se presione el boton agregar se ejecutara update
            vistaControlada.btnActualizar2.Click += (sender, e) => Update();
            vistaControlada.picProducto.Click += (sender, e) => LoadImage();
            vistaControlada.listEmpleados.SelectedIndexChanged += (sender, e) => ShowData();
            vistaControlada.btnBorrar.Click += (sender, e) => Delete();
            //Cuando se presione el boton volver se regresara a VistaInicioGestion
            vistaControlada.btnVolver.Click += (sender, e) => menuPasado.controladorMenu.AbrirFormulario(new VistaInicioGestion(menuPasado));
        }

        //Funcion para que cuando el usuario presione la picturebox abra el explorador de archivos y el usuario suba una imagen al picturebox
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

        //Se ejecutara la funcion insert del dao y obtener para actualizar la tabla
        public void Insert()
        {
            daoThis.Insert(vistaControlada);
            daoThis.Obtener(vistaControlada);
        }

        //Se ejecutara la funcion delete del dao y obtener para actualizar la tabla
        public void Delete() 
        {
            daoThis.Borrar(vistaControlada);
            daoThis.Obtener(vistaControlada);
        }

        //Se ejecutara la funcion update del dao y obtener para actualizar la tabla
        public void Update()
        {
            daoThis.Update(vistaControlada);
            daoThis.Obtener(vistaControlada);
        }

        //Esto se ejecuta cuando el usuario presione una fila, los valores de la fila se aplicaran a los texboxes del panel izquierdo
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
