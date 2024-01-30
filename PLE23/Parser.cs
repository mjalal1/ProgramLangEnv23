using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PLE23
{
    /// <summary>
    /// This class is used to parse lines of code from the application and executes the relevant command
    /// </summary>
    public class Parser
    {
        public Form1 form;
        public Parser(Form1 form)
        {
            this.form = form;
        }

        /// <summary>This method parses the string given to it into command and parameters, and executes the given command</summary>
        /// <param name="line">Line of code to be parsed. 'command' + 'parameter(s)'</param>
        public void ParseCommand(String line)
        {
            Regex strCom = new Regex("save|load|pen|fill"); //List of commands which take string parameters to check against
            string infoParams; //Information on command parameters
            line = line.Trim().ToLower();  //Trim excess and bring everything into same case
            string[] comLine = line.Split('\n');    //Split text into lines of code


            if (comLine.Length > 1)
            {
                for (int x = 0; x < comLine.Length; x++) // Removing \r from end of string ???
                { comLine[x] = comLine[x].Remove(comLine[x].Length - 1, 1); }
            }



            for (int x = 0; x < comLine.Length; x++) // Iterate on each line of code
            {



                string[] com = comLine[x].Split(' ');       //Split line into command and parameters
                string command = com[0];                    //Assign command to a variable
                List<int> Param = new List<int>();          // Create list of integers to store parameters after conversion


                if (com.Length > 1)                  // If there are parameters, continue sorting through
                {
                    string[] Params = com[1].Split(',');    //Split whole parameter string into array of parameter strings

                    foreach (string i in Params)                  // Iterates through each parameter in string form and convert to int
                    {
                        int a;                                            // Variable to hold integer output

                        bool paramCheck = int.TryParse(i, out a);         // TryParse the string as int - if bool is true params are numerical, if bool is false params are strings
                        if (paramCheck)
                        { Param.Add(a); }                                //Add int to list of parameters 

                        else if ((com[0] == "clear" || com[0] == "reset" || com[0] == "run") && com.Length > 1)     //If command takes no parameters yet there are some...
                        {
                            infoParams = "Command {0} takes no parameters";
                            throw new Exc.InvalidParametersException(com, infoParams);
                        }
                        else if (strCom.IsMatch(com[0]) && paramCheck)                                              //If command takes string parameters and parameter is numerical...
                        {
                            infoParams = "Command {0} takes string parameters not numbers";
                            throw new Exc.InvalidParametersException(com, infoParams);
                        }
                        else if (!strCom.IsMatch(com[0]) && !paramCheck)                                         //If command takes numerical params and parameter is string... 
                        {
                            infoParams = "Command {0} takes numerical parameters not strings";
                            throw new Exc.InvalidParametersException(com, infoParams);
                        }

                    }



                }

                ///Command Execution handled below
                ShapeFactory sf = new ShapeFactory();
                dynamic shapeCom = sf.GetCmd(command); // I chose to use a dynamic variable as I know the object types coming out of the factory, performance is not a primary concern, and it allows nicer syntax below 

                if (shapeCom.cmdType() == "draw")
                {
                    if (Param.Count() == shapeCom.parameters())
                    {
                        shapeCom.set(form.Canvas, Param.ToArray());
                        shapeCom.execute();
                        form.labelDrawCountVal.Text = form.Canvas.drawCount.ToString();
                    }
                    else { throw new Exc.InvalidParametersException(com, shapeCom.infoParams()); }
                }
                else if (shapeCom.cmdType() == "string")
                {
                    if ((com.Length)-1 == shapeCom.parameters())
                    {
                        shapeCom.set(form, com[1]);
                        shapeCom.execute();
                       // form.labelDrawCountVal.Text = form.Canvas.drawCount.ToString();
                    }
                    else { throw new Exc.InvalidParametersException(com, shapeCom.infoParams()); }
                }


                if (command.Equals("drawto"))
                {
                    infoParams = " drawTo takes 2 parameters : x and y";       // Setting Parameter information
                    if (Param.Count() == 2)
                    {


                        form.Canvas.DrawTo(Param[0], Param[1]);
                        form.labelDrawCountVal.Text = form.Canvas.drawCount.ToString();



                    }
                    else
                    {

                        throw new Exc.InvalidParametersException(com, infoParams);


                    }
                }

                else if (command.Equals("moveto"))
                {
                    infoParams = "moveTo takes 2 parameters : x and y";
                    if (Param.Count() == 2)
                    {


                        form.Canvas.MoveTo(Param[0], Param[1]);




                    }
                    else
                    {
                        throw new Exc.InvalidParametersException(com, infoParams);

                    }
                }

                else if (command.Equals("rect"))
                {
                    infoParams = "rect takes 2 parameters : length and height";
                    if (Param.Count() == 2)
                    {
                        // form.Canvas.DrawRect(Param[0], Param[1]);
                        form.labelDrawCountVal.Text = form.Canvas.drawCount.ToString();
                    }
                    else
                    {
                        throw new Exc.InvalidParametersException(com, infoParams);

                    }

                }
                else if (command.Equals("circle"))
                {
                    infoParams = "circle takes 1 parameter: radius";
                    if (Param.Count() == shapeCom.parameters())
                    {


                        //  form.Canvas.DrawCircle(Param[0]);
                        //  form.labelDrawCountVal.Text = form.Canvas.drawCount.ToString();
                    }
                    else
                    {
                        throw new Exc.InvalidParametersException(com, infoParams);

                    }
                }
                else if (command.Equals("triangle"))
                {
                    infoParams = "triangle takes 6 parameters : x1,y1, x2,y2, x3,y3";
                    if (Param.Count() == 6)
                    {
                        // form.Canvas.DrawTriangle(Param[0], Param[1], Param[2], Param[3], Param[4], Param[5]);
                        // form.labelDrawCountVal.Text = form.Canvas.drawCount.ToString();


                    }
                    else
                    {
                        throw new Exc.InvalidParametersException(com, infoParams);

                    }
                }
                else if (command.Equals("clear"))
                {
                    // form.Canvas.clear();
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
                        throw new Exc.InvalidParametersException(com, "Save takes 1 parameter: filename");

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
                        throw new Exc.InvalidParametersException(com, "Load takes 1 parameter: filename");

                    }
                }
                else if (command.Equals("fill"))
                {
   

                }

                else if (command.Equals("pen"))
                {
                    if (com.Length > 1)
                    {

                        form.Canvas.pen(com[1]);


                    }
                    else
                    {
                        throw new Exc.InvalidParametersException(com, "pen takes 1 parameter: colour (red/blue/green/pink/purple/black) ");

                    }
                }
                else if (command.Equals("run"))
                {
                    ParseCommand(form.programWindow.Text);
                }

                else
                {
                    throw new Exc.InvalidCommandException(com);

                }


            }
        }
    }
}
