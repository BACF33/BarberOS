using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BarberOS.Modelo.Dao
{
    internal class DaoReestablecerPreguntas
    {
        public int Restpass(vistaRestablecerPreguntas vistaPasada)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT answerId FROM answers " +
                        "WHERE answerText = @answerText " +
                        "AND answerUser = (SELECT userId FROM users WHERE userName = @answerUser) " +
                        "AND answerQuestion = (SELECT questionId FROM questions WHERE questionText = @answerQuestion)", conexion))
                    {
                        cmd.Parameters.AddWithValue("@answerUser", vistaPasada.txtUser.Text);
                        cmd.Parameters.AddWithValue("@answerQuestion", vistaPasada.cmbQuestion.Text);
                        cmd.Parameters.AddWithValue("@answerText", vistaPasada.txtAnswer.Text);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                            return 1;
                        else
                            return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        public void PopulateQuestions(vistaRestablecerPreguntas vistaPasada)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT questionText FROM questions", conexion))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        vistaPasada.cmbQuestion.Items.Clear();

                        while (reader.Read())
                        {
                            vistaPasada.cmbQuestion.Items.Add(reader["questionText"].ToString());
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
//Test