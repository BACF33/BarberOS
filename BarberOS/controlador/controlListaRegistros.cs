using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System.Windows.Forms;

namespace BarberOS.Controlador
{
    internal class controlListaRegistros
    {
        vistaListaRegistros controladaVista;
        daoListaRegistrosG daoThis;
        public controlListaRegistros(vistaListaRegistros pasadaVista, vistaMenu passedMenu) 
        {
            controladaVista = pasadaVista;
            daoThis = new daoListaRegistrosG(controladaVista);
            controladaVista.btnActualizarRegistros.Click += (sender, e) => daoThis.getData();
            controladaVista.btnBorrarEmpleados.Click += (sender, e) => deleteData();
            controladaVista.btnUpdate2.Click += (sender, e) => updateData();
            controladaVista.btnVolver.Click += (sender, e) => passedMenu.controladorMenu.AbrirFormulario(new vistaInicioGestion(passedMenu));
        }
        public void deleteData() 
        {
            if (controladaVista.listRegistros.SelectedItems.Count > 0)
                daoThis.deleteData(controladaVista);
        }

        public void updateData()
        {
            vistaActualizarRegistro actualizar;
            if (controladaVista.listRegistros.SelectedItems.Count > 0)
            {
                string selectedId = controladaVista.listRegistros.SelectedItems[0].Text;
                actualizar = new vistaActualizarRegistro(selectedId);
                actualizar.Show();
            }
        }
    }
}