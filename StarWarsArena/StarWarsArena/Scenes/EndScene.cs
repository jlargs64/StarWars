using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    class EndScene : Scene
    {
        public EndScene() : base()
        {
            for (int i = 0; i < 1000; i++)
            {
                int x = Rand.Int(800);
                int y = Rand.Int(600);
                Image star = Image.CreateCircle(1, Color.White);
                AddGraphic(star, x, y);
            }
            RichText ptp = new RichText("PRESS SPACE TO PLAY", 28);
            ptp.Color = Color.Yellow;
            AddGraphic(ptp,185,350);
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
