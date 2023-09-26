using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    public class MaestroPlanta: Maestro
    {

        public double SalarioFijo { get; set; }

        public override double CalcularSalario()
        {
            return SalarioFijo;
        }

        public override double CalcularInss()
        {
            return base.CalcularInss() * CalcularSalario();
        }

    }
}
