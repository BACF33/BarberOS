﻿using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberOS.Controlador
{
    internal class controlListaPersonalG
    {
        private vistaMenu menuForm;
        private vistaListaPersonalG controladaVista;

        public controlListaPersonalG(vistaListaPersonalG vistaPasada ,vistaMenu passedMenuForm)
        {
            controladaVista = vistaPasada;
            menuForm = passedMenuForm;
            controladaVista.btnActualizarEmpleados.Click += (sender, e) => getData();
            controladaVista.btnBorrarEmpleados.Click += (sender, e) => deleteData();
            controladaVista.btnACortes.Click += (sender, e) => passedMenuForm.controladorMenu.AbrirFormulario(new vistaListaCortesG(passedMenuForm));
            getData();
        }

        public void getData()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM tbUser", conexion))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        controladaVista.listEmpleados.Items.Clear();

                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["userId"].ToString());
                            item.SubItems.Add(reader["userName"].ToString());
                            item.SubItems.Add(reader["userPass"].ToString());
                            item.SubItems.Add(reader["userRealName"].ToString());
                            item.SubItems.Add(reader["userRole"].ToString());
                            item.SubItems.Add(reader["userId"].ToString());
                            controladaVista.listEmpleados.Items.Add(item);
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void deleteData()
        {
            if (controladaVista.listEmpleados.SelectedItems.Count > 0)
            {
                string selectedId = controladaVista.listEmpleados.SelectedItems[0].Text;
                try
                {
                    string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                    using (SqlConnection conexion = new SqlConnection(cnn))
                    {
                        conexion.Open();
                        string sql = "DELETE FROM tbUser WHERE userId = @toDelete";

                        using (SqlCommand cmd = new SqlCommand(sql, conexion))
                        {
                            cmd.Parameters.AddWithValue("@toDelete", selectedId);
                            int rowsAffected = cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                getData();
            }
        }
    }
}

