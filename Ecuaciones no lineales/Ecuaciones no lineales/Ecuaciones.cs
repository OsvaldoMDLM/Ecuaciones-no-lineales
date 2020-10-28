using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecuaciones_no_lineales
{
    class Ecuaciones
    {
        //lee los elementos separados por un signo de mas o menos
        public string[] Elementos(string cadena)
        {
            string[] elementos = cadena.Split('+', '-');//se selecciona que signo es el que los separara
            char[] aux = cadena.ToCharArray();//un auxiliar para leer caracteres individuales
            if (aux[0] == '-')//su el elemento es menos 
            {
                string[] elementos2 = new string[elementos.Length - 1];//se crea un nuevo vector con la longirud de el elemnto principal menos 1
                for (int i = 0; i < elementos2.Length; i++) 
                {
                    elementos2[i] = elementos[i + 1];
                }
                elementos = elementos2;
            }
            int j = 0;
            for (int i = 0; i < aux.Length; i++)
            {
                if (i == 0 && aux[i] != '-')
                {
                    j++;
                }
                else
                {
                    if (aux[i] == '-')
                    {
                        elementos[j] = "-" + elementos[j];
                        j++;
                    }
                    else
                    {
                        if (aux[i] == '+')
                        {
                            j++;
                        }
                    }
                }
            }
            return elementos;
        }
        //funcion que evalua los signos de la ecuacion
        public string[] Signos(string cadena)
        {
            string[] elementos = Elementos(cadena);
            char[] array = cadena.ToCharArray();
            string[] a = new string[elementos.Length - 1];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '-' && i != 0)
                {
                    a[j] = char.ToString(array[i]);
                    j++;
                }
                else
                {
                    if (array[i] == '+')
                    {
                        a[j] = char.ToString(array[i]);
                        j++;
                    }
                }

            }
            return a;
        }
        //funcion que evalua los terminos de la ecuacion
        public string[] Termino(string t)
        {
            string[] termino = new string[2];
            string[] terminos = t.Split('*', 'x', '^');//se descomponen los terminos de la ecuacion
            if (t.Contains("x") && !t.Contains("^"))//se verifica que no contenga una elevacion a exponente
            {
                if (terminos[0] == "")//se evalua si es 0
                {
                    termino[0] = "1";//le coloca uno por default
                }
                else
                {
                    if (terminos[0] == "-")//verifica si es -
                    {
                        termino[0] = "-1";//se le coloca menos uno por las leyes de los exponenetes
                    }
                    else
                    {
                        termino[0] = terminos[0];//de lo contrario se dejan igual
                    }
                    if (terminos[1] == "")
                    {
                        termino[1] = "1";
                    }
                }
            }
            if (!t.Contains("x") && !t.Contains("^"))//si no contiene x se iguala a 0 los terminos
            {
                termino[0] = "0";
                termino[1] = "0";
            }

            if (t.Contains("x") && t.Contains("^"))//si contiene x y esta elevada
            {
                if (terminos[0] == "")
                {
                    termino[0] = "1";
                    termino[1] = terminos[2];//el termino 1 se iguala a termino 2
                }
                else
                {
                    termino[0] = terminos[0];
                    termino[1] = terminos[2];
                }
                if (terminos[0] == "-")
                {
                    termino[0] = "-1";
                    termino[1] = terminos[2];
                }
            }

            return termino;
        }
        //funcion de cadena
        public string Cadena(string a, string[] b)
        {
            //string
            string[] x = a.Split('0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ',', '-');//constantes 
            //variables
            string aux;
            string aux2 = "";
            for (int i = 0; i < x.Length; i++)//se recorre toda la ecuacion
            {
                aux2 += x[i];
            }
            double constantes = double.Parse(b[0]) * double.Parse(b[1]);
            double exp = double.Parse(b[1]) - 1;
            if (constantes == 0)
            {
                aux = "";
            }
            else if (exp == 0)
            {
                aux = "" + constantes;
            }
            else
            {
                aux = constantes + aux2 + exp;
            }
            return aux;
        }
        //valores de la funcion
        public double ValorF(string fun, double Xi)
        {   //array
            string[] elementos = Elementos(fun);
            //variables
            double exponente;
            double Multiplicar;
            double Valor = 0;
            double euler = Math.E; //igualamos una variable al numero de euler
            double xinegativo;
            for (int i = 0; i < elementos.Length; i++)
            {    //evento que verifica si el numero euler fue introducido en en la formula este if evalua e^-x 
                if (elementos[i].Contains('e') && elementos[i].Contains('^') && elementos[i].Contains('_') && elementos[i].Contains('x'))
                {
                    string[] datosecuacion = elementos[i].Split('e' ,'^' ,'_' ,'x');//se descomponen los datos
                    xinegativo = Xi * -1;//igualamos la variable negativo al valor negativo de xi
                     exponente = Math.Pow(euler, xinegativo);//calculamos la exponente de el numero de euler a el numero de xi negativo
                    if (datosecuacion[0] == "")//verificamos si en la posicion 0 de el array esta vacio si es asi
                    {
                        exponente = exponente * 1;//se muultiplica el resultado del numero de euler elevado a xinegativo por 1 dejando el mismo valor
                    }
                    else//de lo contrario
                    {
                        if (datosecuacion[0] == "-")//se verifica si en la posicion 0 del array exista un "-" si es asi
                        {
                            exponente = exponente * -1;//se multiplica el resultado "exponente" por menos 1 dandonos el mismo valor pero en negativo
                        }
                    }

                    Valor += exponente;//le sumamos a la variable res su valor mas el resultado 
                }
                else
                {   //if que verifica si el numero de euler fue utilizado en estado positivo
                    if(elementos[i].Contains('e') && elementos[i].Contains('^') && elementos[i].Contains('x'))
                    {
                        string[] exp = elementos[i].Split('e', '^', 'x');
                        exponente = Math.Pow(euler, Xi);
                        if (exp[0] == "")
                        {
                            exponente = exponente * 1;
                        }
                        else
                        {
                            if (exp[0] == "-")
                            {
                                exponente = exponente * -1;
                            }
                        }

                        Valor += exponente;
                    }
                    else
                    {
                        //evento que verifica si se deve de elevar a una exponente
                        if (elementos[i].Contains('x') && elementos[i].Contains('^'))
                        {
                            string[] exp = elementos[i].Split('x', '^');
                            exponente = Math.Pow(Xi, double.Parse(exp[2]));
                            if (exp[0] == "-")
                            {
                                exponente = exponente * -1;
                            }
                            else
                            {
                                if (exp[0] == "")
                                {
                                    exponente = exponente * 1;
                                }
                                else
                                {
                                    exponente = exponente * double.Parse(exp[0]);//se multiplica el resultado por el numero que contenga la posicion 0 del array
                                }
                            }
                            Valor += exponente;
                        }
                        else
                        {   //evento de x sin elevar a exponente
                            if (elementos[i].Contains('x') && !elementos[i].Contains('^'))
                            {
                                string[] mult = elementos[i].Split('x');
                                if (mult[0] == "")
                                {
                                    Multiplicar = 1 * Xi;
                                }
                                else
                                {
                                    if (mult[0] == "-")
                                    {
                                        Multiplicar = -1 * Xi;
                                    }
                                    else
                                    {
                                        Multiplicar = double.Parse(mult[0]) * Xi;
                                    }
                                }
                                Valor += Multiplicar;
                            }
                            else
                            {
                                if (!elementos[i].Contains('x') && !elementos[i].Contains('^') && elementos[i] != "0")
                                {
                                    double a = double.Parse(elementos[i]);
                                    Valor += a;
                                }
                                else
                                {
                                    if (elementos[i] == "0")
                                    {
                                        Valor += 0;
                                    }
                                }
                            }
                        }
                    }
                 
                    
                }     
            }
            return Valor; //devolvemos el valor de res
        }
    }
}
