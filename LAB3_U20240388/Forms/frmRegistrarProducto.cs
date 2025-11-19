using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAB3_U20240388.Clases;
using LAB3_U20240388.Repositorios;
using System.Drawing;
using System.Globalization;
using System.Configuration;



namespace LAB3_U20240388.Forms
{
    public partial class frmRegistrarProducto : Form
    {
        private readonly ProductosRepository _productosRepository;
        private readonly string _connectionString;

        public frmRegistrarProducto()
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString;
            _productosRepository = new ProductosRepository(_connectionString);


            txtPrecioUnitario.KeyPress += TxtNumericoDecimal_KeyPress;
            txtCantidad.KeyPress += TxtNumericoEntero_KeyPress;
            txtStockMinimo.KeyPress += TxtNumericoEntero_KeyPress;

        }

        private void frmRegistrarProducto_Load(object sender, EventArgs e)
        {
            LimpiarControles();
            CargarProductos();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        //  Click  Boton Agregar


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposObligatorios())
            {
                return;
            }

            try
            {
                decimal precio = decimal.Parse(txtPrecioUnitario.Text, CultureInfo.CurrentCulture);
                int cantidad = int.Parse(txtCantidad.Text);
                int stockMinimo = string.IsNullOrWhiteSpace(txtStockMinimo.Text) ? 0 : int.Parse(txtStockMinimo.Text);

                Productos nuevoProducto = new Productos
                {
                    Nombre = txtNombre.Text.Trim(),
                    Codigo = txtCodigo.Text.Trim(),
                    Categoria = txtCategoria.Text.Trim(),
                    PrecioUnitario = precio,
                    Cantidad = cantidad,
                    StockMinimo = stockMinimo
                };

                _productosRepository.AgregarProducto(nuevoProducto);

                MessageBox.Show("Producto agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarControles();
                CargarProductos();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, verifique que Precio Unitario, Cantidad y Stock Mínimo sean números válidos.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message, "Error en Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Doble Clic en DataGridView
        private void dgvRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //No toma en cuenta el encabezado
            if (e.RowIndex < 0 || e.RowIndex >= dgvRegistro.Rows.Count - 1)
            {
                return;
            }

            DataGridViewRow row = dgvRegistro.Rows[e.RowIndex];

            try
            {

                Productos productoSeleccionado = new Productos
                {

                    IdProducto = Convert.ToInt32(row.Cells["IdProducto"].Value),
                    Nombre = row.Cells["Nombre"].Value.ToString(),
                    Codigo = row.Cells["Codigo"].Value.ToString(),
                    Categoria = row.Cells["Categoria"].Value?.ToString() ?? string.Empty,
                    PrecioUnitario = decimal.Parse(row.Cells["PrecioUnitario"].Value.ToString()),
                    Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value),
                    StockMinimo = Convert.ToInt32(row.Cells["StockMinimo"].Value)
                };

                frmRegistrarProductoCmd formEdicion = new frmRegistrarProductoCmd(productoSeleccionado);


                formEdicion.ShowDialog();


                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del producto para Edicion: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Validaciones

        private void CargarProductos()
        {
            try
            {
                DataTable productos = _productosRepository.ObtenerTodos();
                dgvRegistro.DataSource = productos;
                ResaltarBajoStock();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de productos: " + ex.Message, "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ResaltarBajoStock()
        {
            if (dgvRegistro.Rows.Count == 0 || dgvRegistro.Columns.Count == 0) return;

            if (!dgvRegistro.Columns.Contains("Cantidad") || !dgvRegistro.Columns.Contains("StockMinimo")) return;

            foreach (DataGridViewRow row in dgvRegistro.Rows)
            {
                if (row.IsNewRow) continue;

                if (int.TryParse(row.Cells["Cantidad"].Value?.ToString(), out int cantidad) &&
                    int.TryParse(row.Cells["StockMinimo"].Value?.ToString(), out int stockMinimo))
                {
                    if (cantidad < stockMinimo)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                        row.DefaultCellStyle.SelectionBackColor = Color.Red;
                    }
                    else
                    {

                        row.DefaultCellStyle.BackColor = dgvRegistro.DefaultCellStyle.BackColor;
                        row.DefaultCellStyle.SelectionBackColor = dgvRegistro.DefaultCellStyle.SelectionBackColor;
                    }
                }
            }
        }

        private bool ValidarCamposObligatorios()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioUnitario.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Los campos Nombre, Codigo, Precio Unitario y Cantidad son obligatorios.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }


        private void LimpiarControles()
        {
            txtNombre.Clear();
            txtCodigo.Clear();
            txtCategoria.Clear();
            txtPrecioUnitario.Clear();
            txtCantidad.Clear();
            txtStockMinimo.Clear();
            txtNombre.Focus();
        }


        // Validacion para campos enteros 
        private void TxtNumericoEntero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // validacion para campos decimales
        private void TxtNumericoDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                return;
            }

            string decimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            if (e.KeyChar.ToString() == decimalSeparator)
            {

                if (!((TextBox)sender).Text.Contains(decimalSeparator))
                {
                    e.Handled = false;
                    return;
                }
            }

            e.Handled = true;
        }
    }
}