using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecuaciones_no_lineales
{
    public partial class Metodo_de_la_secante : Form
    {
        public Metodo_de_la_secante()
        {
            InitializeComponent();
        }
        Fx_funciones fx = new Fx_funciones();//variable para aplicar funciones a Fxi y Fxi-1
        
        public void TeclaEnter(object sender, KeyPressEventArgs e) 
        {
            //funcion para que se ejecute el programa enter
            if (e.KeyChar == (Char)Keys.Enter)
            {
                e.Handled = true;
                secante();
            }
        }
        //secante
        public void secante()
        {
            if (Txt_Funcion.Text == "" || Txt_Xi.Text == "" || Txt_Xi_1.Text == "" || Txt_Error.Text == "")//validacion si la caja de texto esta vacia lanza alerta
            {
                MessageBox.Show("Elementos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);//mensaje
                Btn_Calcular.Enabled = true;
            }
            else
            {
                //variables 
                double ximenos1, xi, ximas1, fximenos1, fxi, aux, aux1;
                decimal Lerror = decimal.Parse(Txt_Error.Text);
                decimal error;
                int i = 0;
                //entrada
                dgv_tabla.Visible = true;//hacemos la tabla visible
                dgv_tabla.Rows.Add();//it was added rows
                //se asignan valores a las variables de entrada
                ximenos1 = double.Parse(Txt_Xi_1.Text);
                xi = double.Parse(Txt_Xi.Text);
                fximenos1 = fx.Fx_Funciones(Txt_Funcion.Text, ximenos1);
                fxi = fx.Fx_Funciones(Txt_Funcion.Text, xi);//se manda a llamar la funcion que calcula las funciones
                ximas1 = (xi - ((fxi * (ximenos1 - xi)) / (fximenos1 - fxi))); //se hace la formula para calcualar xi+1
                //se imprime la primera fila ya que no lleva error 
                dgv_tabla[0, i].Value = i + 1;
                dgv_tabla[1, i].Value = ximenos1;
                dgv_tabla[2, i].Value = xi;
                dgv_tabla[3, i].Value = ximas1;
                dgv_tabla[4, i].Value = fximenos1;
                dgv_tabla[5, i].Value = fxi;
                i++;//se aumenta en no la iteracion
                do//ciclo para las demas iteraciones
                {
                    dgv_tabla.Rows.Add();//it was added rows 
                    aux = xi;//se al cambia el valor de xi en aux
                    xi = ximas1;//se le asigna un nuevo valor a xi
                    aux1 = ximas1;//se cambia el valor de ximas1 en aux1
                    ximenos1 = aux;//se le de el valor viejo de xi a ximenos1
                    fximenos1 = fx.Fx_Funciones(Txt_Funcion.Text, ximenos1);//se manda a llamar la funcion que calcula las funciones
                    fxi = fx.Fx_Funciones(Txt_Funcion.Text, xi);//se manda a llamar la funcion que calcula las funciones
                    ximas1 = (xi - ((fxi * (ximenos1 - xi)) / (fximenos1 - fxi)));//se calcula el nuevo valor de ximas1
                    error = decimal.Round((decimal)Math.Abs((ximas1 - aux1) / ximas1) * 100, 3);//se calcula el primer error
                    //se imprime la tabla
                    dgv_tabla[0, i].Value = i + 1;
                    dgv_tabla[1, i].Value = ximenos1;
                    dgv_tabla[2, i].Value = xi;
                    dgv_tabla[3, i].Value = ximas1;
                    dgv_tabla[4, i].Value = fximenos1;
                    dgv_tabla[5, i].Value = fxi;
                    dgv_tabla[6, i].Value = error + "%";
                    i++;//se aumenta en 1 la iteracion
                } while (Lerror <= error );//el ciclo sigue hasta que el error sea menor o igual al escogido
                Btn_Calcular.Enabled = false;
            }
        }
        //boton que calcula 
        private void Btn_Calcular_Click(object sender, EventArgs e)
        {
            secante();//funcion secante
        }

        //clear screen
        private void Btn_Ac_Click(object sender, EventArgs e)
        {
            Txt_Funcion.Clear();
            Txt_Xi.Clear();
            Txt_Xi_1.Clear();
            Txt_Error.Clear();
            dgv_tabla.Rows.Clear();
            dgv_tabla.Visible = false;
            Btn_Calcular.Enabled = true;
            Txt_Funcion.Focus();
        }
        //evento que permite usar la tecla enter para ejecutar
        private void Txt_Error_KeyPress(object sender, KeyPressEventArgs e)
        {
            TeclaEnter(sender,e);
            Program.ValidarTextbox(sender, e);//se validan errores
        }
        //validaciones
        private void Txt_Xi_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.ValidarTextbox(sender, e);
        }
        //validaciones
        private void Txt_Xi_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.ValidarTextbox(sender, e);
        }
        //foco en txt_funciones
        private void Metodo_de_la_secante_Load(object sender, EventArgs e)
        {
            Txt_Funcion.Focus();
        }

        private void Txt_Funcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.ValidarEcuaciones(sender, e);
        }
    }
}
