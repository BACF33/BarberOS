using System.Windows.Forms;
using BarberOS.Controlador;

namespace BarberOS.Vista 
{ 
    public partial class vistaLogin : Form
    {
        public vistaLogin()
        {
            InitializeComponent();
            //Crear un objeto de tipo controladorLogin llamado control, le pasamos un objeto de la clase vista (en este mismo archivo) como argumento ya controlara la vista, cuyos datos son de InitializeComponent()
            controladorLogin control = new controladorLogin(this);
        }
    }
}
