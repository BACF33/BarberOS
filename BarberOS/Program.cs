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
            //En esta linea se declara que el primer formulario que abrira el programa sera el de vistaMenu, por lo que creara uno
            Application.Run(new vistaMenu());
        }
    }
}