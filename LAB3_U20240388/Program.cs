using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAB3_U20240388.Forms;
using LAB3_U20240388.Repositorios;
using System.Configuration;

//CRISTIAN DANIEL PACAS GUEVARA U20240388
//AUTPEVALUACION: 10

namespace LAB3_U20240388
{
    internal static class Program
    {
      
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string connectionString = ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString;

            var repo = new UsuariosRepository();  // <-- crea repositorio
            Application.Run(new frmSignUp(repo)); // <-- pásalo al formulario
        }
    }
}
