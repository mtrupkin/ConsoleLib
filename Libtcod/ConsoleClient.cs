using System;

using libtcod;

namespace Libtcod
{
    class ConsoleClient
    {
        public static int Main(string[] args)
        {
            LibtcodShell shell = new LibtcodShell("Console Client", 80, 25);

            TCODConsole.waitForKeypress(true); 
            return 0;
        }
    }
}
