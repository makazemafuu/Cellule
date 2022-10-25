namespace Cell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void pnl_cell_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.pnl_cell.CreateGraphics();
            SolidBrush myBrush = new SolidBrush(Color.Black);
            g.FillEllipse(myBrush, 450, 400, 20, 20);
            myBrush.Dispose();
            g.Dispose();
        }
        private void btn_simulation_Click(object sender, EventArgs e)
        {

        }
        private void btn_simulation_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}