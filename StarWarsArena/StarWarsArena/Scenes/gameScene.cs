using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsArena
{
    class gameScene : Scene
    {
        private Anakin a;
        private Obi o;
        RichText aH = new RichText("", Global.sText,16,16);
        RichText oH = new RichText("", Global.sText, 16, 16);
        Music mainTheme = new Music("Assets/John Williams Star Wars - Episode III - Anakin vs. Obi-Wan.wav");
        public gameScene() : base()
        {
            Image level = new Image("Assets/Project Background.png");
            AddGraphic(level);
           
            a = new Anakin(50, 420);
            o = new Obi(700, 420);
            a.obi = o;
            o.anakin = a;
            Add(a);
            Add(o);
            mainTheme.Play();
            AddGraphic(aH, 10, 10);
            AddGraphic(oH, 505, 10);
        }
        public override void Update()
        {
          base.Update();
            
            aH.String = "Anakin: " + a.health;
         
            oH.String = "obi Wan: " + o.health;
         

            if(a.health < 0)
            {
                Game.SwitchScene(new EndScene());
                mainTheme.Stop();
            }
            if(o.health < 0)
            {
                Game.SwitchScene(new aEndScene());
                mainTheme.Stop();
            }

         
        }
    }
}
