using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Pantallas_Sistema_facturación.Forms.Ayuda.UserControls
{
    public partial class ucAyuda : UserControl
    {
        public ucAyuda()
        {
            InitializeComponent();
            ConfigurarContenidoFormulario();
        }

        private void ucAyuda_Load(object sender, EventArgs e)
        {
            ConfigurarEventos();
            ConfigurarEstilosVisualProfesional();
        }

        private void ConfigurarContenidoFormulario()
        {
            this.BackColor = Color.White;
            this.AutoScroll = true;
            this.AutoScrollMargin = new Size(20, 20);
            AgregarIconosVisualProfesional();
        }

        private void ConfigurarEventos()
        {
            if (btnBuscar != null)
                btnBuscar.Click += BtnBuscar_Click;

            if (btnSalir != null)
                btnSalir.Click += BtnSalir_Click;

            if (lblComoActualizarDatos != null || tlpActualizarDatos != null)
            {
                lblComoActualizarDatos.Click += LblComoActualizarDatos_Click;
                tlpActualizarDatos.Click += LblComoActualizarDatos_Click;
                pnlIconoActualizar.Click += LblComoActualizarDatos_Click;
            }

            if (lblGenerarReporte != null || tlpGenerarReporte != null)
            {
                lblGenerarReporte.Click += LblGenerarReporte_Click;
                tlpGenerarReporte.Click += LblGenerarReporte_Click;
                pnlIconoReporte.Click += LblGenerarReporte_Click;
            }

            if (lblOlvidoContraseña != null || tlpOlvidoContrasena != null)
            {
                lblOlvidoContraseña.Click += LblOlvidoContraseña_Click;
                tlpOlvidoContrasena.Click += LblOlvidoContraseña_Click;
                pnlIconoContrasena.Click += LblOlvidoContraseña_Click;
            }

            ConfigurarEfectosHover();
        }

        private void ConfigurarEfectosHover()
        {
            ConfigurarHoverParaOpcion(tlpActualizarDatos, pnlIconoActualizar);
            ConfigurarHoverParaOpcion(tlpGenerarReporte, pnlIconoReporte);
            ConfigurarHoverParaOpcion(tlpOlvidoContrasena, pnlIconoContrasena);
        }

        private void ConfigurarHoverParaOpcion(TableLayoutPanel panel, Panel iconPanel)
        {
            Color colorOriginal = panel.BackColor;
            Color colorHover = Color.FromArgb(240, 242, 245);

            panel.MouseEnter += (s, e) => {
                panel.BackColor = colorHover;
                iconPanel.BackColor = Color.FromArgb(120, 120, 120);
            };

            panel.MouseLeave += (s, e) => {
                panel.BackColor = colorOriginal;
                RestaurarColorIcono(iconPanel);
            };

            foreach (Control control in panel.Controls)
            {
                control.MouseEnter += (s, e) => {
                    panel.BackColor = colorHover;
                    iconPanel.BackColor = Color.FromArgb(120, 120, 120);
                };

                control.MouseLeave += (s, e) => {
                    panel.BackColor = colorOriginal;
                    RestaurarColorIcono(iconPanel);
                };
            }
        }

        private void RestaurarColorIcono(Panel iconPanel)
        {
            if (iconPanel == pnlIconoActualizar)
                iconPanel.BackColor = Color.FromArgb(165, 135, 195);
            else if (iconPanel == pnlIconoReporte)
                iconPanel.BackColor = Color.FromArgb(142, 107, 168);
            else if (iconPanel == pnlIconoContrasena)
                iconPanel.BackColor = Color.FromArgb(200, 168, 216);
        }

        private void ConfigurarEstilosVisualProfesional()
        {
            // Configurar bordes redondeados para las tarjetas
            AplicarBordesRedondeados(tlpActualizarDatos, 8);
            AplicarBordesRedondeados(tlpGenerarReporte, 8);
            AplicarBordesRedondeados(tlpOlvidoContrasena, 8);

            // Agregar sombras sutiles (simuladas con bordes)
            AgregarSombrasTarjetas();
        }

        private void AplicarBordesRedondeados(Control control, int radio)
        {
            control.Paint += (s, e) =>
            {
                using (var path = CrearRutaBordeRedondeado(control.ClientRectangle, radio))
                {
                    control.Region = new Region(path);
                }
            };
        }

        private System.Drawing.Drawing2D.GraphicsPath CrearRutaBordeRedondeado(Rectangle rect, int radio)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
            path.AddArc(rect.X + rect.Width - radio, rect.Y, radio, radio, 270, 90);
            path.AddArc(rect.X + rect.Width - radio, rect.Y + rect.Height - radio, radio, radio, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radio, radio, radio, 90, 90);
            path.CloseAllFigures();
            return path;
        }

        private void AgregarSombrasTarjetas()
        {
            // Simulación de sombras con bordes sutiles
            AgregarBordeSutil(tlpActualizarDatos);
            AgregarBordeSutil(tlpGenerarReporte);
            AgregarBordeSutil(tlpOlvidoContrasena);
        }

        private void AgregarBordeSutil(Control control)
        {
            control.Paint += (s, e) =>
            {
                using (var pen = new Pen(Color.FromArgb(30, 0, 0, 0), 1))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, control.Width - 1, control.Height - 1);
                }
            };
        }

        private void AgregarIconosVisualProfesional()
        {
            // Agregar iconos simples usando caracteres Unicode o formas geométricas
            AgregarIconoPersonalizado(pnlIconoActualizar, "👤", Color.White);
            AgregarIconoPersonalizado(pnlIconoReporte, "📊", Color.White);
            AgregarIconoPersonalizado(pnlIconoContrasena, "🔒", Color.White);
        }

        private void AgregarIconoPersonalizado(Panel panel, string icono, Color colorTexto)
        {
            var lblIcono = new Label
            {
                Text = icono,
                Font = new Font("Segoe UI Emoji", 28F, FontStyle.Bold),
                ForeColor = colorTexto,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent
            };
            panel.Controls.Add(lblIcono);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDuda.Text))
            {
                MessageBox.Show("Por favor, ingrese su duda para buscar ayuda",
                    "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDuda.Focus();
                return;
            }

            string TextoBusqueda = txtDuda.Text.Trim().ToLower();
            string RespuestaAyuda = ObtenerRespuestaAyuda(TextoBusqueda);

            MessageBox.Show(RespuestaAyuda, "Respuesta de Ayuda",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            var Resultado = MessageBox.Show("¿Está seguro que desea salir?",
                "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Resultado == DialogResult.Yes)
            {
                this.Visible = false;
            }
        }

        private void LblComoActualizarDatos_Click(object sender, EventArgs e)
        {
            string MensajeAyuda = "📋 ACTUALIZACIÓN DE DATOS\n\n" +
                                  "Para actualizar información en el sistema:\n\n" +
                                  "1️⃣ Acceda al módulo de TABLAS desde el menú principal\n" +
                                  "2️⃣ Seleccione la opción correspondiente:\n" +
                                  "   • Clientes - Para datos de clientes\n" +
                                  "   • Productos - Para información de productos\n" +
                                  "   • Categorías - Para categorías de productos\n\n" +
                                  "3️⃣ Complete los campos requeridos (marcados con *)\n" +
                                  "4️⃣ Haga clic en 'ACTUALIZAR' para guardar los cambios\n\n" +
                                  "💡 CONSEJO: Verifique que todos los datos sean correctos antes de guardar.";

            MessageBox.Show(MensajeAyuda, "¿Cómo actualizar mis datos?",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LblGenerarReporte_Click(object sender, EventArgs e)
        {
            string MensajeAyuda = "📊 GENERACIÓN DE REPORTES\n\n" +
                                  "Para crear reportes e informes:\n\n" +
                                  "1️⃣ Vaya al módulo de FACTURACIÓN\n" +
                                  "2️⃣ Seleccione la opción 'INFORMES'\n" +
                                  "3️⃣ Configure los parámetros:\n" +
                                  "   • Tipo de informe deseado\n" +
                                  "   • Rango de fechas\n" +
                                  "   • Criterio de ordenamiento\n\n" +
                                  "4️⃣ Seleccione el formato de salida:\n" +
                                  "   • En Pantalla - Vista previa\n" +
                                  "   • PDF - Documento imprimible\n" +
                                  "   • Excel - Hoja de cálculo\n\n" +
                                  "5️⃣ Haga clic en 'GENERAR INFORME'\n\n" +
                                  "⏰ El sistema procesará su solicitud y mostrará el resultado.";

            MessageBox.Show(MensajeAyuda, "¿Cómo generar un reporte?",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LblOlvidoContraseña_Click(object sender, EventArgs e)
        {
            string MensajeAyuda = "🔒 RECUPERACIÓN DE CONTRASEÑA\n\n" +
                                  "Si olvidó su contraseña de acceso:\n\n" +
                                  "1️⃣ Contacte al administrador del sistema\n" +
                                  "2️⃣ Proporcione la siguiente información:\n" +
                                  "   • Su nombre de usuario\n" +
                                  "   • Documento de identificación\n" +
                                  "   • Área de trabajo\n\n" +
                                  "3️⃣ El administrador verificará su identidad\n" +
                                  "4️⃣ Se le asignará una contraseña temporal\n" +
                                  "5️⃣ Debe cambiar la contraseña en el primer acceso\n\n" +
                                  "🔐 CONSEJOS DE SEGURIDAD:\n" +
                                  "• Use al menos 8 caracteres\n" +
                                  "• Combine letras, números y símbolos\n" +
                                  "• No comparta su contraseña\n" +
                                  "• Cambie la contraseña periódicamente";

            MessageBox.Show(MensajeAyuda, "¿Qué hacer si olvido mi contraseña?",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string ObtenerRespuestaAyuda(string ConsultaBusqueda)
        {
            if (ConsultaBusqueda.Contains("datos") || ConsultaBusqueda.Contains("actualizar") || 
                ConsultaBusqueda.Contains("modificar") || ConsultaBusqueda.Contains("editar"))
            {
                return "📋 ACTUALIZACIÓN DE DATOS\n\n" +
                       "Para actualizar datos, vaya al módulo de TABLAS → seleccione la opción correspondiente → " +
                       "complete los campos requeridos → haga clic en 'ACTUALIZAR'.\n\n" +
                       "💡 Los campos marcados con (*) son obligatorios.";
            }

            if (ConsultaBusqueda.Contains("reporte") || ConsultaBusqueda.Contains("informe") || 
                ConsultaBusqueda.Contains("generar") || ConsultaBusqueda.Contains("imprimir"))
            {
                return "📊 GENERACIÓN DE REPORTES\n\n" +
                       "Para generar reportes: FACTURACIÓN → INFORMES → configure parámetros → " +
                       "seleccione formato (Pantalla/PDF/Excel) → GENERAR INFORME.\n\n" +
                       "📋 Disponible: Ventas, Facturas, Productos, Ingresos y más.";
            }

            if (ConsultaBusqueda.Contains("contraseña") || ConsultaBusqueda.Contains("password") || 
                ConsultaBusqueda.Contains("login") || ConsultaBusqueda.Contains("acceso"))
            {
                return "🔒 RECUPERACIÓN DE CONTRASEÑA\n\n" +
                       "Si olvidó su contraseña: Contacte al administrador → proporcione usuario e identificación → " +
                       "recibirá contraseña temporal → cámbiela en el primer acceso.\n\n" +
                       "🔐 Use contraseñas seguras: 8+ caracteres, letras, números y símbolos.";
            }

            if (ConsultaBusqueda.Contains("cliente") || ConsultaBusqueda.Contains("producto") || 
                ConsultaBusqueda.Contains("categoria"))
            {
                return "🏢 GESTIÓN DE DATOS\n\n" +
                       "Para gestionar clientes, productos o categorías: TABLAS → seleccione opción → " +
                       "agregue/edite información → ACTUALIZAR.\n\n" +
                       "📝 Cada módulo tiene campos específicos y validaciones automáticas.";
            }

            if (ConsultaBusqueda.Contains("factura") || ConsultaBusqueda.Contains("facturar") || 
                ConsultaBusqueda.Contains("venta"))
            {
                return "🧾 FACTURACIÓN\n\n" +
                       "Para crear facturas: FACTURACIÓN → complete datos del cliente → " +
                       "agregue productos → verifique totales → genere la factura.\n\n" +
                       "💰 El sistema calcula automáticamente impuestos y totales.";
            }

            if (ConsultaBusqueda.Contains("usuario") || ConsultaBusqueda.Contains("empleado") || 
                ConsultaBusqueda.Contains("rol") || ConsultaBusqueda.Contains("seguridad"))
            {
                return "👥 GESTIÓN DE USUARIOS\n\n" +
                       "Para administrar usuarios y permisos: SEGURIDAD → gestione empleados, roles y " +
                       "configuraciones → asigne permisos según necesidades.\n\n" +
                       "🛡️ Controle el acceso y mantenga la seguridad del sistema.";
            }

            return "🤔 BÚSQUEDA SIN RESULTADOS ESPECÍFICOS\n\n" +
                   "No encontré una respuesta específica para su consulta. Le recomiendo:\n\n" +
                   "✅ Revisar las opciones de ayuda disponibles arriba\n" +
                   "✅ Contactar al administrador del sistema\n" +
                   "✅ Usar palabras clave más específicas\n\n" +
                   "📋 MÓDULOS PRINCIPALES:\n" +
                   "• TABLAS - Gestión de datos básicos\n" +
                   "• FACTURACIÓN - Crear facturas e informes\n" +
                   "• SEGURIDAD - Usuarios y permisos";
        }

        public void LimpiarBusqueda()
        {
            if (txtDuda != null)
            {
                txtDuda.Clear();
                txtDuda.Focus();
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var Resultado = MessageBox.Show("¿Está seguro que desea salir sin guardar?",
                "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Resultado == DialogResult.Yes)
            {
                LimpiarBusqueda();
                this.Visible = false;
            }
        }

        private void tlpPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
