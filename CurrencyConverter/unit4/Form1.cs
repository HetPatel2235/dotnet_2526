namespace unit4;

public partial class Form1 : Form
{
    TextBox inputBox1;

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

        // this will disable the input in textbox.
        // this will enable the input in textbox.
        // this will change the width of textbox.
        // this will add textbox to the form1
    }
}