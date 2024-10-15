﻿using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BarberOS.Modelo.Dao
{
    internal class DaoActualizarRegistro
    {
        string selectedId;
        VistaActualizarRegistro pasadaVista;
        public DaoActualizarRegistro(string selectedId2, VistaActualizarRegistro pasadaVista2)
        {
            selectedId = selectedId2;
            pasadaVista = pasadaVista2;
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM registries WHERE registryId = @selectedId", conexion))
                    {
                        cmd.Parameters.AddWithValue("@selectedId", selectedId);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            pasadaVista.txtNuevoNombre.Text = reader["registryProductName"].ToString();
                            pasadaVista.txtNuevoPrecio.Text = reader["registryProductPrice"].ToString();
                            pasadaVista.txtNuevoTipo.Text = reader["registryPromotionName"].ToString();
                            pasadaVista.txtNuevoPoder.Text = reader["registryPromotionPower"].ToString();
                        }
                        MessageBox.Show("test");
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void update()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE registries SET registryProductName = @registryProductName, registryProductPrice = @registryProductName, registryPromotionName = @registryPromotionName WHERE registryPromotionPower = @registryPromotionName", conexion))
                    {
                        cmd.Parameters.AddWithValue("@registryProductName", pasadaVista.txtNuevoNombre.Text);
                        cmd.Parameters.AddWithValue("@registryPromotionName", pasadaVista.txtNuevoTipo.Text);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
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
    }
}

