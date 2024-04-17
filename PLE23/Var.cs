using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PLE23
{
    class Var : Declarations
    {
        int? found;
        int value;
        public override int? checkFor(Form1 form, string param)
        {


            if (form.varName.Contains(param))
            { found = form.varName.FindIndex(a => a.Contains(param)); }    //IndexOf checks for the value then returns the index if found
            if (found == -1) { found = null; return found; }
            return found;
        }

        public override void declare(string param)
        {

            if (checkFor(form, name).Equals(null))
            {
                form.varName.Add(name);
                form.varValue.Add(0);
            }
          
        }

        public void setVal(string name, int value)
        {
            int? index = checkFor(form, name);
            if (index >= 0)
            {
                this.value = value;
                form.varValue[(int)index] = (value);
            }
        }

        public override void execute()
        {
            throw new NotImplementedException();
        }

        public override void set(Form1 form, string name)
        {
            this.form = form;
            this.name = name;
        }

        public override string infoParams()
        {
            throw new NotImplementedException();
        }

        public override int parameters()
        {
            return 1;
        }
    }
}
