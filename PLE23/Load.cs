using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLE23
{
     class Load : Command, StringCmd
    {
        Form1 form;
        string path;
        public override string cmdType()
        {
            return "string";
        }

        public override string infoParams()
        {
            return "load takes 1 parameter: filepath";
        }

        public override int parameters()
        {
            return 1;
        }

        public Load(): base() { } // command needs a constructor. execute() calling 
        public void set(Form1 forma, string value)
        {
            this.form = forma;
            this.path = value;
        }

        public override void execute()
        {
            string FileText = File.ReadAllText(path + ".txt");
            form.programWindow.Text = FileText;
        }
    }
}
