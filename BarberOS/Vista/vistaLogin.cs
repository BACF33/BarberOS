using System.Data.SqlClient;
using System;
using System.Windows.Forms;
using System.Configuration;
using BarberOS.Vistas;

namespace BarberOS.Vista
{
    public partial class vistaLogin : Form
    {
        private vistaMenu mainForm;

        public vistaLogin(vistaMenu mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        public void login()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT userName FROM tbUser WHERE userName=@userName AND userPass=@userPass", conexion))
                    {
                        cmd.Parameters.AddWithValue("@userName", txtUser.Text);
                        cmd.Parameters.AddWithValue("@userPass", txtPassword.Text);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            MessageBox.Show("Login exitoso");
                            mainForm.AbrirFormulario(new vistaInicioGestion(mainForm));
                        }
                        else
                        {
                            MessageBox.Show("Login fallido");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}