using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.GameContent.Skills
{
    abstract class common_Skill
    {
        public common_Skill() {
        
        }

        public Source cSkill_Rush(Role role) {
            Source temp = new Source(role,"Rush",SOURCE_TYPE.Magic,SOURCE_SUB_TYPE.Hot,3);
            //temp.
            return temp;
        }


    }
}
