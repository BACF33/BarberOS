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
            Application.Run(new vistaMenu());
        }
    }
}
