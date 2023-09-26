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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnPlanta_Click(object sender, EventArgs e)
        {
            frmMaestroPlanta planta = new();
            planta.ShowDialog();
        }

        private void btnHora_Click(object sender, EventArgs e)
        {
            frmMaestroHora hora = new();
            hora.ShowDialog();
        }
    }
}
