using System;

namespace ConsoleLib
{
    public abstract class Shell : Composite
    {
        protected Display Display;

        public string Title;

        protected Shell() { }

        public Shell(Display display) 
        {
            Display = display;
        }

     
    }
}
