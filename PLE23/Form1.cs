using System.IO;

namespace PLE23
{
    public partial class Form1 : Form
    {

        const int bmpx = 640;
        const int bmpy = 480;
        Bitmap OutBmp = new Bitmap(bmpx, bmpy);
        public CanvasO Canvas;
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
        public void Save(String path)
        {
            File.WriteAllText(path + ".txt", programWindow.Text);
        }


        public void LoadFile(String path)
        {
            string FileText = File.ReadAllText(path + ".txt");
            programWindow.Text = FileText;

        }

        public void commandLine_KeyDown(object sender, KeyEventArgs e)
        {
            Parser p = new Parser(this);
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    p.ParseCommand(commandLine.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.Message);
                }
                Refresh();

            }

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

