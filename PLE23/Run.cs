using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLE23
{
    class Run : Command
    {
        Parser p;
        Form1 form;
        public override string cmdType()
        {
            return "run";
        }

        public void set(Form1 form)
        { this.form = form;
            this.p = new Parser(form); //new parser created. this.form?
        }
        public override void execute()
        {
            p.ParseCommand(form.programWindow.Text);
        }

        public override string infoParams()
        {
            return "run takes no parameters !";
        }

        public override int parameters()
        {
            return 0;
        }
    }
}
