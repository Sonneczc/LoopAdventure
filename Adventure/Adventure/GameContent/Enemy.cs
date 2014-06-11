using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adventure.GameContent
{
    class Enemy:Life
    {
         public Enemy(String name, RACE player_race, CLASS role_class) : base(name, player_race, role_class) {
        
        }
    }
}
