using System;

namespace ConsoleLib
{
    public interface Display
    {     
        ConsoleRGB ForegroundColor { get; set; }

        ConsoleRGB BackgroundColor { get; set; }

        void SetPosition(int x, int y);

        void Write(char c);

        void Write(string s);

        void WriteDisplay(Display display);

        void Clear();
    }
}
