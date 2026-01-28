using System;
using System.Windows.Forms;

namespace winform
{
    public partial class Form1 : Form
    {
        TextBox txtA, txtB;
        Button btnAdd, btSubtract;
        Label lblResult;

        public Form1()
        {
            InitializeComponent();
            CreateUI();
        }

        void CreateUI()
        {
            // Form
            this.Text = "Addition and Subtraction App";
            this.Width = 350;
            this.Height = 350;

            // TextBox 1
            txtA = new TextBox();
            txtA.Left = 50;
            txtA.Top = 30;
            txtA.Width = 100;

            // TextBox 2
            txtB = new TextBox();
            txtB.Left = 50;
            txtB.Top = 70;
            txtB.Width = 100;

            // Button
            btnAdd = new Button();
            btnAdd.Text = "Add";
            btnAdd.Left = 50;
            btnAdd.Top = 110;
            btnAdd.Click += BtnAdd_Click;

            //Button 2
            btSubtract = new Button();
            btSubtract.Text = "Subtract";
            btSubtract.Left = 130;
            btSubtract.Top = 110;
            btSubtract.Click += BtnSubtract_Click;

            // Label
            lblResult = new Label();
            lblResult.Left = 50;
            lblResult.Top = 150;
            lblResult.Width = 200;
            lblResult.Text = "Result";

            // Add controls to form
            this.Controls.Add(txtA);
            this.Controls.Add(txtB);
            this.Controls.Add(btnAdd);
            this.Controls.Add(lblResult);
            this.Controls.Add(btSubtract);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txtA.Text);
                int b = Convert.ToInt32(txtB.Text);
                lblResult.Text = "Result = " + (a + b);
            }
            catch
            {
                MessageBox.Show("Enter valid numbers");
            }
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txtA.Text);
                int b = Convert.ToInt32(txtB.Text);
                lblResult.Text = "Result = " + (a - b);
            }
            catch
            {
                MessageBox.Show("Enter valid numbers");
            }
        }
    }
}