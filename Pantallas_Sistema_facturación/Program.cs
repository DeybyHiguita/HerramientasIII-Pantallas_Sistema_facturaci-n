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
            
            // Bucle principal para manejar login y formulario principal
            bool ContinuarAplicacion = true;
            
            while (ContinuarAplicacion)
            {
                // Mostrar formulario de login
                using (var FormularioLogin = new frmLogin())
                {
                    var ResultadoLogin = FormularioLogin.ShowDialog();
                    
                    if (ResultadoLogin == DialogResult.OK)
                    {
                        // Si el login es exitoso, abrir formulario principal
                        using (var FormularioPrincipal = new frmPrincipal())
                        {
                            var ResultadoPrincipal = FormularioPrincipal.ShowDialog();
                            
                            // Si el formulario principal retorna Cancel, volver al login
                            // Si retorna cualquier otra cosa, salir de la aplicación
                            if (ResultadoPrincipal != DialogResult.Cancel)
                            {
                                ContinuarAplicacion = false;
                            }
                        }
                    }
                    else
                    {
                        // Si se cancela el login, salir de la aplicación
                        ContinuarAplicacion = false;
                    }
                }
            }
        }
    }
}
