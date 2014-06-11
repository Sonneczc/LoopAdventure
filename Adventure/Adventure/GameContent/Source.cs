using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.GameContent
{
    public enum SOURCE_TYPE {
        None,       //无
        Attack,     //普通攻击
        Physical,   //物理打击
        Magic,      //元素 魔法伤害
        Soul,       //灵魂打击
        Spiritual,  //精神攻击
    }

    public enum SOURCE_SUB_TYPE { 
        /// <summary>
        /// 普通 无状态
        /// </summary>
        Normal,             //普通 无状态
        /// <summary>
        /// 致残 减少攻击
        /// </summary>
        Disable,            //致残 减少攻击
        /// <summary>
        /// 致伤 减少防御
        /// </summary>
        Wounding,           //致伤 减少防御
        /// <summary>
        /// 弱化 减少魔抗
        /// </summary>
        Fade,               //弱化 减少魔抗
        /// <summary>
        /// 眩晕 无法行动
        /// </summary>
        Stun,               //眩晕 无法行动
        /// <summary>
        /// Debuff 伤害 Turn-base
        /// </summary>
        Dot,                //Debuff 伤害 Turn-base
        /// <summary>
        /// //Buff   增益 Turn-base
        /// </summary>
        Hot,                //Buff   增益 Turn-base
        /// <summary>
        /// 麻痹 有几率无法攻击
        /// </summary>
        Palsy,              //麻痹 有几率无法攻击
        /// <summary>
        /// 沉默 禁止施法
        /// </summary>
        Silent,             //沉默 禁止施法
        /// <summary>
        /// 无敌 不受伤害
        /// </summary>
        Invincible,         //无敌 不受伤害
        /// <summary>
        /// 睡眠 不会受到主动的物理攻击 增加生命恢复
        /// </summary>
        Sleep,              //睡眠 不会受到主动的物理攻击 增加生命恢复
        /// <summary>
        /// 恐惧 受到额外精神伤害
        /// </summary>
        Fear,               //恐惧 受到额外精神伤害
        /// <summary>
        /// 疾病 受到额外物理伤害
        /// </summary>
        Disease,            //疾病 受到额外物理伤害
        /// <summary>
        /// 诅咒 受到额外精神伤害
        /// </summary>
        Curse,              //诅咒 受到额外精神伤害
        /// <summary>
        /// 疲劳 速度下降
        /// </summary>
        Exhaustion,         //疲劳 速度下降

    }

    class Source:Bio
    {
        /// <summary>
        /// Class:Source
        /// 源名称
        /// </summary>
        string              SOURCE_NAME;        //名称
        /// <summary>
        /// Class:Source
        /// 源主特性
        /// </summary>
        SOURCE_TYPE         TYPE_MAIN;          //主特性
        /// <summary>
        /// Class:Source
        /// 源副特性
        /// </summary>
        SOURCE_SUB_TYPE     TYPE_SUB;           //副特性
        /// <summary>
        /// Class:Source
        /// 是否瞬间伤害
        /// </summary>
        bool                INSTANT_DAMAGE;     //是否瞬间伤害
        /// <summary>
        /// Class:Source
        /// 持续时间 (turn)
        /// </summary>
        UInt16              DURATION;           //持续时间
        /// <summary>
        /// 伤害
        /// </summary>
        double              dDAMAGE;            //伤害
        /// <summary>
        /// 持续伤害
        /// </summary>
        double              dDAMAGE_CONTINUE;   //持续伤害
        /// <summary>
        /// 作用对象
        /// </summary>
        Role                Target;             //作用对象


        




        /// <summary>
        /// Class:Source
        /// 用于普通攻击
        /// </summary>
        /// <param name="name"></param>
        /// <param name="damage"></param>
        public Source(Role role,String name, double damage)
            : this(role,name, SOURCE_TYPE.Attack, SOURCE_SUB_TYPE.Normal, true, 0, damage, 0)
        {
        }


        /// <summary>
        /// Class:Source
        /// 用于增益Buff
        /// </summary>
        /// <param name="role"></param>
        /// <param name="name"></param>
        /// <param name="s_type"></param>
        /// <param name="s_s_type"></param>
        /// <param name="duration"></param>
        public Source(Role role, String name, SOURCE_TYPE s_type,SOURCE_SUB_TYPE s_s_type,UInt16 duration)
            : this(role, name, s_type, s_s_type, true, duration, 0, 0)
        {
        }


        /// <summary>
        /// Class:Source
        /// 完整构造体
        /// </summary>
        /// <param name="name"></param>
        /// <param name="s_type"></param>
        /// <param name="s_s_type"></param>
        /// <param name="instant"></param>
        /// <param name="duration"></param>
        /// <param name="damage"></param>
        /// <param name="damage_continue"></param>
        public Source(Role role,String name,SOURCE_TYPE s_type,SOURCE_SUB_TYPE s_s_type,bool instant,UInt16 duration,double damage,double damage_continue)
        {
            this.Target             = role;
            this.SOURCE_NAME        = name;
            this.TYPE_MAIN          = s_type;
            this.TYPE_SUB           = s_s_type;
            this.INSTANT_DAMAGE     = instant;
            this.DURATION           = duration;
            this.dDAMAGE            = damage;
            this.dDAMAGE_CONTINUE   = damage_continue;
        }
    }
}
