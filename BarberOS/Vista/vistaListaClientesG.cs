using BarberOS.Controlador;
using System.Windows.Forms;

namespace BarberOS.Vista
{
    public partial class VistaListaClientesG : Form
    {
        public VistaListaClientesG(vistaMenu passedMenu)
        {
            InitializeComponent();
            //1 El formulario creara su controlador
            ControlListaClientesG controladorVista = new ControlListaClientesG(this, passedMenu);
            this.KeyPreview = true;
            this.KeyDown += Form_KeyDown;
        }
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void btnAProms_Click(object sender, System.EventArgs e)
        {

        }

        private void btnBorrarClientes_Click(object sender, System.EventArgs e)
        {

        }

        private void btnActualizarClientes2_Click(object sender, System.EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {

        }

        private void txtSearchingFor_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void VistaListaClientesG_Load(object sender, System.EventArgs e)
        {

        }

        private void listClientes_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }
    }
}
