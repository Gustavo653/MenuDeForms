using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIngles
{
    public partial class FormBuilding : Form
    {
        public FormBuilding()
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
            try
            {
                double purchPrice = Convert.ToDouble(textBox3.Text);
                double budget = Convert.ToDouble(textBox4.Text);
                MessageBox.Show($"Print the following information" +
            $"\n • Engineer's name: {textBox1.Text}" +
            $"\n • Size: {textBox2.Text}ft²" +
            $"\n • Purchase price: {purchPrice:c}" +
            $"\n • Budget: {budget:c}" +
            $"\n • Runtime: {textBox5.Text}" +
            $"\n • Contractor's name: {textBox6.Text}"
            , "Your form is ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Verify your entrance!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
