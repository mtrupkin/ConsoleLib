using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleLib;
using libtcod;

namespace Libtcod
{
    public class LibtcodDisplay : Display
    {
        int CursorX { get; set; }
        int CursorY { get; set; }

        public TCODConsole TCODConsole { get; set; }

        public ConsoleRGB ForegroundColor  { get; set; }
        public ConsoleRGB BackgroundColor  { get; set; }

        public LibtcodDisplay(TCODConsole root)
        {

        }

        public LibtcodDisplay(int width, int height)
        {            

        }

        public void SetPosition(int x, int y) {             
        }

        public void Write(char c) { }

        public void Write(string s) { }

        public void WriteDisplay(Display display) { }

        public void Clear() { }
        
    }
}
