using System;
using System.Windows.Forms;

namespace ProjetoIngles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (VerifyMsgBox.MsgBoxLoad == false)
            {
                MessageBox.Show("Welcome to the Universal Form 3000!", "Universal Form 3000", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VerifyMsgBox.MsgBoxLoad = true;
            }
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Choose a form to fill it. \n" +
                "The following forms are avaliable: \n • Car \n • Person \n • Building \n • Classroom \n • Laptop", "Avaliable forms", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSchForm_Click(object sender, EventArgs e)
        {
            string formReceived = cbbChoice.Text;
            if (formReceived == "Car")
            {
                FormCar newFormCar = new FormCar();
                newFormCar.Show();
                this.Visible = false;
            }
            else if (formReceived == "Person")
            {
                FormPerson newFormPerson = new FormPerson();
                newFormPerson.Show();
                this.Visible = false;
            }
            else if (formReceived == "Building")
            {
                FormBuilding newFormBuilding = new FormBuilding();
                newFormBuilding.Show();
                this.Visible = false;
            }
            else if (formReceived == "Classroom")
            {
                FormClassroom newFormClassroom = new FormClassroom();
                newFormClassroom.Show();
                this.Visible = false;
            }
            else if (formReceived == "Laptop")
            {
                FormLaptop newFormLaptop = new FormLaptop();
                newFormLaptop.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Choose a form!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    public static class VerifyMsgBox
    {
        public static bool MsgBoxLoad { get; set; }
    }
}
