using BarberOS.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberOS.Vista
{
    public partial class vistaListaPreguntas : Form
    {
        //Este es un constructor, lo que esta dentro de el se ejecutara cuando se cree el formulario
        public vistaListaPreguntas(vistaMenu menuPasado)
        {
            InitializeComponent();
            //Como todos los formularios se creara un archivo de codigo "controlador" para controlar todos los eventos en el formulario
            //como cuando el usuario presione un boton, al crear el controlador se le pasara a este la vista como referencia (no copia) para que esten conectados
            new ControlListaPregunas(this, menuPasado);
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
