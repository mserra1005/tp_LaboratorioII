using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculadora_WF;
using ClassLibrary1;


namespace Calculadora_WF
{
    class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Numero num = new Numero();        //inicializacion de clases
            Form1 calculador = new Form1();
        }
    }
}
