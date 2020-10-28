using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecuaciones_no_lineales
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new home());
        }

        public static void ValidarTextbox(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                MessageBox.Show("Solo se permiten numeros, punto decimal y el signo -", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                e.Handled = true;
            }
        }
        public static void ValidarEcuaciones(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '_') && (e.KeyChar != '^')&&(e.KeyChar != '-')&&(e.KeyChar != '+')&& (e.KeyChar != 'e')&&(e.KeyChar != 'x'))
            {
                MessageBox.Show("Solo se permiten los siguientes caracteres: numericos, x, e, ^, _ , - , + ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                e.Handled = true;
            }
        }
    }
}
