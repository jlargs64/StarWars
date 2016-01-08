using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    class gameScene : Scene
    {
        public gameScene() : base()
        {
            Image level = new Image("Assets/Project Background.png");
            
            AddGraphic(level);
            Add(new Anakin(50, 420));
            Add(new Obi(680, 420));
        }
    }
}
