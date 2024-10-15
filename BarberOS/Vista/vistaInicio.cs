using BarberOS.Controlador;
using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberOS.Vistas
{
    public partial class VistaInicio : Form
    {
        //Este es un constructor, lo que esta dentro de el se ejecutara cuando se cree el formulario
        public VistaInicio(vistaMenu menuForm)
        {
            InitializeComponent();
            //Como todos los formularios se creara un archivo de codigo "controlador" para controlar todos los eventos en el formulario
            //como cuando el usuario presione un boton, al crear el controlador se le pasara a este la vista como referencia (no copia) para que esten conectados
            ControlInicio controladorInicio = new ControlInicio(this, menuForm);
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

        private void VistaInicio_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //Cuando se presione el boton "documentacion" se abrira el archivo pdf llamado Manual ubicado dentro de la carpeta del sistema
        private void btnDocumentacion_Click(object sender, EventArgs e)
        {
            try
            {
                string relativePath = @"Manual.pdf";

                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

                Process.Start(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBarberos_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
