using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.GameContent
{
    public enum CLASS {
        Warrior,            //战士
        Guardian,           //守护者
        Knight,             //骑士
        Paladin,            //圣骑士
        Berserker,          //狂战士
        Mercenary,          //佣兵
        Dragon_Warrior,     //龙战士
        Juggernaut,         //主宰
        Archer,             //弓箭手
        Ranger,             //游骑兵
        Hunter,             //猎人
        Assassin,           //刺客
        Black_Widow,        //黑寡妇
        Engineer,           //工程师
        Alchemist,          //炼金师
        Lich,               //巫妖
        Programmer,         //程序员
        Necro,              //死灵法师
        Warlock,            //术士
        Oracle,             //贤者
        Spellsword,         //魔剑士
        Druid,              //德鲁伊
        Bard,               //吟游诗人
        Mage,               //法师
        Avatar,             //阿凡达
        Monk,               //武僧
        Lurker,             //潜伏者
        King,               //王
        Judge,              //判官
        Hentai,             //绅士
        Shaman,             //萨满
        Witch_Doctor,       //巫医
        Deceiver,           //欺诈者
        Creator,            //创造者
        Enigma,             //迷
        Void,               //虚空
        AI,                 //人工智能
        Overlord,           //王虫
        Alien,              //异形
        Selenium_Creature,  //硒素生物
        //////////////新的
        Death_Knight,       //亡灵骑士
        Puppet_Master,      //傀儡师
        Summoner,           //召唤师
        Immortal,           //不朽者
        Ghoul,              //食尸鬼
        Water_Spirit,       //流水之灵
        Flame_Spirit,       //烈焰之灵
        Earth_Spirit,       //大地之灵
        Storm_Spirit,       //风暴之灵
        Thunder_Spirit,     //闪电之灵
        Light_Spirit,       //光明之灵
        Shadow_Spirit,      //黑暗之灵
        Plague_Spirit,      //瘟疫之灵
        Forest_Spirit,      //森林之灵
        Mountain_Spirit,    //群山之灵
        Swamp_Spirit,       //沼泽之灵
        Mist_Spirit,        //迷雾之灵
        Ocean_spirit,       //海洋之灵






    }

    /// <summary>
    /// 包含所有职业的配置文件:
    /// 职业影响 主属性的增益值和副属性的修正值
    /// </summary>
    public sealed class Class
    {
        /// <summary>
        /// 独子模式
        /// </summary>
        private Class() {
        }

        /// <summary>
        /// 静态只读模式
        /// </summary>
        public static readonly Class instance = new Class();


        public void Selection(Role role, CLASS role_class) {
            switch (role_class) {
                case CLASS.AI:
                    this.AI(role);
                    break;

                case CLASS.Alchemist:
                    break;

                case CLASS.Alien:
                    break;

                case CLASS.Archer:
                    break;

                case CLASS.Assassin:
                    break;

                case CLASS.Avatar:
                    break;

                case CLASS.Bard:
                    break;

                case CLASS.Berserker:
                    break;

                case CLASS.Black_Widow:
                    break;

                case CLASS.Creator:
                    break;

                case CLASS.Deceiver:
                    break;

                case CLASS.Dragon_Warrior:
                    break;

                case CLASS.Druid:
                    break;

                case CLASS.Engineer:
                    break;

                case CLASS.Enigma:
                    break;

                case CLASS.Guardian:
                    break;

                case CLASS.Hentai:
                    break;

                case CLASS.Hunter:
                    break;

                case CLASS.Judge:
                    break;

                case CLASS.Juggernaut:
                    break;

                case CLASS.King:
                    break;

                case CLASS.Knight:
                    break;

                case CLASS.Lich:
                    break;

                case CLASS.Lurker:
                    break;

                case CLASS.Mage:
                    break;

                case CLASS.Mercenary:
                    break;

                case CLASS.Monk:
                    break;

                case CLASS.Necro:
                    break;

                case CLASS.Oracle:
                    break;

                case CLASS.Overlord:
                    break;

                case CLASS.Paladin:
                    break;

                case CLASS.Programmer:
                    break;

                case CLASS.Ranger:
                    break;

                case CLASS.Selenium_Creature:
                    break;

                case CLASS.Shaman:
                    break;

                case CLASS.Spellsword:
                    break;

                case CLASS.Void:
                    break;

                case CLASS.Warlock:
                    break;

                case CLASS.Warrior:
                    break;

                case CLASS.Witch_Doctor:
                    break;
            }
        }

        private void AI(Role role) {
            string descriotion = "";
            role.p_feature_AI_quantum_computing = true;
            double str_g_b = 0.8;
            double agi_g_b = 0.8;
            double int_g_b = 0.6;
            double sta_g_b = 1.4;
            double luc_g_b = 1.4;

            role.setClass(CLASS.AI, descriotion, 
                            str_g_b, 
                            agi_g_b, 
                            int_g_b, 
                            sta_g_b, 
                            luc_g_b);
        }

    }
}
