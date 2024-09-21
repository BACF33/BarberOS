using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;

namespace BarberOS.Controlador
{
    internal class ControlConfigServidor
    {
        VistaConfigServidor vistaControlada;
        public ControlConfigServidor(VistaConfigServidor vistaPasada, vistaMenu menuPasado) 
        {
            vistaControlada = vistaPasada;
            vistaPasada.btnActualizar.Click += (sender, e) => btnUpdateConnectionString_Click();
        }

        private void btnUpdateConnectionString_Click()
        {

            string server = vistaControlada.txtServer.Text;
            string database = vistaControlada.txtDatabase.Text;
            string userId = vistaControlada.txtUser.Text;
            string password = vistaControlada.txtPassword.Text;


            string newConnectionString = $"Data Source={server};Initial Catalog={database};User ID={userId};Password={password};";


            UpdateConnectionString("cnn", newConnectionString);

        }

        private void UpdateConnectionString(string name, string newConnectionString)
        {

            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)configFile.GetSection("connectionStrings");


                connectionStringsSection.ConnectionStrings[name].ConnectionString = newConnectionString;
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("connectionStrings");
        }
    }
    }
