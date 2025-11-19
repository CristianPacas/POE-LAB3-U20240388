using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB3_U20240388.Clases;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Configuration;


namespace LAB3_U20240388.Repositorios
{
    public class UsuariosRepository
    {
        private readonly string _connectionString;

        public UsuariosRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public UsuariosRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString;
        }

        public Usuarios ObtenerUsuarioPorNombre(string nombreUsuario)
        {
            Usuarios usuario = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT IdUsuario, Usuario, PasswordHash FROM Usuarios WHERE Usuario = @Usuario";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Usuario", nombreUsuario);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        usuario = new Usuarios
                        {
                            IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                            Usuario = reader["Usuario"].ToString(),
                            PasswordHash = reader["PasswordHash"].ToString()
                        };
                    }
                }
                catch (SqlException ex)
                {

                    System.Windows.Forms.MessageBox.Show("Error de SQL: " + ex.Message, "Error de Base de Datos", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);

                    throw;
                }

            }
            return usuario;
        }

        public void AgregarUsuario(string nombreUsuario, string clave)
        {

            string passwordHash = Encriptador.EncriptarClave(clave);

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {

                string query = "INSERT INTO Usuarios (Usuario, PasswordHash) VALUES (@Usuario, @PasswordHash)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Usuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);

                try
                {
                    conn.Open();

                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {

                    if (ex.Number == 2627 || ex.Number == 2601)
                    {
                        throw new Exception("El nombre de usuario '" + nombreUsuario + "' ya existe.", ex);
                    }
                    throw new Exception("Error al intentar agregar el usuario: " + ex.Message, ex);
                }
            }
        }
    }
}