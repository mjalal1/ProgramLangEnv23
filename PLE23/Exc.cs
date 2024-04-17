using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLE23
{
    /// <summary>
    /// Class for custom exceptions
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class Exc : Exception
    {
        /// <summary>
        /// Exception thrown for invalid commands
        /// </summary>
        /// <seealso cref="System.Exception" />
        public class InvalidCommandException : Exception
        {
            public InvalidCommandException() { }

            public InvalidCommandException(string[] com)
                : base(String.Format("Invalid command: {0}\nValid commands include: rect,triangle,circle,drawTo,moveTo,reset,clear,pen,fill,save,load,run", com[0]))
            {

            }

            public InvalidCommandException(string cmd) //Fac
                : base(String.Format("Invalid command: {0}\nValid commands include: rect,triangle,circle,drawTo,moveTo,reset,clear,pen,fill,save,load,run", cmd))
            {

            }
        }

        /// <summary>
        /// Exception thrown for invalid parameters
        /// </summary>
        /// <seealso cref="System.Exception" />
        public class InvalidParametersException : Exception
        {
            public InvalidParametersException() { }

            public InvalidParametersException(string[] com)
               : base(String.Format("Invalid parameters for command '{0}'", com[0]))
            {

            }

            public InvalidParametersException(string command, string param)
             : base(String.Format("Invalid parameters for command '{0}'\n"+param, command))
            {

            }

            public InvalidParametersException(string[] com,string param)
                : base(String.Format("Invalid parameters for command '{0}'\n"+param, com[0]))
            {

            }
        }
    }
}
