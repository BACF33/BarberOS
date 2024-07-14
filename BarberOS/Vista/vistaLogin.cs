using System.Data.SqlClient;
using System;
using System.Windows.Forms;
using System.Configuration;

namespace BarberOS.Vista 
{ 
    public partial class vistaLogin : Form
    {
        public vistaLogin()
        {
            InitializeComponent();
        }

        public void login()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT userName FROM tbUser WHERE userName='" + txtUser.Text + "'AND userPass ='" + txtPassword.Text + "'", conexion))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            MessageBox.Show("Login exitoso");
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
