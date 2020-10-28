using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Ecuaciones_no_lineales
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }
        //accion que nos permite manupular la barra de titulo 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //metodo que hace que aparesca un form dento de un panel 
        private void AbrirFormInPanel(object formHijo)
        {
            if (this.Panel_Contenedor.Controls.Count > 0)
            {
                this.Panel_Contenedor.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Panel_Contenedor.Controls.Add(fh);
            this.Panel_Contenedor.Tag = fh;
            fh.Show();
        }
        /**********************************VENTANA**********************************************************************************/
        //accion que permite mover de lado la barra de titulo y toda la pestaña
        private void Panel_Titulo_Principal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Lbl_Titulo_Principal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //evento para sali de la aplicacion 
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //evento para minimizar la aplicacion
        private void PictureBox_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pictureBox_Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        //hacemos que el panel contendero inicie con la portada
        private void home_Load(object sender, EventArgs e)
        {
            AbrirFormInPanel(new portadacs());
        }
        /**************************************BOTONES*******************************************************************************/
        //abre el form de metodo de la secante
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Metodo_de_la_secante());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new portadacs());
        }
        /********************************************************************************************************************/
    }
}
