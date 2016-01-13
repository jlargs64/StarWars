using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsArena
{
    class Global
    {
        public const int DIR_LEFT = 2;
        public const int DIR_RIGHT = 3;
    }
    public enum Animation
    {
        WalkRight,
        WalkLeft,
        JumpR,
        JumpL,
        AttackL,
        AttackR
    }
    public enum Player
    {
        Obi,
        Anakin
    }

}
