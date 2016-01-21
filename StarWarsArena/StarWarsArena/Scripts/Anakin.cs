using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsArena
{
    class Anakin : Entity
    {
        int speed = 5;
        public int direction = 0;
        public bool isJumping = false;
        public int jumpCount = 0;
        public int health = 100;
        public Obi obi;
        

        Spritemap<Animation> s = new Spritemap<Animation>("Assets/Anakin Resize.png", 72,70);
        BoxCollider b = new BoxCollider(72,70, Player.Anakin);
        public Anakin(int x, int y) : base(x, y)
        {
            
            s.Add(Animation.WalkRight, "0", 3);
            s.Add(Animation.WalkLeft, "1", 3);
            s.Add(Animation.AttackR, "2,1", 3);
            s.Add(Animation.AttackL, "3,2", 3);
            s.Add(Animation.JumpR, "4", 3);
            s.Add(Animation.JumpL, "5", 3);
            health = 100;
            AddGraphic(s);
            s.CenterOrigin();
            AddCollider(b);
            b.CenterOrigin();
            
        }
        public override void Update()
        {
           
            base.Update();
            X = Util.Clamp(X, 0, Game.Width-18);
            Y = Util.Clamp(Y, 0, Game.Height);
           


            if (Input.KeyDown(Key.A))
            {
                s.Play(Animation.WalkLeft);
                X -= speed;
                direction = Global.DIR_LEFT;
            }
            if(Input.KeyDown(Key.C) && direction == Global.DIR_LEFT)
            {
                s.Play(Animation.AttackL);
                
            }
            
            if (Input.KeyDown(Key.C) && direction == Global.DIR_RIGHT)
            {
                s.Play(Animation.AttackR);
                
            }
            if(Input.KeyDown(Key.A) && direction == Global.DIR_LEFT)
            {
                s.Play(Animation.WalkLeft);
                
            }
            if (Input.KeyDown(Key.D) && direction == Global.DIR_RIGHT)
            {
                s.Play(Animation.WalkRight);
               
            }
           
            if (Input.KeyDown(Key.D))
            {
                s.Play(Animation.WalkRight);
                X += speed;
                direction = Global.DIR_RIGHT;
            }
            if (Input.KeyReleased(Key.Any))
            {
                s.Stop();
            }
           
            //enable jump
            if (Input.KeyDown(Key.W) && isJumping == false)
            {
                isJumping = true;
            }
            
            //the jump math
            if (isJumping == true && direction == Global.DIR_RIGHT)
            { 
                jumpCount++;
                if (jumpCount > 0 && jumpCount < 10)
                {
                    Y -= 10;
                    s.Play(Animation.JumpR);
                }
                else if (jumpCount > 10 && jumpCount < 20)
                {
                    Y += 10;

                }
                else if (jumpCount == 20)
                {
                    isJumping = false;
                    jumpCount = 0;
                    Y = 420;
                }
              
            }
            if (isJumping == true && direction == Global.DIR_LEFT)
            {
                jumpCount++;
                if (jumpCount > 0 && jumpCount < 10)
                {
                    Y -= 8;
                    s.Play(Animation.JumpL);
                }
                else if (jumpCount > 10 && jumpCount < 20)
                {
                    Y += 8;

                }
                else if (jumpCount == 20)
                {
                    isJumping = false;
                    jumpCount = 0;
                    Y = 420;
                }
              
            }
            switch (direction)
            {
                case Global.DIR_LEFT:
                    {
                        break;
                    }
                case Global.DIR_RIGHT:
                    {
                        break;
                    }
            }
            //collider
            if (b.Overlap(X, Y, Player.Obi) && Input.KeyDown(Key.C)) 
                {
                    obi.health -= 1;
                }
          

        }

    }
}
