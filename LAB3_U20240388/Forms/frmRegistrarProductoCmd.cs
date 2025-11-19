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
    public partial class frmRegistrarProductoCmd : Form
    {
        private Productos _productoAEditar;
        private object txtNombre;
        private readonly ProductosRepository _productosRepository;
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString;

        public frmRegistrarProductoCmd()
        {
            InitializeComponent();
            _productosRepository = new ProductosRepository(_connectionString);
            this.Text = "Registrar Nuevo Producto";

        }


        public frmRegistrarProductoCmd(Productos producto) : this()
        {
            _productoAEditar = producto;
            this.Text = "Editar Producto: " + producto.Nombre;


            CargarDatosProducto();
        }
        private void CargarDatosProducto()
        {
            if (_productoAEditar != null)
            {

                txtNombre2.Text = _productoAEditar.Nombre;
                txtCodigo2.Text = _productoAEditar.Codigo;
                txtCategoria2.Text = _productoAEditar.Categoria;
                txtPrecioUnitario2.Text = _productoAEditar.PrecioUnitario.ToString(CultureInfo.CurrentCulture);
                txtCantidad2.Text = _productoAEditar.Cantidad.ToString();
                txtStockMinimo2.Text = _productoAEditar.StockMinimo.ToString();


                txtCodigo2.Enabled = false;
            }
        }
                    private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposObligatorios()) return;

            try
            {

                if (_productoAEditar != null)
                {

                    _productoAEditar.Nombre = txtNombre2.Text.Trim();
                    _productoAEditar.Categoria = txtCategoria2.Text.Trim();
                    _productoAEditar.PrecioUnitario = decimal.Parse(txtPrecioUnitario2.Text, CultureInfo.CurrentCulture);
                    _productoAEditar.Cantidad = int.Parse(txtCantidad2.Text);
                    _productoAEditar.StockMinimo = int.Parse(txtStockMinimo2.Text);


                    _productosRepository.ActualizarProducto(_productoAEditar);

                    MessageBox.Show("Producto actualizado con exiro.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cambios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCamposObligatorios()
        {


            return true;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
            