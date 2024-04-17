using System;
using System.Collections.Generic;
using System.Data;
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
            Regex strCom = new Regex("save|load|pen|fill|var"); //List of commands which take string parameters to check against
            string infoParams; //Information on command parameters
            line = line.Trim().ToLower();  //Trim excess and bring everything into same case
            string[] comLine = line.Split('\n');    //Split text into lines of code


            if (comLine.Length > 1)
            {
                for (int x = 0; x < comLine.Length - 1; x++) // Removing \r from end of string ???
                { comLine[x] = comLine[x].Remove(comLine[x].Length - 1, 1); }
            }



            for (int x = 0; x < comLine.Length; x++) // Iterate on each line of code
            {



                string[] com = comLine[x].Split(' ');       //Split line into command and parameters
                string command = com[0];                    //Assign command to a variable
                List<int> Param = new List<int>();          // Create list of integers to store parameters after conversion
                bool hasSwapped = false;
                List<string> Variables = new List<string>();
                int intParam;                                            // Variable to hold integer output



                if (com.Length > 1)                  // If there are parameters, continue sorting through
                {
                    string[] Params = com[1].Split(',');    //Split whole parameter string into array of parameter strings
                    foreach (string item in Params)
                    {
                        Variables = item.Split(new Char[] { '+', '-', '*', '/' }).ToList<string>();
                    }
                    string[] Variabless = com[1].Split(new Char[] { ',', '+', '-', '*', '/' });


                    if (com[1].Equals("="))
                    {
                        if (form.varName.Contains(com[0]))       //If it matches a variable name
                        {
                            int v = Convert.ToInt32(new DataTable().Compute(com[2], ""));
                            dynamic c2 = new ShapeFactory().GetCmd(com[1]);
                            c2.set(this.form, command);
                            c2.setVal(command, v);// trycatch throw InvalidParamExc
                        }//InvalidVarExc
                        continue;
                    }
                    for (int i = 0; i < Params.Length; i++)       //For every parameter
                    {

                        if (!strCom.IsMatch(com[0]))
                        {
                            //  for (int n = 0; n <= Params.Length; n++)       //For every parameter
                            // {

                            if (form.varName.Contains(Variabless[i]))       //If it matches a variable name
                            {
                                int found = form.varName.FindIndex(a => a.Contains(Variabless[i]));    //Store index of variable
                                Params[i] = Params[i].Replace(form.varName[found], form.varValue[found].ToString()); //= form.varValue[found].ToString();                           //Swap variable into the string
                                hasSwapped = true;                                                      //Record that a swap has taken place 
                            }

                            if (i == com.Length)    // If we are iterating the final string
                            {
                                string expression = string.Join("", Params[i]);   // Build expression
                                Params[i] = Convert.ToString(new DataTable().Compute(expression, ""));  //Evaluate expression
                                                                                                        // Param.Add(v);      Figure out when to eval n when to add                                  // Add the resulting value to Param which is passed to factory
                            }

                            // }
                        }




                        bool paramCheck = int.TryParse(Params[i], out intParam);         // TryParse the string as int - if bool is true params are numerical, if bool is false params are strings
                        if (paramCheck)
                        { Param.Add(intParam); }                                //Add int to list of parameters 

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
                    if ((com.Length) - 1 == shapeCom.parameters())
                    {
                        shapeCom.set(form, com[1]);
                        shapeCom.execute();
                        // form.labelDrawCountVal.Text = form.Canvas.drawCount.ToString();
                    }
                    else { throw new Exc.InvalidParametersException(com, shapeCom.infoParams()); }
                }
                else if (shapeCom.cmdType() == "run")
                {
                    if ((com.Length) - 1 == shapeCom.parameters())
                    {
                        shapeCom.set(form);
                        shapeCom.execute();
                        form.labelDrawCountVal.Text = form.Canvas.drawCount.ToString();
                    }
                    else { throw new Exc.InvalidParametersException(com, shapeCom.infoParams()); }
                }
                else if (shapeCom.cmdType() == "declare")
                {
                    if ((com.Length) - 1 == shapeCom.parameters())
                    {
                        shapeCom.set(form, com[1]);
                        shapeCom.declare(com[1]);
                    }
                    else { throw new Exc.InvalidParametersException(com, shapeCom.infoParams()); }
                }
            }
        }
    }
}
