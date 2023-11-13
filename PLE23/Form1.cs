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

        public void ParseCommand(String line)
        {

            line = line.Trim().ToLower();  //trim excess and bring everything into same case
            string[] com = line.Split(' ');   //Split into command and parameters
            string command = com[0]; //Assign command to a variable
            List<int> Param = new List<int>(); // Create list of integers to store parameters after conversion
                                               //  String[] Params = new string[];

            if (com.Length > 1)
            {
                string[] Params = com[1].Split(',');

                // Assign chunk of whole parameter to a string to further split
                //Split whole parameter string into array of parameter strings


                foreach (string i in Params) // Iterate through each parameter in string form and convert to int
                {
                    int a; // Variable to hold integer output

                    int.TryParse(i, out a); // TryParse the string as int - surround with try catch
                    Param.Add(a); //Add int to list of parameters
                }



            }

            if (command.Equals("drawto"))
                {
                    if (Param.Count() == 2)
                    {


                        Canvas.DrawTo(Param[0], Param[1]);
                        MessageBox.Show("Params are " + Param[0] + Param[1]);
                        Console.WriteLine("Line drew");


                    }
                    else
                    {
                        MessageBox.Show("Invalid Parameters : drawTo takes 2 parameters : x and y");
                    }
                }

                if (command.Equals("moveto"))
                {
                    if (Param.Count() == 2)
                    {


                        Canvas.MoveTo(Param[0], Param[1]);




                    }
                    else
                    {
                        MessageBox.Show("Invalid Parameters : moveTo takes 2 parameters : x and y");
                    }
                }

                else if (command.Equals("rect"))
                {
                    if (Param.Count() == 2)
                    {
                        Canvas.DrawRect(Param[0], Param[1]);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Parameters : Rect takes 2 parameters : length and height");
                    }

                }
                else if (command.Equals("circle"))
                {
                    if (Param.Count() == 1)
                    {
                        Canvas.DrawCircle(Param[0]);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Parameters : Circle takes 1 parameter: radius");
                    }
                }
                else if (command.Equals("triangle"))
                {
                    if (Param.Count() == 6)
                    {
                        Canvas.DrawTriangle(Param[0], Param[1], Param[2], Param[3], Param[4], Param[5]);


                    }
                    else
                    {
                        MessageBox.Show("Invalid Parameters : Triangle takes 6 parameters : x1,y1, x2,y2, x3,y3");
                    }
                }
                else if (command.Equals("clear"))
                {
                    Canvas.clear();
                }
            else if (command.Equals("reset"))
            {
                Canvas.reset();
            }
            else if (command.Equals("fill"))
            {
                if (com.Length > 1)
                {
                    if (com[1] == "on" || com[1] == "off")
                    {
                        Canvas.fill(com[1]);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Parameters : fill takes 1 parameter: on/off ");
                    }
                }
            }

        }

        



        public void commandLine_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                ParseCommand(commandLine.Text);
                Refresh();
            }

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
