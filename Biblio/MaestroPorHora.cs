using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    public class MaestroPorHora: Maestro
    {
        public double SalarioPorHora { get; set; }  
        public int horasTrabajadas { get; set; }


        public override double CalcularSalario()
        {
            return SalarioPorHora * horasTrabajadas;
        }

        public override double CalcularInss()
        {
            return base.CalcularInss()* CalcularSalario();
        }


    }
}
