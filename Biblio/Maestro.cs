using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    public  class Maestro
    {
        private int edad1;

        public string primerNombre { get; set; }
        public string primerApellido { get; set; }
        public string codigo { get; set; }

        public int edad
        { 
            get => edad1; 
            set
            {
                if (value < 0 || value>80)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(edad)}no puede ser menor que cero ni mayor que 80");
                        
                }

                edad1 = value;  
            }
        
        
        }
        public string sexo { get; set; }


        


        public virtual double CalcularSalario()
        {
            return 0;
        }
        
        public virtual double CalcularInss()
        {
            return 0.07;
        }






    }
}
