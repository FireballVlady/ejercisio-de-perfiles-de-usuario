using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text == "Director" && txtContraseña.Text == "1234")
            {
                this.Hide();
                Director director = new Director();
                director.Show();
                this.Visible = false;
            }

            if (txtUsuario.Text == "Administrativo" && txtContraseña.Text == "1234")
            {
                this.Hide();
                Administrativos administrativos = new Administrativos();
                administrativos.Show();
                this.Visible = false;
            }

            if (txtUsuario.Text == "Tutor" && txtContraseña.Text == "1234")
            {
                this.Hide();
                Tutores tutores = new Tutores();
                tutores.Show();
                this.Visible = false;
            }

            if (txtUsuario.Text == "Docente" && txtContraseña.Text == "1234")
            {
                this.Hide();
                Docentes docentes = new Docentes();
                docentes.Show();
                this.Visible = false;
            }

            if (txtUsuario.Text == "Alumno" && txtContraseña.Text == "1234")
            {
                this.Hide();
                Alumnos alumnos = new Alumnos();
                alumnos.Show();
                this.Visible = false;
            }
        }
    }
}
