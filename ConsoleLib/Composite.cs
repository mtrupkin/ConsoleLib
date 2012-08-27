using System;

namespace ConsoleLib
{
    public class Composite : Control
    {
        protected Composite()
        {
        }

        public Composite(Composite parent):base(parent) {
        }

        public void AddControl(Control control) {}
    }
}
