﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLE23
{
    public abstract class Command
    {
       public abstract int parameters();
       public abstract string infoParams();
        public abstract string cmdType();
        public abstract void execute();

       public Command() 
        {
            
        }
    }
}
