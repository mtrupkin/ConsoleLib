using System;

using ConsoleLib;
using libtcod;

namespace Libtcod
{
    class LibtcodShell : Shell
    {
        protected string title;

        public void SetTitle(string title) {
            TCODConsole.setWindowTitle(title); 
        }

        LibtcodDisplay LibtcodDisplay;

        public LibtcodShell(String title, int width, int height)
        {
            TCODConsole.initRoot(width, height, title, false, TCODRendererType.SDL);
            TCODConsole.root.setBackgroundColor(TCODColor.black);
            TCODConsole.root.setForegroundColor(TCODColor.white);
            TCODConsole.root.setKeyColor(TCODColor.red);
            TCODConsole.root.clear();

            TCODSystem.setFps(24);

            LibtcodDisplay = new LibtcodDisplay(TCODConsole.root);
        }
    }
}
