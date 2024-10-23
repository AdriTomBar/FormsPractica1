using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonInsertarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                pictureBoxFoto.Image = Image.FromFile(ofd.FileName);
            }
        }


        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxDireccion.Text = string.Empty;
            textBoxNombre.Text = string.Empty;
            comboBox1.Text = string.Empty;
            pictureBoxFoto.Image = null;

        }

        private void BotoonValidar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "" || textBoxDireccion.Text == "" || comboBox1.Text == "" || pictureBoxFoto == null)
            {
                MessageBox.Show("No has introducido todos los datos");
            }
            else MessageBox.Show("Validacion completada correctamente");
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labeFoto_Click(object sender, EventArgs e)
        {

        }

        private void labelCiudad_Click(object sender, EventArgs e)
        {

        }

        private void labelDireccion_Click(object sender, EventArgs e)
        {

        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxFoto_Click(object sender, EventArgs e)
        {

        }
    }
}
