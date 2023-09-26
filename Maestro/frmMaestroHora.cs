using Biblio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maestro
{
    public partial class frmMaestroHora : Form
    {
        public frmMaestroHora()
        {
            InitializeComponent();
        }

        public string[] sexo = { "Hombre", "Mujer" };

        private void frmMaestroHora_Load(object sender, EventArgs e)
        {
            cboSexo.DataSource = sexo;
        }

        MaestroPorHora hora = new();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar() == "")
            {

                hora.primerNombre = txtNombre.Text;
                hora.primerApellido = txtApellido.Text;
                hora.sexo = cboSexo.Text;
                hora.edad = int.Parse(txtEdad.Text);
                hora.codigo = txtCodigo.Text;

                hora.SalarioPorHora = double.Parse(txtSalarioxHora.Text);
                hora.horasTrabajadas = int.Parse(txtHoras.Text);




                ListViewItem fila = new ListViewItem(txtNombre.Text);
                fila.SubItems.Add(txtApellido.Text);
                fila.SubItems.Add(cboSexo.Text);
                fila.SubItems.Add(txtEdad.Text);
                fila.SubItems.Add(txtCodigo.Text);
                fila.SubItems.Add(hora.CalcularSalario().ToString());
                fila.SubItems.Add(hora.CalcularInss().ToString("0.00"));


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
            txtHoras.Clear();
            txtSalarioxHora.Clear();

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
            else if (int.Parse(txtEdad.Text) < 18 || int.Parse(txtEdad.Text) > 80)
            {
                return "La edad no puede ser menor a 18 ni mayor que 80";
            }
            else if (int.Parse(txtHoras.Text) < 0 || int.Parse(txtHoras.Text) > 176)
            {
                return "las horas no puede ser mayores a 176 ni menores a 0";
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

        private void txtHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            int maxLength = 3;

            if (txtHoras.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtSalarioxHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            int maxLength = 4;

            if (txtSalarioxHora.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
