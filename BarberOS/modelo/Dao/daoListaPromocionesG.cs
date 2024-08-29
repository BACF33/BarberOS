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
                    string query = @"
                    SELECT p.promotionId, p.promotionName, p.promotionPrice, p.promotionPower, t.promotionTypeName  
                    FROM promotions p 
                    INNER JOIN promotionTypes t ON p.promotionType = t.promotionTypeId ";


                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        vistaPasada.listPromociones.Items.Clear();

                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["promotionId"].ToString());
                            item.SubItems.Add(reader["promotionName"].ToString());
                            item.SubItems.Add(reader["promotionPrice"].ToString());
                            item.SubItems.Add(reader["promotionTypeName"].ToString());
                            item.SubItems.Add(reader["promotionPower"].ToString());
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

        public void Delete(VistaListaPromocionesG vistaPasada)
        {
            string selectedId = vistaPasada.listPromociones.SelectedItems[0].Text;
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    string sql = "DELETE FROM tbPromociones WHERE promocionId = @toDelete";

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
        }

        public void searchData(string searchingFor, VistaListaPromocionesG vistaPasada)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();

                    //3 Se ejecutara un query donde se seleccionaran toos los datos de la tabla usuarios donde 
                    //el nombre de usuario coincida con el ingresado
                    string sql = @"
                SELECT promotionId, promotionName, promotionPrice, promotionPower, promotionType
                FROM promotions
                WHERE promotionName LIKE @searchingFor";

                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        //4 Como parametro se utilizara el valor ingresado en la barra de busqueda
                        cmd.Parameters.AddWithValue("@searchingFor", "%" + searchingFor + "%");

                        SqlDataReader reader = cmd.ExecuteReader();

                        vistaPasada.listPromociones.Items.Clear();

                        //5 Se anadiran a la tabla del formulario los valores obtenidos con el query
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["promotionId"].ToString());
                            item.SubItems.Add(reader["promotionName"].ToString());
                            item.SubItems.Add(reader["promotionPrice"].ToString());
                            item.SubItems.Add(reader["promotionPower"].ToString());
                            item.SubItems.Add(reader["promotionType"].ToString());
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