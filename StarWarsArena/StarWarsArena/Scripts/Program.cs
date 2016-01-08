using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    class Program
    {
        static void Main(string[] args)
        {
            var g = new Game("STAR WARS",640,500);
            g.MouseVisible = true;
            g.WindowBorder = true;
            g.WindowResize = false;
           // g.SetWindowAutoFullscreen();
            g.Start(new MainMenu());
        }

    }
}
