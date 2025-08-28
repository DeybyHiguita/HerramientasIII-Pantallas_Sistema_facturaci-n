using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturación.Forms.Seguridad.UserControls
{
    public partial class ucEmpleado : UserControl
    {
        public ucEmpleado()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "¿Está seguro que desea salir sin guardar?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ClearFields();
                this.Visible = false;
            }
        }

        private void ClearFields()
        {
            void Clear(Control c)
            {
                switch (c)
                {
                    case TextBoxBase tb:
                        tb.Clear();
                        break;
                    case ComboBox cb:
                        cb.SelectedIndex = -1;
                        cb.Text = string.Empty;
                        break;
                    case CheckBox chk:
                        chk.Checked = false;
                        break;
                    case RadioButton rb:
                        rb.Checked = false;
                        break;
                    case NumericUpDown nud:
                        nud.Value = nud.Minimum;
                        break;
                    case DateTimePicker dtp:
                        dtp.Value = DateTime.Now;
                        break;
                }

                foreach (Control child in c.Controls)
                    Clear(child);
            }

            Clear(this);
        }
    }
}
