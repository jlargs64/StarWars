﻿using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    class Obi : Entity
    {
       
        int speed = 5;
        public int direction = 0;
        public bool isJumping = false;
        public int jumpCount = 0;

        Spritemap<Animation> s = new Spritemap<Animation>("Assets/Obi Wan.png", 36, 35);
        public Obi(int x, int y) : base(x, y)
        {
            BoxCollider b = new BoxCollider(36, 35, Player.Obi);
            s.Add(Animation.WalkRight, "0", 1);
            s.Add(Animation.WalkLeft, "1", 1);
            s.Add(Animation.AttackR, "2", 1);
            s.Add(Animation.AttackL, "3", 1);
            s.Add(Animation.JumpR, "4", 1);
            s.Add(Animation.JumpL, "5", 1);

            AddGraphic(s);
            s.CenterOrigin();
            AddCollider(b);
        }
        public override void Update()
        {

            base.Update();
            X = Util.Clamp(X, 0, Game.Width -15);
            Y = Util.Clamp(Y, 0, Game.Height);

            if (Input.KeyDown(Key.Left))
            {
                s.Play(Animation.WalkLeft);
                X -= speed;
                direction = Global.DIR_LEFT;
            }
            if (Input.KeyDown(Key.M) && direction == Global.DIR_LEFT)
            {
                s.Play(Animation.AttackL);
            }
            if (Input.KeyDown(Key.M) && direction == Global.DIR_RIGHT)
            {
                s.Play(Animation.AttackR);
            }
            if (Input.KeyDown(Key.Right))
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
            if (Input.KeyDown(Key.Up) && isJumping == false)
            {
                isJumping = true;
            }

            //the jump math
            if (isJumping == true && direction == Global.DIR_RIGHT)
            {
                jumpCount++;
                if (jumpCount > 0 && jumpCount < 10)
                {
                    Y -= 8;
                    s.Play(Animation.JumpR);
                }
                else if (jumpCount > 10 && jumpCount < 20)
                {
                    Y += 8;
                }
                else if (jumpCount == 20)
                {
                    isJumping = false;
                    jumpCount = 0;
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
        }
    }
}
