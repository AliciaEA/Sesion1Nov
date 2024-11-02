using MetroFramework;
using Sesion11.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion11
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        
        public Form1()
        {
            InitializeComponent();
            
            timer1.Interval = 100;
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            timer1.Start();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1.0)
            {
                Opacity += 0.05; // Incrementa la opacidad en 0.2
                Size = new Size(Size.Width + 40, Size.Height + 40); // Incrementa el tamaño del formulario
            }
            else
            {
                timer1.Stop(); // Detiene el temporizador cuando la opacidad es 1.0
                WindowState = FormWindowState.Maximized; // Maximiza el formulario
            }





        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Opacity = 0;
           
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            UserManager user = new UserManager();
            if (user.Autenticar(TxtUser.Text, TxtPw.Text))
            {
                MetroMessageBox.Show(this, "Usuario autenticado", "Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MetroMessageBox.Show(this, "Usuario no autenticado", "Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
