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
    internal class ControlListaPregunas
    {
        DaoListaPreguntas daoThis = new DaoListaPreguntas();
        vistaListaPreguntas vistaControlada;
        public ControlListaPregunas(vistaListaPreguntas vistaPasada, vistaMenu menuPasado)
        {
            //Se ejecuta la funcion populate del dao para obtener la tabla
            daoThis.Populate(vistaPasada);
            vistaControlada = vistaPasada;
            //Cuando se presionen los botones marcados en la izquierda se ejecutaran las funciones a la derech
            //por ejemplo si se presiona agregar se ejecutara la funcion insertData
            vistaPasada.btnAgregar.Click += (sender, e) => Insertar();
            vistaPasada.btnBorrar.Click += (sender, e) => Borrar();
            vistaPasada.btnActualizar.Click += (sender, e) => Actualizar();
            vistaPasada.btnBuscar.Click += (sender, e) => Search();
            vistaControlada.btnARespuestas.Click += (sender, e) => menuPasado.controladorMenu.AbrirFormulario(new VistaListaRespuestas(menuPasado));
            vistaControlada.btnVolver.Click += (sender, e) => menuPasado.controladorMenu.AbrirFormulario(new VistaInicioGestion(menuPasado));

            vistaControlada.listPreguntas.SelectedIndexChanged += (sender, e) => ShowData();
        }

        //Se ejecutara la funcion insert del dao y obtener para actualizar la tabla
        public void Insertar()
        {
            if (vistaControlada.txtPregunta.Text.Equals(""))
            {
                MessageBox.Show("Hay campos vacios");
            }
            else
            {
                daoThis.insertar(vistaControlada);
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
            if (vistaControlada.listPreguntas.SelectedItems.Count > 0)
            {
                ListViewItem seleccionado = vistaControlada.listPreguntas.SelectedItems[0];
                vistaControlada.txtId.Text = seleccionado.SubItems[0].Text;
                vistaControlada.txtPregunta.Text = seleccionado.SubItems[1].Text;
            }
            else
            {
                vistaControlada.txtId.Text = null;
                vistaControlada.txtPregunta.Text = null;
            }
        }

        //Se ejecutara la funcion update del dao y obtener para actualizar la tabla
        public void Actualizar()
        {
            if (vistaControlada.txtPregunta.Text.Equals(""))
            {
                MessageBox.Show("Hay campos vacios");
            }
            else
            {
                daoThis.Update(vistaControlada);
                daoThis.Populate(vistaControlada);
            }
        }

        public void Search()
        {
            //1 Se obtendran los datos que el usuario ingreso en la barra de busqueda
            string searchingFor = vistaControlada.txtSearchingFor.Text;
            //2 Se ejecutara la funcion searchData del dao
            daoThis.searchData(searchingFor, vistaControlada);
        }

    }
}
