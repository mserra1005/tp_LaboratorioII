using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Numero
    {
        private double numero;

        public double getNumero()
        {
            return this.numero;
        }
        public Numero()//por defecto
        {
            this.numero = 0;
        }
        public Numero(double numero)
        {
            this.numero = numero;
        }
        public Numero(string numero)
        {
            this.numero = (validarNumero(numero));
        }
        private void setNumero(string numero)
        {
            this.numero = Numero.validarNumero(numero);
        }
        private static double validarNumero(string numeroString)
        {
            double dato;
            bool dt = double.TryParse(numeroString, out dato);

            if (dt)
            {
                Console.WriteLine("Numero Doble");
                return double.Parse(numeroString);
            }
            else
            {
                Console.WriteLine("No es un Nro de tipo double");
                return 0;
            }
        }
    }
}

        
    
