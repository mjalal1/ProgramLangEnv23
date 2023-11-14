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

        /// <summary>
        /// Handles the Paint event of the outputWindow control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void outputWindow_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(OutBmp, 0, 0);
        }

        /// <summary>
        /// Saves program in programWindow to the project folder.
        /// </summary>
        /// <param name="path">The file name.</param>
        public void Save(String path)
        {
            File.WriteAllText(path + ".txt", programWindow.Text);
        }

        /// <summary>
        /// Loads the file from project folder.
        /// </summary>
        /// <param name="path">The file name.</param>
        public void LoadFile(String path)
        {
            string FileText = File.ReadAllText(path + ".txt");
            programWindow.Text = FileText;

        }


        /// <summary>
        /// Handles the use of the commandLine.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyEventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Closes the program.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

