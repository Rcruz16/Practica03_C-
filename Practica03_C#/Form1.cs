namespace Practica03_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Ftc_Click(object sender, EventArgs e)
        {
            float F = float.Parse(tbx1.Text);
            float C = (F - 32) * 5.0f / 9.0f;
            tbx2.Text = C.ToString();
        }

        private void btn_Ctf_Click(object sender, EventArgs e)
        {
            float C = float.Parse(tbx2.Text);
            float F = (C * 9f / 5f) + 32;
            tbx1.Text = F.ToString();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tbx1.Text = "";
            tbx2.Text = "";
        }
    }
}