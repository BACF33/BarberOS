using BarberOS.Vista;
using System;
using System.Windows.Forms;

namespace BarberOS
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //1 Este sera el primer formulario que se ejecutara al abrir el programa
            Application.Run(new vistaMenu());
        }
    }
}
