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
    public partial class FormCar : Form
    {
        public FormCar()
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
            MessageBox.Show($"Print the following information" +
            $"\n • Car model: {textBox1.Text}" +
            $"\n • Car fuel: {textBox2.Text}" +
            $"\n • Year of purchase: {textBox3.Text}" +
            $"\n • Amount of fines: {textBox4.Text}" +
            $"\n • License plate: {textBox5.Text}" +
            $"\n • Owner's name: {textBox6.Text}"
            , "Your form is ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
