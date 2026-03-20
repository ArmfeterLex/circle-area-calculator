namespace wf321
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int r = trackBar1.Value;
            textBox1.Text = Convert.ToString(r);
            textBox2.Text = Convert.ToString(Math.PI*r*r);

        }
    }
}
