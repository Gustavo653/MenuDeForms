using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIngles
{
    public partial class FormLaptop : Form
    {
        public FormLaptop()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Form1 newForm1 = new Form1();
            newForm1.Show();
            this.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Buy the following laptop" +
                $"\n • Amount of RAM: {textBox1.Text}" +
                $"\n • CPU model: {textBox2.Text}" +
                $"\n • GPU model: {textBox3.Text}" +
                $"\n • PSU model: {textBox4.Text}" +
                $"\n • Display model: {textBox5.Text}" +
                $"\n • Webcam model: {textBox6.Text}"
                , "Your form is ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
