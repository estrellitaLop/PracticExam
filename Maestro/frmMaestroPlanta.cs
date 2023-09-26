using Biblio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maestro
{
    public partial class frmMaestroPlanta : Form
    {
        public frmMaestroPlanta()
        {
            InitializeComponent();
        }


        public string[] sexo = { "Hombre", "Mujer" };

        private void frmMaestroPlanta_Load(object sender, EventArgs e)
        {
            cboSexo.DataSource = sexo;
        }

        MaestroPlanta planta = new();

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (Validar() == "")
            {

                planta.primerNombre = txtNombre.Text;
                planta.primerApellido = txtApellido.Text;
                planta.sexo = cboSexo.Text;
                planta.edad = int.Parse(txtEdad.Text);
                planta.codigo = txtCodigo.Text;

                planta.SalarioFijo = double.Parse(txtSalario.Text);

                ListViewItem fila = new ListViewItem(txtNombre.Text);
                fila.SubItems.Add(txtApellido.Text);
                fila.SubItems.Add(cboSexo.Text);
                fila.SubItems.Add(txtEdad.Text);
                fila.SubItems.Add(txtCodigo.Text);
                fila.SubItems.Add(planta.CalcularSalario().ToString());
                fila.SubItems.Add(planta.CalcularInss().ToString("0.00"));

                lstDetalle.Items.Add(fila);

                Limpiar();

            }
            else
            {
                MessageBox.Show(Validar(), "Advertencia", MessageBoxButtons.OK);
            }




        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtEdad.Clear();
            txtCodigo.Clear();
            txtSalario.Clear();

        }

        public string Validar()
        {

            if (txtNombre.Text.Trim().Length == 0)
            {
                return "No puede dejar espacios en blanco";
            }
            else if (txtApellido.Text.Trim().Length == 0)
            {
                return "No puede dejar espacios en blanco";
            }
            else if (txtEdad.Text.Trim().Length == 0)
            {
                return "No puede dejar espacios en blanco";
            }
            else if (txtCodigo.Text.Trim().Length == 0)
            {
                return "No puede dejar espacios en blanco";
            }
            else if (txtSalario.Text.Trim().Length == 0)
            {
                return "No puede dejar espacios en blanco";
            }
            else if(int.Parse(txtEdad.Text)<18 || int.Parse(txtEdad.Text) > 80)
            {
                return "La edad no puede ser menor a 18 ni mayor que 80";
            }


            return "";
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            int maxLength = 2;

            if (txtEdad.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            int maxLength = 6;

            if (txtSalario.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
