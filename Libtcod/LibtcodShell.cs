using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleLib;

namespace Libtcod
{
    class LibtcodShell : Shell
    {
        LibtcodDisplay LibtcodDisplay;
        public LibtcodShell(String title, int width, int height)
            : this(new LibtcodDisplay(title, width, height))
        {
        }
        LibtcodShell(LibtcodDisplay display)
            : base(display)
        {
            LibtcodDisplay = display;
        }
    }
}
