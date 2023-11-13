namespace PLE23
{
    public partial class Form1 : Form
    {

        const int bmpx = 640;
        const int bmpy = 480;
        Bitmap OutBmp = new Bitmap(bmpx, bmpy);
        CanvasO Canvas;
        public Form1()
        {
            InitializeComponent();
            Canvas = new CanvasO(Graphics.FromImage(OutBmp));
        }

        private void outputWindow_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(OutBmp, 0, 0);
        }

        private void commandLine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String Command = commandLine.Text.Trim().ToLower();
                if (Command.Equals("line"))
                {
                    Canvas.DrawLine(10, 40);
                    Console.WriteLine("Line drew");
                }
            }
            Refresh();
        }
    }
}