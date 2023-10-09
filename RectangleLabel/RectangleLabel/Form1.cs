namespace RectangleLabel
{
    public partial class Form1 : Form
    {
        int x;
        int y;
        int x_1;
        int y_1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            x_1 = e.X;
            y_1 = e.Y;

            if (Math.Abs(x_1 - x) < 10 && Math.Abs(y_1 - y) < 10)
            {
                MessageBox.Show("Less than 10x10 size");
            }

            else
            {
                Label label = new Label();
                label.Text = "LABEL";

                label.BackColor = Color.Black;
                label.ForeColor = Color.White;
                label.Size = new Size(Math.Abs(x_1 - x), Math.Abs(y_1 - y));

                label.Location = new Point(x, y);

                Controls.Add(label);
            }
        }

       
    }
}