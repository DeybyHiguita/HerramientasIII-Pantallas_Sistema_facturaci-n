using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturación
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Loop principal para manejar login y formulario principal
            bool continueApplication = true;
            
            while (continueApplication)
            {
                // Mostrar formulario de login
                using (var loginForm = new frmLogin())
                {
                    var loginResult = loginForm.ShowDialog();
                    
                    if (loginResult == DialogResult.OK)
                    {
                        // Si el login es exitoso, abrir formulario principal
                        using (var principalForm = new frmPrincipal())
                        {
                            var principalResult = principalForm.ShowDialog();
                            
                            // Si el formulario principal retorna Cancel, volver al login
                            // Si retorna cualquier otra cosa, salir de la aplicación
                            if (principalResult != DialogResult.Cancel)
                            {
                                continueApplication = false;
                            }
                        }
                    }
                    else
                    {
                        // Si se cancela el login, salir de la aplicación
                        continueApplication = false;
                    }
                }
            }
        }
    }
}
