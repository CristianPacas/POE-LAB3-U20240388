using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAB3_U20240388.Repositorios;
using LAB3_U20240388.Clases;
using System.Configuration;

namespace LAB3_U20240388.Forms
{
    public partial class frmSignUp : Form
    {
        private readonly UsuariosRepository _usuariosRepository;

        public frmSignUp(UsuariosRepository usuariosRepository)
        {
            InitializeComponent();
            _usuariosRepository = usuariosRepository;


            txtContraseña2.PasswordChar = '*';
            txtConfirmarContraseña.PasswordChar = '*';
        }

        public frmSignUp()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmSingUp_Load(object sender, EventArgs e)
        {

        }
        // Agregar Usuario

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtContraseña2.Text;
            string claveConfirmacion = txtConfirmarContraseña.Text;


            //Validaciones de campos
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(clave) || string.IsNullOrWhiteSpace(claveConfirmacion))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que coincidan las contraseñas
            if (clave != claveConfirmacion)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, verifique.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña2.Clear();
                txtConfirmarContraseña.Clear();
                txtContraseña2.Focus();
                return;
            }


            // validar espacios
            if (usuario.Contains(" ") || clave.Contains(" "))
            {
                MessageBox.Show("El usuario y la contraseña no pueden contener espacios.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                _usuariosRepository.AgregarUsuario(usuario, clave);

                MessageBox.Show("Usuario **" + usuario + "** registrado con éxito.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

             // Abrir el formulario de Login
                frmLogin loginForm = new frmLogin();
                loginForm.Show();

             // Ocultar el formulario de registro
                this.Hide();   // o this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al registrar el usuario. Detalle: " + ex.Message, "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);

  

            }
        }

    // Cancelar 

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {

        }
    }
    }

