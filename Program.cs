using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//nim: 103022300030
namespace mod3_KPL
{
    public class MainForm : Form
    {
        private TextBox inputTextBox;
        private Button submitButton;
        private Label outputLabel;

        public MainForm()
        {
            this.Text = "Simple GUI";
            this.Size = new System.Drawing.Size(400, 200);

            inputTextBox = new TextBox();
            inputTextBox.Location = new System.Drawing.Point(20, 20);
            inputTextBox.Width = 250;

            submitButton = new Button();
            submitButton.Text = "Submit/Kirim";
            submitButton.Location = new System.Drawing.Point(280, 18);
            submitButton.Click += new EventHandler(SubmitButton_Click);

            outputLabel = new Label();
            outputLabel.Location = new System.Drawing.Point(20, 60);
            outputLabel.AutoSize = true;

            this.Controls.Add(inputTextBox);
            this.Controls.Add(submitButton);
            this.Controls.Add(outputLabel);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string inputText = inputTextBox.Text;
            outputLabel.Text = $"Halo {inputText}";
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
