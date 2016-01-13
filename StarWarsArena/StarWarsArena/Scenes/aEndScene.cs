using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsArena
{
    class aEndScene : Scene
    {
        public aEndScene() : base()
        {
            for (int i = 0; i < 1000; i++)
            {
                int x = Rand.Int(800);
                int y = Rand.Int(600);
                Image star = Image.CreateCircle(1, Color.White);
                AddGraphic(star, x, y);
            }
            RichText t = new RichText("YOU UNDERESTIMATE MY POWER",28);
            RichText ptp = new RichText("PRESS SPACE TO PLAY", 28);
            ptp.Color = Color.Yellow;
            t.Color = Color.Yellow;
            AddGraphic(ptp, 185, 350);
            AddGraphic(t, 135, 200);
        }
        public override void Update()
        {
            base.Update();
            if (Input.KeyDown(Key.Space))
            {
                Game.SwitchScene(new StarWarsArena.gameScene());
            }
        }
    }
}
