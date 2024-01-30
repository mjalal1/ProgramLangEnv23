using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace PLE23
{
    class Save : Command, StringCmd
    {
        Form1 form;
        string path;
        public override string cmdType()
        {
            return "string";
        }

        public override string infoParams()
        {
            return "save takes 1 parameter: filepath" ;
        }

        public override int parameters()
        {
            return 1;
        }

        public Save():base() { } // command needs a constructor. execute() calling 
        public void set(Form1 forma, string value)
        {
            this.form = forma;
            this.path = value;
        }

        public override void execute()
        {
            File.WriteAllText(path + ".txt", form.programWindow.Text);
        }
    }
}
