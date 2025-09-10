using MaterialSkin.Controls;
using Modelo;
using Negocio;
using Pantallas_Sistema_facturación.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturación.Forms.Seguridad.UserControls
{
    public partial class ucRol : UserControl
    {
        private int idEmpleadoSeleccionado = 0;
        private List<ModeloAdministracionSeguridad> listaSeguridad;
        private List<ModeloEmpleado> listaEmpleados;

        public ucRol()
        {
            InitializeComponent();
            ConfigurarContenidoFormulario();
        }

        private void ucRol_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            ConsultarListaSeguridad();
        }

        private void ConfigurarContenidoFormulario()
        {
            this.BackColor = Color.White;
            this.AutoScroll = true;
            this.AutoScrollMargin = new Size(20, 20);

            cmbEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmpleado.SelectedIndexChanged += cmbEmpleado_SelectedIndexChanged;

            dataGridViewListaAdministracioinSeguridad.SelectionChanged += dataGridViewListaAdministracioinSeguridad_SelectionChanged;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var seguridad = ObtenerDatosSeguridad();
            if (seguridad == null) return;

            var negocio = new NegocioCrearOActualizarAdministracionSeguridad(seguridad);

            try
            {
                bool exito = negocio.Ejecutar();

                if (true)
                {
                    MessageBox.Show("Seguridad guardada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConsultarListaSeguridad();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al guardar la seguridad. Verifica los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la seguridad: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaAdministracioinSeguridad.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un registro para eliminar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Está seguro que desea eliminar este registro de seguridad?",
                                "Confirmar eliminación",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int idSeguridad = Convert.ToInt32(
                    dataGridViewListaAdministracioinSeguridad.SelectedRows[0].Cells["IdSeguridad"].Value
                );

                var negocio = new NegocioEliminarAdministracionSeguridad(idSeguridad);

                if (negocio.Ejecutar())
                {
                    MessageBox.Show("Seguridad eliminada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConsultarListaSeguridad();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar la seguridad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir sin guardar?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpiarCampos();
                this.Visible = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private ModeloAdministracionSeguridad ObtenerDatosSeguridad()
        {
            
            if (!ValidarCampos()) return null;
            string texto = cmbEmpleado.Text;
            string id = texto.Split('-')[0].Trim();
            int idEntero = int.Parse(id);

            return new ModeloAdministracionSeguridad
            {
                IdEmpleado = idEntero,
                IdSeguridad = textBoxId.Text.Trim() == "" ? 0 : int.Parse(textBoxId.Text.Trim()),
                StrUsuario = txtUsuario.Text.Trim(),
                StrClave = txtContraseña.Text.Trim(),
                DtmFechaModifica = DateTime.Now,
                StrUsuarioModifico = Environment.UserName
            };
        }

        private bool ValidarCampos()
        {
            if (cmbEmpleado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un empleado", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEmpleado.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("El usuario es requerido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("La contraseña es requerida", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Focus();
                return false;
            }

            return true;
        }
        private void LimpiarCampos()
        {
            textBoxId.Clear();
            textBoxNombre.Clear();
            cmbEmpleado.SelectedIndex = -1;
            txtUsuario.Clear();
            txtContraseña.Clear();
            cmbEmpleado.Enabled = true;
            idEmpleadoSeleccionado = 0;
            cmbEmpleado.Focus();
        }

        private void CargarEmpleados()
        {
            try
            {
                var negocio = new NegocioConsultaEmpleado();
                listaEmpleados = negocio.Ejecutar();

                if (listaEmpleados == null || listaEmpleados.Count == 0)
                {
                    MessageBox.Show("No hay empleados disponibles", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbEmpleado.DataSource = null;
                    return;
                }
                List<string> nombres = new List<string>();
                foreach (var item in listaEmpleados)
                {
                    string valor = item.IdEmpleado + " - " + item.StrNombre;
                    nombres.Add(valor);
                }

                cmbEmpleado.Items.Clear();
                foreach (var item in nombres)
                {
                    cmbEmpleado.Items.Add(item);
                }

                cmbEmpleado.BackColor = Color.White;
                cmbEmpleado.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar empleados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbEmpleado.DataSource = null;
            }
        }

        private void ConsultarListaSeguridad()
        {
            try
            {
                NegocioConsultaAdministracionSeguridad negocio = new NegocioConsultaAdministracionSeguridad();
                this.listaSeguridad = negocio.Ejecutar();

                List<object> listaParaGrid = new List<object>();

                if (this.listaSeguridad != null && listaEmpleados != null)
                {
                    foreach (var seguridad in this.listaSeguridad)
                    {
                        var empleado = listaEmpleados.FirstOrDefault(e => e.IdEmpleado == seguridad.IdEmpleado);
                        string empleadoNombre = empleado != null
                            ? $"{empleado.IdEmpleado} - {empleado.StrNombre}"   // 👈 ID + Nombre
                            : seguridad.IdEmpleado.ToString();

                        listaParaGrid.Add(new
                        {
                            IdSeguridad = seguridad.IdSeguridad,
                            IdEmpleado = seguridad.IdEmpleado,
                            Empleado = empleadoNombre,
                            StrUsuario = seguridad.StrUsuario,
                            StrClave = seguridad.StrClave,
                            DtmFechaModifica = seguridad.DtmFechaModifica.ToString("g"),
                            StrUsuarioModifico = seguridad.StrUsuarioModifico
                        });
                    }
                }

                dataGridViewListaAdministracioinSeguridad.DataSource = listaParaGrid;
                ConfigurarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar seguridad: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGridView()
        {
            if (dataGridViewListaAdministracioinSeguridad.Columns.Count > 0)
            {
                dataGridViewListaAdministracioinSeguridad.Columns["IdSeguridad"].HeaderText = "ID";
                dataGridViewListaAdministracioinSeguridad.Columns["IdEmpleado"].HeaderText = "Empleado";
                dataGridViewListaAdministracioinSeguridad.Columns["StrUsuario"].HeaderText = "Usuario";
                dataGridViewListaAdministracioinSeguridad.Columns["StrClave"].HeaderText = "Contraseña";
                dataGridViewListaAdministracioinSeguridad.Columns["DtmFechaModifica"].HeaderText = "Fecha Modificación";
                dataGridViewListaAdministracioinSeguridad.Columns["StrUsuarioModifico"].HeaderText = "Modificado Por";

                dataGridViewListaAdministracioinSeguridad.AutoResizeColumns();
                dataGridViewListaAdministracioinSeguridad.ReadOnly = true;
                dataGridViewListaAdministracioinSeguridad.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dataGridViewListaAdministracioinSeguridad.CellClick += dataGridViewListaAdministracioinSeguridad_SelectionChanged;
            }
        }

        private void dataGridViewListaAdministracioinSeguridad_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewListaAdministracioinSeguridad.SelectedRows.Count > 0)
            {
                var fila = dataGridViewListaAdministracioinSeguridad.SelectedRows[0];

                if (fila.Cells["IdEmpleado"] != null &&
                    fila.Cells["Empleado"] != null &&
                    fila.Cells["StrUsuario"] != null &&
                    fila.Cells["StrClave"] != null)
                {
                    string IdEmpleado = fila.Cells["IdEmpleado"].Value?.ToString() ?? "0";
                    string empleadoTexto = fila.Cells["Empleado"].Value?.ToString() ?? string.Empty;
                    string usuario = fila.Cells["StrUsuario"].Value?.ToString() ?? string.Empty;
                    string clave = fila.Cells["StrClave"].Value?.ToString() ?? string.Empty;

                    string Nombre = empleadoTexto.Contains(" - ")
                        ? empleadoTexto.Split(new[] { " - " }, StringSplitOptions.None)[1]
                        : empleadoTexto;

                    textBoxId.Text = IdEmpleado;
                    textBoxNombre.Text = Nombre;
                    cmbEmpleado.SelectedIndex = cmbEmpleado.Items.IndexOf(empleadoTexto);
                    txtUsuario.Text = usuario;
                    txtContraseña.Text = clave;

                    cmbEmpleado.Enabled = false;

                    if (int.TryParse(IdEmpleado, out int idEmpleado))
                    {
                        idEmpleadoSeleccionado = idEmpleado;
                    }
                }
            }
        }

        private void cmbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmpleado.SelectedIndex != -1)
            {
                string texto = cmbEmpleado.SelectedItem.ToString();
                string[] partes = texto.Split('-');
                if (partes.Length > 1)
                {
                    textBoxId.Text = partes[0].Trim();
                    textBoxNombre.Text = partes[1].Trim();

                    int idEmpleado = int.Parse(partes[0].Trim());
                    var seguridad = listaSeguridad?.FirstOrDefault(s => s.IdEmpleado == idEmpleado);

                    if (seguridad != null)
                    {
                        txtUsuario.Text = seguridad.StrUsuario;
                        txtContraseña.Text = seguridad.StrClave;
                    }
                    else
                    {
                        txtUsuario.Clear();
                        txtContraseña.Clear();
                    }
                }
            }
        }


        private void ValidarTextoAlfanumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
                e.Handled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
