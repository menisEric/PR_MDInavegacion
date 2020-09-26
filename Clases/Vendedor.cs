using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class Vendedor:Persona
    {
        private String tipoContrato;
        private Double sueldo;

        public string TipoContrato { get => tipoContrato; set => tipoContrato = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }
    
        public void calcularSueldo(Double sueldoBase)
        {
            if (this.TipoContrato=="C")
            {
                this.Sueldo = sueldoBase + 350;
            }
            else if (this.TipoContrato=="N")
            {
                this.Sueldo = sueldoBase + 750;
            }
            else
            {
                this.Sueldo = 0;
            }
        }   
    }
}
