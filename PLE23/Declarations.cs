using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLE23
{
     abstract class Declarations : Command
    {

        protected Form1 form;
        protected string name;
        public abstract int? checkFor(Form1 form, string param);
        public abstract void declare(string param);
        public abstract void set(Form1 f, string name);

        public override string cmdType()
        {
            return "declare";
        }



    }
}
