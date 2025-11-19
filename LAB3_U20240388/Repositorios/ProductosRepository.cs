using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB3_U20240388.Clases;
using System.Data.SqlClient;
using System.Data;


namespace LAB3_U20240388.Repositorios
{
    public class ProductosRepository
    {

        private readonly string _connectionString;

        public ProductosRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public ProductosRepository()
        {
        }

        //Agregar
        public void AgregarProducto(Productos producto)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
                    INSERT INTO Productos (Nombre, Codigo, Categoria, PrecioUnitario, Cantidad, StockMinimo)
                    VALUES (@Nombre, @Codigo, @Categoria, @PrecioUnitario, @Cantidad, @StockMinimo)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@Codigo", producto.Codigo);
                cmd.Parameters.AddWithValue("@Categoria", producto.Categoria ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@PrecioUnitario", producto.PrecioUnitario);
                cmd.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                cmd.Parameters.AddWithValue("@StockMinimo", producto.StockMinimo);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601)
                    {
                        throw new Exception("El código del producto ya existe. Por favor, use uno diferente.", ex);
                    }
                    throw new Exception("Error al agregar el producto a la base de datos: " + ex.Message, ex);
                }
            }
        }

        //Actualizar
        public void ActualizarProducto(Productos producto)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
            UPDATE Productos SET 
                Nombre = @Nombre, 
                Categoria = @Categoria, 
                PrecioUnitario = @PrecioUnitario, 
                Cantidad = @Cantidad, 
                StockMinimo = @StockMinimo
            WHERE IdProducto = @IdProducto";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@IdProducto", producto.IdProducto);
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@Categoria", producto.Categoria ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@PrecioUnitario", producto.PrecioUnitario);
                cmd.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                cmd.Parameters.AddWithValue("@StockMinimo", producto.StockMinimo);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error al actualizar el producto: " + ex.Message, ex);
                }
            }
        }
        //Mostrar todos
        public DataTable ObtenerTodos()
        {
            DataTable dtProductos = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT IdProducto, Nombre, Codigo, Categoria, PrecioUnitario, Cantidad, StockMinimo FROM Productos";
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtProductos);
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error al obtener la lista de productos desde la base de datos: " + ex.Message, ex);
                }
            }
            return dtProductos;
        }
    }
}