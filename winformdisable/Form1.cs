using System;

namespace winformdisable;


public partial class Form1 : Form
{
    TextBox inputBox1,inputBox2;
    Button add;
    Label output;

    public Form1()
    {
        InitializeComponent();
        CreateUI();
    }

    void CreateUI()
    {
        this.Width = 400;
        this.Height = 300;
        this.Text = "My Calculator App";
        this.BackColor = Color.AliceBlue;

        // Create a text box
        inputBox1 = new TextBox();
        inputBox1.Top = 40;
        inputBox1.Left = 50;
        // inputBox1.Enabled = false;
        inputBox1.Enabled = true;
        inputBox1.Width = 200;
        this.Controls.Add(inputBox1);

        inputBox2 = new TextBox();
        inputBox2.Top = 80;
        inputBox2.Left = 50;
        inputBox2.Width = 200;
        this.Controls.Add(inputBox2);

        add = new Button();
        add.Text = "Add";
        add.Top = 120;
        add.Left = 50;
        add.Click += add_btn;

        output = new Label();
        output.Top = 160;  
        output.Left = 50;
        output.Text = "Here is your Output";
        this.Controls.Add(output);

         void add_btn(object sender, EventArgs e)
        {
            int num1 = int.Parse(inputBox1.Text);
            int num2 = int.Parse(inputBox2.Text);
            int sum = num1 + num2;
            output.Text = "The Addition is: " + sum;
        }

        // this will disable the input in textbox.
        // this will enable the input in textbox.
        // this will change the width of textbox.
        // this will add textbox to the form1
    }
}

