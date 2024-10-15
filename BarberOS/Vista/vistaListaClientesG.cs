using BarberOS.Controlador;
using System.Windows.Forms;

namespace BarberOS.Vista
{
    public partial class VistaListaClientesG : Form
    {
        //Este es un constructor, lo que esta dentro de el se ejecutara cuando se cree el formulario
        public VistaListaClientesG(vistaMenu passedMenu)
        {
            InitializeComponent();
            //Como todos los formularios se creara un archivo de codigo "controlador" para controlar todos los eventos en el formulario
            //como cuando el usuario presione un boton, al crear el controlador se le pasara a este la vista como referencia (no copia) para que esten conectados
            ControlListaClientesG controladorVista = new ControlListaClientesG(this, passedMenu);
            this.KeyPreview = true;
            this.KeyDown += Form_KeyDown;
        }

        //Codigo que anulara los comandos ctrC y ctrlV que puedan suceder en este formulario
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V))
            {
                e.SuppressKeyPress = true;
            }
        }

        //Codigo que en ciertos textboxes anula la insercion de caracteres exceptuando a caracteres numericos
        private void SoloPuntos(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Codigo que en ciertos textboxes anula la insercion de caracteres exceptuando a letras
        private void SoloLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
