using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLE23
{
    public class Parser
    {
        public Form1 form;
        public Parser(Form1 form)
        {
            this.form = form;
        }

        public void ParseCommand(String line)
        {

            line = line.Trim().ToLower();  //trim excess and bring everything into same case
            string[] comLine = line.Split('\n');
            for (int x = 0; x < comLine.Length; x++)
            {



                string[] com = comLine[x].Split(' ');
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


                        form.Canvas.DrawTo(Param[0], Param[1]);
                        form.labelDrawCountVal.Text = form.Canvas.drawCount.ToString();



                    }
                    else
                    {
                        throw new ApplicationException("Invalid Parameters : drawTo takes 2 parameters : x and y");
                    }
                }

               else if (command.Equals("moveto"))
                {
                    if (Param.Count() == 2)
                    {


                        form.Canvas.MoveTo(Param[0], Param[1]);




                    }
                    else
                    {
                        throw new ApplicationException("Invalid Parameters : moveTo takes 2 parameters : x and y");
                    }
                }

                else if (command.Equals("rect"))
                {
                    if (Param.Count() == 2)
                    {
                        form.Canvas.DrawRect(Param[0], Param[1]);
                        form.labelDrawCountVal.Text = form.Canvas.drawCount.ToString();
                    }
                    else
                    {
                        throw new ApplicationException("Invalid Parameters : Rect takes 2 parameters : length and height");
                    }

                }
                else if (command.Equals("circle"))
                {
                    if (Param.Count() == 1)
                    {
                        form.Canvas.DrawCircle(Param[0]);
                        form.labelDrawCountVal.Text = form.Canvas.drawCount.ToString();
                    }
                    else
                    {
                        throw new ApplicationException("Invalid Parameters : Circle takes 1 parameter: radius");
                    }
                }
                else if (command.Equals("triangle"))
                {
                    if (Param.Count() == 6)
                    {
                        form.Canvas.DrawTriangle(Param[0], Param[1], Param[2], Param[3], Param[4], Param[5]);
                        form.labelDrawCountVal.Text = form.Canvas.drawCount.ToString();


                    }
                    else
                    {
                        throw new ApplicationException("Invalid Parameters : Triangle takes 6 parameters : x1,y1, x2,y2, x3,y3");
                    }
                }
                else if (command.Equals("clear"))
                {
                    form.Canvas.clear();
                    form.labelDrawCountVal.Text = form.Canvas.drawCount.ToString(); // get/set change to priv
                }
                else if (command.Equals("reset"))
                {
                    form.Canvas.reset();
                }
                else if (command.Equals("save"))
                {
                    if (com.Length > 1)
                    {
                        form.Save(com[1]);
                    }
                    else
                    {
                        throw new ApplicationException("Invalid Parameters : Save takes 1 parameter: filename");
                    }
                }
                else if (command.Equals("load"))
                {
                    if (com.Length > 1)
                    {
                        form.LoadFile(com[1]);
                    }
                    else
                    {
                        throw new ApplicationException("Invalid Parameters : Load takes 1 parameter: filename");
                    }
                }
                else if (command.Equals("fill"))
                {
                    if (com.Length > 1)
                    {
                        if (com[1] == "on" || com[1] == "off")
                        {
                            form.Canvas.fill(com[1]);
                        }
                        else
                        {
                            throw new ApplicationException("Invalid Parameters : fill takes 1 parameter: on/off ");
                        }

                    }

                    else
                    {
                        throw new ApplicationException("Invalid Parameters : fill takes 1 parameter: on/off ");
                    }

                }

                else if (command.Equals("pen"))
                {
                    if (com.Length > 1)
                    {

                        form.Canvas.pen(com[1]);
                        Console.WriteLine(com[1]);

                    }
                    else
                    {
                        throw new ApplicationException("Invalid Parameters : pen takes 1 parameter: colour (red/blue/green/pink/purple/black) ");
                    }
                }
                else if (command.Equals("run"))
                {
                    ParseCommand(form.programWindow.Text);
                }

                else
                {
                    throw new ApplicationException("Command not recognised. Valid Commands: rect,triangle,circle,drawTo,moveTo,reset,clear,pen,fill");
                }


            }
        }
    }
}
