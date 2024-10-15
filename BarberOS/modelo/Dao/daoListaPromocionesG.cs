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
    internal class DaoListaPromocionesG
    {
        public void Populate(VistaListaPromocionesG vistaPasada)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    //Se ejecutara un query donde se obtendran los valores de la base de datos, se usa un inner join 
                    //dado a que userType es una llave foranea
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT  p.promotionId, p.promotionName, p.promotionPrice, p.promotionPower,  t.promotionTypeName " +
                        "FROM promotions p " +
                        "INNER JOIN promotionTypes t ON promotionType = t.promotionTypeId ", conexion))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        vistaPasada.listPromociones.Items.Clear();

                        //Se le añade a la lista presente en la vista los valores obtenidos con el query
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["promotionId"].ToString());
                            item.SubItems.Add(reader["promotionName"].ToString());
                            item.SubItems.Add(reader["promotionPrice"].ToString());
                            item.SubItems.Add(reader["promotionPower"].ToString());
                            item.SubItems.Add(reader["promotionTypeName"].ToString());
                            vistaPasada.listPromociones.Items.Add(item);
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

        public void Insert(VistaListaPromocionesG vistaPasada)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    //Usando la id de la fila seleccionada por el usuaio se eliminara el valor de la base de datos con
                    //el mismo id 
                    conexion.Open();
                    string query = @"
                    INSERT INTO promotions (promotionName, promotionPrice, promotionPower, promotionType )
                    VALUES (
                    @Name, 
                    @Price, 
                    @Power, 
                    (SELECT promotionTypeId FROM promotionTypes WHERE promotionTypeName = @Type)
                    )";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        //Se usara la string selectedId como parametro
                        cmd.Parameters.AddWithValue("@Name", vistaPasada.txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Price", vistaPasada.txtPrecio.Text);
                        cmd.Parameters.AddWithValue("@Power", vistaPasada.txtPoder.Text);
                        cmd.Parameters.AddWithValue("@Type", vistaPasada.cmbTipo.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Update(VistaListaPromocionesG vistaPasada)
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
                        "UPDATE promotions SET " +
                        "promotionName = @Name, " +
                        "promotionPrice = @Price, " +
                        "promotionPower = @Power, " +
                        "promotionType = (SELECT promotionTypeId FROM promotionTypes WHERE promotionTypeName = @Type)" +
                        "WHERE promotionId = @selectedId", conexion))
                    {
                        //Los parametros de la query seran los valores obtenidos de los textboxes
                        cmd.Parameters.AddWithValue("@selectedId", vistaPasada.txtId.Text);
                        cmd.Parameters.AddWithValue("@Name", vistaPasada.txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Price", vistaPasada.txtPrecio.Text);
                        cmd.Parameters.AddWithValue("@Power", vistaPasada.txtPoder.Text);
                        cmd.Parameters.AddWithValue("@Type", vistaPasada.cmbTipo.Text);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Delete(VistaListaPromocionesG vistaPasada)
        {
            string selectedId = vistaPasada.listPromociones.SelectedItems[0].Text;
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    //Usando la id de la fila seleccionada por el usuaio se eliminara el valor de la base de datos con
                    //el mismo id 
                    conexion.Open();
                    string sql = "DELETE FROM promotions WHERE promotionId = @toDelete";

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
                MessageBox.Show(ex.ToString());
            }
        }

        public void searchData(string searchingFor, VistaListaPromocionesG vistaPasada)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();

                    // Query to select data from promotions with a matching promotion type name
                    string sql = "SELECT p.promotionId, p.promotionName, p.promotionPrice, p.promotionPower, t.promotionTypeName " +
                                 "FROM promotions p " +
                                 "INNER JOIN promotionTypes t ON p.promotionType = t.promotionTypeId " +
                                 "WHERE promotionName LIKE @searchingFor";

                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@searchingFor", "%" + searchingFor + "%");

                        SqlDataReader reader = cmd.ExecuteReader();

                        vistaPasada.listPromociones.Items.Clear();

                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["promotionId"].ToString());
                            item.SubItems.Add(reader["promotionName"].ToString());
                            item.SubItems.Add(reader["promotionPrice"].ToString());
                            item.SubItems.Add(reader["promotionPower"].ToString());
                            item.SubItems.Add(reader["promotionTypeName"].ToString());
                            vistaPasada.listPromociones.Items.Add(item);
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

//CREATE DATABASE BarberOS2
//GO

//USE BarberOS2
//--Productos

//CREATE TABLE productTypes 
//(
//productTypeId int identity(1,1) primary key,
//productTypeName varchar(50) not null
//)
//GO

//CREATE TABLE products
//(
//productId int identity(1,1) primary key,
//productName varchar(50) not null,
//productPrice int not null,
//productType int foreign key references productTypes(productTypeId)
//)

//--Usuarios

//CREATE TABLE userRoles
//(
//roleId int primary key identity(1,1),
//roleName varchar(50) not null
//)

//CREATE TABLE users
//(
//userId int primary key identity(1,1),
//userName varchar(50) not null,
//userPoints int not null,
//userPassword varchar(500),
//userRole int foreign key references userRoles(roleId)
//user
//)

//--Promociones 

//CREATE TABLE promotionTypes
//(
//promotionTypeId int primary key identity(1,1),
//promotionTypeName varchar(50) not null
//)

//CREATE TABLE promotions
//(
//promotionId int primary key identity(1,1),
//promotionName varchar(50) not null,
//promotionPrice int not null,
//promotionPower int not null,
//promotionType int foreign key references promotionTypes(promotionTypeId)
//)

//--Registro

//CREATE TABLE registries
//(
//registryId int primary key identity(1,1),

//registryProductName int foreign key references products(productId),
//registryProductPrice int foreign key references products(productId),

//registryPromotionName int foreign key references promotions(promotionId),
//registryPromotionPower int foreign key references promotions(promotionId),

//registryTotal int 
//)