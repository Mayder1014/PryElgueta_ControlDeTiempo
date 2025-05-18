using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryElgueta_ControlDeTiempo
{
    internal class clsConexionBBDD
    {
        string cadenaConexion = "Server=localhost;Database=Tiempo;Trusted_Connection=True;";

        SqlConnection conexionBaseDatos;

        SqlCommand comandoBaseDatos;


        public void guardarCoordenadas(string coordenadasEntrantes)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);
                conexionBaseDatos.Open();

                //Se consulta por el contador de las coordenadas entrantes:
                string checkQuery = "SELECT Contador FROM CoordenadasXY WHERE Coordenadas = @Coords";
                comandoBaseDatos = new SqlCommand(checkQuery, conexionBaseDatos);
                comandoBaseDatos.Parameters.AddWithValue("@Coords", coordenadasEntrantes);

                int existe = (int)comandoBaseDatos.ExecuteScalar(); //Si devuelve 0, es pq no se encontró las coordenadas (NO EXISTE).

                if (existe > 0) //Aumenta el contador de las coordenadas encontrada.
                {
                    string updateQuery = "UPDATE CoordenadasXY SET Contador = Contador + 1 WHERE Coordenadas = @Coords";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conexionBaseDatos);
                    updateCmd.Parameters.AddWithValue("@Coords", coordenadasEntrantes);
                    updateCmd.ExecuteNonQuery();
                }
                else //Agrega las nuevas coordenadas a la Base de Datos.
                {
                    string insertQuery = "INSERT INTO CoordenadasXY (Coordenadas) VALUES (@Coords)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conexionBaseDatos);
                    insertCmd.Parameters.AddWithValue("@Coords", coordenadasEntrantes);
                    insertCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexionBaseDatos.Close();
            }
        }

        public void mostrarCoordenadas(ListBox lst)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);
                conexionBaseDatos.Open();

                int i = 1; //Variable local, usada para contar la cantidad de coordenadas encontradas.

                //Se consulta por las 20 coordenadas de mayor contador.
                string query = @"SELECT TOP 20 Coordenadas, Contador 
                        FROM CoordenadasXY 
                        ORDER BY Contador DESC";

                comandoBaseDatos = new SqlCommand(query, conexionBaseDatos);
                SqlDataReader reader = comandoBaseDatos.ExecuteReader();

                while (reader.Read()) //La primer columna del registro leído contiene las coordenadas, la segunda el contador.
                {
                    string coords = reader.GetString(0);
                    int veces = reader.GetInt32(1);

                    string item = $"{i}. Coordenadas: {coords} - Veces: {veces}";
                    lst.Items.Add(item);
                    i++;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexionBaseDatos.Close();
            }
        }



    }
}
