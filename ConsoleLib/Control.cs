using System;

namespace ConsoleLib
{
    public class Control
    {
        public Composite Parent;

        protected Control()
        {
        }

        public Control(Composite parent)  
        {
            Parent = parent;
        }

        public Shell Shell() { return Parent.Shell(); }

        void Render() {}
    }
}
