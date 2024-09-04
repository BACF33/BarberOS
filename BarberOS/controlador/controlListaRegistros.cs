using BarberOS.Modelo.Dao;
using BarberOS.Vista;
using System.Windows.Forms;

namespace BarberOS.Controlador
{
    internal class ControlListaRegistros
    {
        VistaListaRegistros controladaVista;
        DaoListaRegistrosG daoThis;
        public ControlListaRegistros(VistaListaRegistros pasadaVista, vistaMenu passedMenu) 
        {
            controladaVista = pasadaVista;
            daoThis = new DaoListaRegistrosG(controladaVista);
            controladaVista.a.Click += (sender, e) => daoThis.getData();
            controladaVista.s.Click += (sender, e) => deleteData();
            controladaVista.d.Click += (sender, e) => updateData();
            controladaVista.btnVolver.Click += (sender, e) => passedMenu.controladorMenu.AbrirFormulario(new VistaInicioGestion(passedMenu));
            controladaVista.btnSearch.Click += (sender, e) => searchData();
        }
        public void deleteData() 
        {
            if (controladaVista.listRegistros.SelectedItems.Count > 0)
                daoThis.deleteData(controladaVista);
        }

        public void updateData()
        {
            VistaActualizarRegistro actualizar;
            if (controladaVista.listRegistros.SelectedItems.Count > 0)
            {
                string selectedId = controladaVista.listRegistros.SelectedItems[0].Text;
                actualizar = new VistaActualizarRegistro(selectedId);
                actualizar.Show();
            }
        }

        public void searchData()
        {
            string searchingFor = controladaVista.txtSearchingFor.Text;
            daoThis.searchData(searchingFor, controladaVista);
        }

    }
}