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
        private Anakin a;
        private Obi o;
        RichText aH = new RichText(16);
        RichText oH = new RichText(16);
        public gameScene() : base()
        {
            Image level = new Image("Assets/Project Background.png");
            AddGraphic(level);
           
            a = new Anakin(50, 420);
            o = new Obi(680, 420);
            a.obi = o;
            o.anakin = a;
            Add(a);
            Add(o);

        }
        public override void Update()
        {
          base.Update();
            
            aH.String = "Anakin: " + a.health;
            AddGraphic(aH, 10, 10);
            oH.String = "Obi Wan: " + o.health;
            AddGraphic(oH, 525, 10);
        }
    }
}
