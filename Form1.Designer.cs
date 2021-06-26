
namespace ProjetoIngles
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnInstructions = new System.Windows.Forms.Button();
            this.btnSchForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbbChoice = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnInstructions
            // 
            this.btnInstructions.Location = new System.Drawing.Point(123, 35);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(80, 23);
            this.btnInstructions.TabIndex = 2;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // btnSchForm
            // 
            this.btnSchForm.Location = new System.Drawing.Point(232, 35);
            this.btnSchForm.Name = "btnSchForm";
            this.btnSchForm.Size = new System.Drawing.Size(80, 23);
            this.btnSchForm.TabIndex = 1;
            this.btnSchForm.Text = "Search Form";
            this.btnSchForm.UseVisualStyleBackColor = true;
            this.btnSchForm.Click += new System.EventHandler(this.btnSchForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose what form you want to fill ->";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 35);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbbChoice
            // 
            this.cbbChoice.FormattingEnabled = true;
            this.cbbChoice.Items.AddRange(new object[] {
            "Car",
            "Person",
            "Building",
            "Laptop",
            "Classroom"});
            this.cbbChoice.Location = new System.Drawing.Point(221, 6);
            this.cbbChoice.Name = "cbbChoice";
            this.cbbChoice.Size = new System.Drawing.Size(91, 23);
            this.cbbChoice.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 73);
            this.Controls.Add(this.cbbChoice);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSchForm);
            this.Controls.Add(this.btnInstructions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Universal Forms 3000";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Button btnSchForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbbChoice;
    }
}

