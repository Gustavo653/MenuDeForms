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
    public partial class FormClassroom : Form
    {
        public FormClassroom()
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
              $"\n • Amount of students: {textBox1.Text}" +
              $"\n • Size of the classroom: {textBox2.Text}ft²" +
              $"\n • Amount of PC's: {textBox3.Text}" +
              $"\n • Amount of books: {textBox4.Text}" +
              $"\n • Room number: {textBox5.Text}" +
              $"\n • Teacher's name: {textBox6.Text}"
              , "Your form is ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
