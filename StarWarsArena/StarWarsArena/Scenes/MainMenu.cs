using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    class MainMenu : Scene
    {
        public MainMenu() : base()
        {
            RichText mainT = new RichText("STAR WARS", 28);
            mainT.Color = Color.Yellow;
            RichText ptp = new RichText("PRESS SPACE TO PLAY",28);
            RichText multi = new RichText("PRESS ENTER FOR MULTIPLAYER", 28);
            ptp.Color = Color.Yellow;
            AddGraphic(mainT, 250, 150);
            AddGraphic(ptp, 150, 350);
            
            for(int i = 0;i < 1000;i++)
            {
                int x = Rand.Int(800);
                int y = Rand.Int(600);
                Image star = Image.CreateCircle(1, Color.White);
                AddGraphic(star,x,y);
            }
        }
        public override void Update()
        {
            base.Update();
            if (Input.KeyDown(Key.Space))
            {
                Game.SwitchScene(new gameScene());
            }
        }
    }
}
