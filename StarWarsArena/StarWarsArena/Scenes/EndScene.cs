using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsArena
{
    class EndScene : Scene
    {
        Music oWin = new Music("Assets/Vader Win.wav");
        public EndScene() : base()
        {
            
            for (int i = 0; i < 1000; i++)
            {
                int x = Rand.Int(800);
                int y = Rand.Int(600);
                Image star = Image.CreateCircle(1, Color.White);
                AddGraphic(star, x, y);
            }
          
            RichText t = new RichText("obi wan wins!", Global.sText, 28, 28);
            RichText ptp = new RichText("press space to play", Global.sText, 28, 28);
            ptp.Color = Color.Yellow;
            t.Color = Color.Yellow;
            oWin.Play();
            Sound.GlobalVolume = 100;
            AddGraphic(ptp,155,350);
            AddGraphic(t, 200, 200);
           
        }
        public override void Update()
        {
            base.Update();
            if (Input.KeyDown(Key.Space))
            {
                oWin.Stop();
                Game.SwitchScene(new StarWarsArena.gameScene());
            }
        }
    }
}
