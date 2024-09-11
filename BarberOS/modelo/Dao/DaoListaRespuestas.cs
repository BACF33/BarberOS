using BarberOS.Vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberOS.Modelo.Dao
{
    internal class DaoListaRespuestas
    {
        public void insertar(VistaListaRespuestas vistaPasada)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    //Usando la id de la fila seleccionada por el usuaio se eliminara el valor de la base de datos con
                    //el mismo id 
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand(
                        "INSERT INTO answers (answerText, answerUser, answerQuestion) " +
                        "VALUES (@answerText, " +
                        "(SELECT userId FROM users WHERE userName = @answerUser), " +
                        "(SELECT questionId FROM questions WHERE questionText = @answerQuestion))", 
                        conexion))
                    {
                        //Se usara la string selectedId como parametro
                        cmd.Parameters.AddWithValue("@answerText", vistaPasada.txtRespuesta.Text);
                        cmd.Parameters.AddWithValue("@answerUser", vistaPasada.cmbUsuarios.Text);
                        cmd.Parameters.AddWithValue("@answerQuestion", vistaPasada.cmbPreguntas.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.ToString());
            }
        }

        public void Populate(VistaListaRespuestas vistaPasada)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    //Se ejecutara un query donde se obtendran los valores de la base de datos, se usa un inner join 
                    //dado a que userType es una llave foranea
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(
                    "SELECT a.answerId, a.answerText, u.userName, q.questionText " +
                    "FROM answers a " +
                    "INNER JOIN users u ON a.answerUser = u.userId " +
                    "INNER JOIN questions q ON a.answerQuestion = q.questionId", conexion))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        vistaPasada.listRespuestas.Items.Clear();

                        //Se le añade a la lista presente en la vista los valores obtenidos con el query
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["answerId"].ToString());
                            item.SubItems.Add(reader["answerText"].ToString());
                            item.SubItems.Add(reader["userName"].ToString());
                            item.SubItems.Add(reader["questionText"].ToString());
                            vistaPasada.listRespuestas.Items.Add(item);
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.ToString());
            }
        }

        public void Delete(VistaListaRespuestas vistaPasada)
        {
            string selectedId = vistaPasada.listRespuestas.SelectedItems[0].Text;
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    //Usando la id de la fila seleccionada por el usuaio se eliminara el valor de la base de datos con
                    //el mismo id 
                    conexion.Open();
                    string sql = "DELETE FROM questions WHERE answerId = @toDelete";

                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        //Se usara la string selectedId como parametro
                        cmd.Parameters.AddWithValue("@toDelete", selectedId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.ToString());
            }
        }

        public void Update(VistaListaRespuestas vistaPasada)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    //Se ejecutara un query update donde se hara que  valores de la tabla usuarios en la base de datos
                    //sean iguales a los que estan en las textboxes
                    using (SqlCommand cmd = new SqlCommand("" +
                    "UPDATE answers " +
                    "SET answerText = @answerText, " +
                    "    answerQuestion = (SELECT questionText FROM questions WHERE questionId = @selectedQuestionId), " +
                    "    answerUser = (SELECT userName FROM users WHERE userId = @selectedUserId) " +
                    "WHERE answerId = @selectedAnswerId", conexion))
                    {

                        //Los parametros de la query seran los valores obtenidos de los textboxes
                        cmd.Parameters.AddWithValue("@selectedId", vistaPasada.txtId.Text);
                        cmd.Parameters.AddWithValue("@answerText", vistaPasada.txtRespuesta);
                        cmd.Parameters.AddWithValue("@answerQuestion", vistaPasada.cmbPreguntas.Text);
                        cmd.Parameters.AddWithValue("@answerUser", vistaPasada.cmbUsuarios.Text);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.ToString());
            }
        }

        public void PopulateQuestions(VistaListaRespuestas vistaPasada)
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

                        vistaPasada.cmbPreguntas.Items.Clear();

                        while (reader.Read())
                        {
                            vistaPasada.cmbPreguntas.Items.Add(reader["questionText"].ToString());
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

        public void PopulateUsers(VistaListaRespuestas vistaPasada)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT userName FROM users", conexion))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        vistaPasada.cmbUsuarios.Items.Clear();

                        while (reader.Read())
                        {
                            vistaPasada.cmbUsuarios.Items.Add(reader["userName"].ToString());
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
