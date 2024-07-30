using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberOS
{
    public partial class PersonalPanel : UserControl
    {
        public PersonalPanel(string nNombre, string nEspecialidad, string nDisponible)
        {
            InitializeComponent();
            try 
            {
                lblNombre.Text = nNombre;
                lblEspecialidad.Text = nEspecialidad;
                lblDisponible.Text = nDisponible;
            } 
            catch 
            { 

            }
        }
    }
}
