using System;
using System.Windows.Forms;
using System.Drawing;

public class ButonulMeu : Button
{
    public ButonulMeu()
        : base()
    {
        this.BackColor = Color.Green;
        this.ForeColor = Color.Red;
        this.Click += new EventHandler(ClickButonulMeu);
    }

    private void ClickButonulMeu(object sender, EventArgs e)
    {
        MessageBox.Show("Click pe butonul meu!");
        Application.Exit();
    }
}

public class FormaMea : Form
{
    private Button btn1;
    private ButonulMeu btn2;
    private TextBox tb1;
    private TextBox tb2;
    private TextBox tb3;

    public FormaMea()
    {
        this.Text = "Formular de test";
        this.Size = new Size(300, 300);

        btn1 = new Button();
        btn1.Text = "Click me";
        btn1.Size = new Size(60, 40);
        btn1.Location = new Point(100, 80);
        btn1.Click += new EventHandler(btn1_Click);
        btn1.Click += new EventHandler(MetodaMea);
        btn1.Click += new EventHandler(Suma);

        tb1 = new TextBox();
        tb1.Size = new Size(60, 20);
        tb1.Location = new Point(100, 20);
        tb1.KeyPress += new KeyPressEventHandler(validare);

        tb2 = new TextBox();
        tb2.Size = new Size(60, 20);
        tb2.Location = new Point(100, 40);

        tb3 = new TextBox();
        tb3.Size = new Size(60, 20);
        tb3.Location = new Point(100, 60);

        btn2 = new ButonulMeu();
        btn2.Text = "Click me";
        btn2.Size = new Size(60, 40);
        btn2.Location = new Point(100, 120);
        //btn2.Click += new EventHandler(btn1_Click);
        //btn2.Click += new EventHandler(MetodaMea);
        //btn2.Click += new EventHandler(Suma);

        Controls.Add(tb1);
        Controls.Add(tb2);
        Controls.Add(tb3);
        Controls.Add(btn1);
        Controls.Add(btn2);
    }

    private void btn1_Click(object sender, EventArgs e)
    {
        MessageBox.Show("S-a facut click pe buton!");
    }

    private void MetodaMea(object sender, EventArgs e)
    {
        btn1.Click -= new EventHandler(btn1_Click);
        MessageBox.Show("Click prin MetodaMea()");
    }

    private void Suma(object sender, EventArgs e)
    {
        try
        {
            tb3.Text = (Convert.ToInt32(tb1.Text) + Convert.ToInt32(tb2.Text)).ToString();

            //Timer t = new Timer();
            //t.Tick += new EventHandler(timerTick);
            //t.Start();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    public void timerTick(object sender, EventArgs e)
    {
        System.Threading.Thread.Sleep(5000);
        Application.Exit();
    }

    public void validare(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar))
            e.Handled = true;
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Formularul ruleaza!");
        Application.Run(new FormaMea());
        Console.WriteLine("Formularul a fost inchis!");
    }
}