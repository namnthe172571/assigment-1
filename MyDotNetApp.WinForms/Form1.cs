public Form1()
{
    InitializeComponent();

    Button btnHello = new Button();
    btnHello.Text = "Click me";
    btnHello.Width = 120;
    btnHello.Height = 40;
    btnHello.Top = 50;
    btnHello.Left = 50;

    btnHello.Click += (sender, e) =>
    {
        MessageBox.Show("xin chào");
    };

    this.Controls.Add(btnHello);
}
