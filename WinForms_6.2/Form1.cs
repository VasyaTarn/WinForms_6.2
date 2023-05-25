namespace WinForms_6._2
{
    public partial class Form1 : Form
    {
        //DateTime startmoment;
        private double count = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 50;
            timer1.Enabled = true;
            timer1.Start();


        }

        private void timer1_Tick(object? sender, EventArgs e)
        {
            //TimeSpan ms = DateTime.Now - startmoment;
            //count += ms.Milliseconds;
            count += 50;
            this.Text = count.ToString();
        }

    }
}