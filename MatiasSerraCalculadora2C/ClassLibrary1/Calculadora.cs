using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Calculadora
    {
        public static double operar(Numero numero1, Numero numero2, string operador)
        {
            double result = 0;
            switch (operador)
            {
                case "*":
                    {
                        result = numero1.getNumero() * numero2.getNumero();
                        break;
                    }
                case "/":
                    {
                        if (numero2.getNumero() == 0)
                        {
                            result = 0;
                            break;
                        }
                        else
                        {
                            result = numero1.getNumero() / numero2.getNumero();
                            break;
                        }//fin de condicional 1
                    }

                case "+":
                    {
                        result = numero1.getNumero() + numero2.getNumero();
                        break;
                    }
                case "-":
                    {
                        result = numero1.getNumero() - numero2.getNumero();
                        break;
                    }
            }//swich

            return result;


        }
        public string validarOperador(string operador)
        {
            while (operador == "+" && operador == "-" && operador == "*" && operador == "/")
            {
                return operador;

            }
            return "+";

        }

    }
}