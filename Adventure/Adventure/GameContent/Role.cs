using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.GameContent
{
    public abstract class Role:Life
    {
        /// <summary>
        /// 名字
        /// name
        /// </summary>
        protected string PLAYERNAME = "John D";

        /// <summary>
        /// 种族
        /// race
        /// </summary>
        protected RACE PLAYER_RACE;
        protected string PLAYER_RACE_DESCRIPTION;



        /// <summary>
        /// 职业
        /// class
        /// </summary>
        protected CLASS ROLE_CLASS;
        protected string ROLE_CLASS_DESCRIPTION;

        /// <summary>
        /// 主属性
        /// str = 0, agi = 1, int = 2, sta = 3, luc = 4
        /// </summary>
        protected int PRIMARY_ATTRIBUTE;



        /// <summary>
        /// 等级：默认等级 0
        /// unsigned int16
        /// 有效范围： 0~65535
        /// </summary>
        protected UInt16 LEVEL = 0;
        protected UInt16 LEVEL_REACHED = 0;



//-----------------------
        
        /// <summary>
        /// 经验值  初始值为 10;
        /// 所需升级经验
        /// experience
        /// </summary>
        protected UInt64 EXP = 10;
        /// <summary>
        /// 现有经验
        /// </summary>
        protected UInt64 EXP_CURRENT = 0;
        /// <summary>
        /// 溢出经验
        /// </summary>
        protected UInt64 EXP_OVERFLOW = 0;

        /// <summary>
        /// 经验倍率 默认为 1;
        /// experience multiplier
        /// </summary>
        protected float ea_fEXP_MUL = 1f;
        protected float ea_fEXP_MUL_CORRECTION_VALUE { get; set; }
//----------------------------
       
//--------------种族 特性
        /// <summary>
        /// 天使 特性 光明审判 
        /// 对恶魔造成更多伤害
        /// 增加负面效果抵抗
        /// </summary>
        private bool  r_f_Angel_judgement_of_light = false;
        public bool r_feature_Angel_judgement_of_light
        {
            get { return this.r_f_Angel_judgement_of_light; }
            set { this.r_f_Angel_judgement_of_light = value; }
        }

        /// <summary>
        /// 机械生物 特性 组装
        /// 不会受到精神伤害
        /// 生命值增加
        /// </summary>
        private bool r_f_Cyborg_assembly = false;
        public bool r_feature_Cyborg_assembly
        {
            get { return this.r_f_Cyborg_assembly; }
            set { this.r_f_Cyborg_assembly = value; }
        }

        /// <summary>
        /// 恶魔 特性 地狱之火
        /// 对天使造成额外伤害
        /// 增加双防
        /// </summary>
        private bool r_f_Demon_hellfire = false;
        public bool r_feature_Demon_hellfire
        {
            get { return this.r_f_Demon_hellfire; }
            set { this.r_f_Demon_hellfire = value; }
        }

        /// <summary>
        /// 矮人 特性 山川祝福
        /// 能从致死伤害下存活
        /// 增加 格挡 格挡效能
        /// </summary>
        private bool r_f_Dwarf_mountain_blessing = false;
        public bool r_feature_Dwarf_mountain_blessing
        {
            get { return this.r_f_Dwarf_mountain_blessing; }
            set { this.r_f_Dwarf_mountain_blessing = value; }
        }

        /// <summary>
        /// 元素 特性 元素调和
        /// 不受物理控制
        /// 吸收元素效果
        /// </summary>
        private bool r_f_Elemental_elemental_harmony = false;
        public bool r_feature_Elemental_elemental_harmony
        {
            get { return this.r_f_Elemental_elemental_harmony; }
            set { this.r_f_Elemental_elemental_harmony = value; }
        }

        /// <summary>
        /// 精灵 特性 自然之律
        /// 从负面状态恢复后增加恢复
        /// 增加 命中 闪避
        /// </summary>
        private bool r_f_Elf_nature_law = false;
        public bool r_feature_Elf_nature_law
        {
            get { return this.r_f_Elf_nature_law; }
            set { this.r_f_Elf_nature_law = value; }
        }

        /// <summary>
        /// 地精 特性 精密制作
        /// 更容易造成物理buff
        /// 增加 命中 暴击
        /// </summary>
        private bool r_f_Goblin_precision_production = false;
        public bool r_feature_Goblin_precision_production
        {
            get { return this.r_f_Goblin_precision_production; }
            set { this.r_f_Goblin_precision_production = value; }
        }

        /// <summary>
        /// 半兽 特性 血性驱使
        /// 对弱小生物造成额外伤害
        /// 对负面效果的生物造成额外伤害
        /// </summary>
        private bool r_f_Halfbeast_blood_driven = false;
        public bool r_feature_Halfbeast_blood_driven
        {
            get { return this.r_f_Halfbeast_blood_driven; }
            set { this.r_f_Halfbeast_blood_driven = value; }
        }

        /// <summary>
        /// 人类 特性 家族荣耀
        /// 在处于劣势的时候增加攻击
        /// 更高的经验增长 和技艺
        /// </summary>
        private bool r_f_Human_family_honor = false;
        public bool r_feature_Human_family_honor
        {
            get { return this.r_f_Human_family_honor; }
            set { this.r_f_Human_family_honor = value; }
        }

        /// <summary>
        /// 兽人 特性 战斗怒吼
        /// 处于优势时增加攻击
        /// 增加格挡 和 反击率
        /// </summary>
        private bool r_f_Orc_battle_rage = false;
        public bool r_feature_Orc_battle_rage
        {
            get { return this.r_f_Orc_battle_rage; }
            set { this.r_f_Orc_battle_rage = value; }
        }

        /// <summary>
        /// 寄生生物 特性 共生
        /// 继承生物的主特性,分配率,成长值
        /// 不会受到精神与灵魂伤害
        /// </summary>
        private bool r_f_Parasyte_symbiosis = false;
        public bool r_feature_Parasyte_symbiosis
        {
            get { return this.r_f_Parasyte_symbiosis; }
            set { this.r_f_Parasyte_symbiosis = value; }
        }
        
        /// <summary>
        /// 灵魂 特性 无形态
        /// 受到物理效果降低
        /// 增加 闪避率 和 反射率
        /// </summary>
        private bool r_f_Spirit_without_form = false;
        public bool r_feature_Spirit_without_form
        {
            get { return this.r_f_Spirit_without_form; }
            set { this.r_f_Spirit_without_form = value; }
        }

        /// <summary>
        /// 巨魔 特性 生存技巧
        /// 不受反馈
        /// 增加 速度 和暴击率
        /// </summary>
        private bool r_f_Troll_survival_skills = false;
        public bool r_feature_Troll_survival_skills
        {
            get { return this.r_f_Troll_survival_skills; }
            set { this.r_f_Troll_survival_skills = value; }
        }

        /// <summary>
        /// 不死 特性 无灵魂
        /// 不受 灵魂伤害
        /// 增加 生命 负面抵抗
        /// </summary>
        private bool r_f_Undead_without_soul = false;
        public bool r_feature_Undead_without_soul
        {
            get { return this.r_f_Undead_without_soul; }
            set { this.r_f_Undead_without_soul = value; }
        }

        /// <summary>
        /// 黑暗生物 特性 黑暗进化
        /// 受到的伤害降低
        /// 伤害增加
        /// </summary>
        private bool r_f_Underworld_dark_evolution = false;
        public bool r_feature_Underworld_dark_evolution
        {
            get { return this.r_f_Underworld_dark_evolution; }
            set { this.r_f_Underworld_dark_evolution = value; }
        }
//------------种族特性 END

//--------------------职业特性

        /// <summary>
        /// AI 特性 量子计算
        /// 持续伤害会在每轮进行之前结算
        /// </summary>
        private bool p_f_AI_quantum_computing = false;
        public bool p_feature_AI_quantum_computing
        {
            get { return this.p_f_AI_quantum_computing; }
            set { this.p_f_AI_quantum_computing = value; }
        }


        
        /// <summary>
        /// 炼金师 特性 等价交换
        /// 造成的伤害会转化为恢复值 (每轮结束时结算)
        /// </summary>
        private bool p_f_Alchemist_fertility = false;
        public bool p_feature_Alchemist_fertility
        {
            get { return this.p_f_Alchemist_fertility; }
            set { this.p_f_Alchemist_fertility = value; }
        }


        /// <summary>
        /// 异形 特性 快速繁殖
        /// 死亡后将会被残虫继承(30%血量无生命回复)
        /// </summary>
        private bool p_f_Alien_rapid_reproduce = false;
        public bool p_feature_Alien_rapid_reproduce
        {
            get { return this.p_f_Alien_rapid_reproduce; }
            set { this.p_f_Alien_rapid_reproduce = value; }
        }

        /// <summary>
        /// 弓箭手 特性 特效精准
        /// 暴击不会被闪避
        /// </summary>
        private bool p_f_Archer_lethal_accuracy = false;
        public bool p_feature_Archer_lethal_accuracy
        {
            get { return this.p_f_Archer_lethal_accuracy; }
            set { this.p_f_Archer_lethal_accuracy = value; }
        }

        /// <summary>
        /// 刺客 特性 绞喉
        /// 暴击后流血 (3回合 无法叠加 可以刷新)
        /// </summary>
        private bool p_f_Assassin_garrote = false;
        public bool p_feature_Assassin_garrote
        {
            get { return this.p_f_Assassin_garrote; }
            set { this.p_f_Assassin_garrote = value; }
        }

        /// <summary>
        /// 阿凡达 特性 钢化骨骼
        /// 前三回合攻击力上升 (130% 递减 每次10%)
        /// </summary>
        private bool p_f_Avatar_tempered_bone = false;
        public bool p_feature_Avatar_tempered_bone
        {
            get { return this.p_f_Avatar_tempered_bone; }
            set { this.p_f_Avatar_tempered_bone = value; }
        }


        /// <summary>
        /// 吟游诗人 特性 赞美诗
        /// 每次战斗 一项属性随机增加
        /// </summary>
        private bool p_f_Bard_hymn = false;
        public bool p_feature_Bard_hymn
        {
            get { return this.p_f_Bard_hymn; }
            set { this.p_f_Bard_hymn = value; }
        }


        /// <summary>
        /// 狂战士  特性 不败
        /// 损血量越高 攻击力越高 恢复力提高 (180% 当血量在 20%以下 每5% 血量损失 =  5%伤害 0.0375% 总血量生命恢复)
        /// </summary>
        private bool p_f_Berserker_undefeated = false;
        public bool p_feature_Berserker_undefeated
        {
            get { return this.p_f_Berserker_undefeated; }
            set { this.p_f_Berserker_undefeated = value; }
        }

        /// <summary>
        /// 黑寡妇 特性 毒液只触
        /// 每次攻击会有额外 3%当前血量伤害
        /// </summary>
        private bool p_f_BlackWidow_touch_of_venom = false;
        public bool p_feature_BlackWidow_touch_of_venom
        {
            get { return this.p_f_BlackWidow_touch_of_venom; }
            set { this.p_f_BlackWidow_touch_of_venom = value; }
        }

        /// <summary>
        /// 创造者 特性 顺从
        /// 受到攻击后有机会对施放者进行控制
        /// </summary>
        private bool p_f_Creator_obedience = false;
        public bool p_feature_Creator_obedience
        {
            get { return this.p_f_Creator_obedience; }
            set { this.p_f_Creator_obedience = value; }
        }
        
        /// <summary>
        /// 欺诈者 特性 欺诈
        /// 有几率将Debuff转移到施放者
        /// </summary>
        private bool cheat = false;
        public bool p_feature_Deceiver_cheat
        {
            get { return this.cheat; }
            set { this.cheat = value; }
        }
        
        /// <summary>
        /// 龙骑士 特性 龙息
        /// 格挡 闪避 法术反射 法术抵抗 都将受到龙息的伤害
        /// </summary>
        private bool p_f_DragonWarrior_dragon_breath = false;
        public bool p_feature_DragonWarrior_dragon_breath
        {
            get { return this.p_f_DragonWarrior_dragon_breath; }
            set { this.p_f_DragonWarrior_dragon_breath = value; }
        }
        
        /// <summary>
        /// 德鲁伊 特性 自然之息
        /// 受到暴击之后回复生命值 5%
        /// </summary>
        private bool p_f_Druid_nature_breath = false;
        public bool p_feature_Druid_nature_breath
        {
            get { return this.p_f_Druid_nature_breath; }
            set { this.p_f_Druid_nature_breath = value; }
        }
        
        /// <summary>
        /// 工程师 特性 机械原理
        /// 受到攻击有几率反击(额外反击)
        /// </summary>
        private bool p_f_Engineer_mechanical_principle = false;
        public bool p_feature_Engineer_mechanical_principle
        {
            get { return this.p_f_Engineer_mechanical_principle; }
            set { this.p_f_Engineer_mechanical_principle = value; }
        }


        /// <summary>
        /// 迷 特性 混沌元素
        /// 有几率100% 吸收伤害 转化为生命恢复
        /// </summary>
        private bool p_f_Enigma_chaosium = false;
        public bool p_feature_Enigma_chaosium
        {
            get { return this.p_f_Enigma_chaosium; }
            set { this.p_f_Enigma_chaosium = value; }
        }


        /// <summary>
        /// 守护者 特性 警觉
        /// 受到的伤害减少 取决于敌人攻击力和速度
        /// </summary>
        private bool p_f_Guardian_vigilance = false;
        public bool p_feature_Guardian_vigilance
        {
            get { return this.p_f_Guardian_vigilance; }
            set { this.p_f_Guardian_vigilance = value; }
        }
        
        /// <summary>
        /// 绅士 特性 卧槽我也不知道我为什么要写个这个
        /// </summary>
        private bool p_f_Hentai_x18 = false;
        public bool p_feature_Hentai_x18
        {
            get { return this.p_f_Hentai_x18; }
            set { this.p_f_Hentai_x18 = value; }
        }
        
        /// <summary>
        /// 猎人 特性 循迹
        /// 如果攻击没有暴击 下次攻击的暴击率增加10%;
        /// </summary>
        private bool p_f_Hunter_track = false;
        public bool p_feature_Hunter_track
        {
            get { return this.p_f_Hunter_track; }
            set { this.p_f_Hunter_track = value; }
        }

        /// <summary>
        /// 审判长 特性 血腥裁决
        /// 可将你致死或者血量降低到5%以下的伤害 会受到裁决 伤害的一半将会反弹 你在下回合必定先攻
        /// </summary>
        private bool p_f_Judge_bloody_adjudication = false;
        public bool p_feature_Judge_bloody_adjudication
        {
            get { return this.p_f_Judge_bloody_adjudication; }
            set { this.p_f_Judge_bloody_adjudication = value; }
        }
        
        /// <summary>
        /// 主宰 特性 翻盘
        /// 受到致死攻击时 无敌三回合 攻击力提升至120%
        /// </summary>
        private bool p_f_Juggernaut_comeback = false;
        public bool p_feature_Juggernaut_comeback
        {
            get { return this.p_f_Juggernaut_comeback; }
            set { this.p_f_Juggernaut_comeback = value; }
        }

        /// <summary>
        /// 王 特性 王权
        /// 敌人格挡率 闪避率 反射率降低
        /// </summary>
        private bool p_f_King_royalty = false;
        public bool p_feature_King_royalty
        {
            get { return this.p_f_King_royalty; }
            set { this.p_f_King_royalty = value; }
        }
        
        /// <summary>
        /// 骑士 特性 冲锋 
        /// 受到格挡 闪避 后 下次攻击造成对手眩晕一回合
        /// </summary>
        private bool p_f_Knight_charge = false;
        public bool p_feature_Knight_chare
        {
            get { return this.p_f_Knight_charge; }
            set { this.p_f_Knight_charge = value; }
        }


        /// <summary>
        /// 巫妖 特性 冬之魂
        /// 敌人的攻击力 防御力 速度 每回合减少3% 最多减少30%
        /// </summary>
        private bool p_f_Lich_winter_soul = false;
        public bool p_feature_Lich_winter_soul
        {
            get { return this.p_f_Lich_winter_soul; }
            set { this.p_f_Lich_winter_soul = value; }
        }

        /// <summary>
        /// 潜伏者 特性 消失
        /// 如果没有成功闪避 下一回合闪避加成6%
        /// </summary>
        private bool p_f_Lurker_vanish = false;
        public bool p_feature_Lurker_vanish
        {
            get { return this.p_f_Lurker_vanish; }
            set { this.p_f_Lurker_vanish = value; }
        }

        
        /// <summary>
        /// 法师 特性 魔法血统
        /// 受到的第一个技能将被反弹 CD6回合
        /// 处于冷却时 魔法使用几率加10%
        /// </summary>
        private bool p_f_Mage_magic_blood = false;
        public bool p_feature_Mage_magic_blood
        {
            get { return this.p_f_Mage_magic_blood; }
            set { this.p_f_Mage_magic_blood = value; }
        }
        
        /// <summary>
        /// 佣兵 特性 剑盾加护
        /// 血量越低 格挡 闪避 反射 魔法抗性 双防 提高
        /// </summary>
        private bool p_f_Mercenary_sword_and_shield = false;
        public bool p_feature_Mercenary_sword_and_shield
        {
            get { return this.p_f_Mercenary_sword_and_shield; }
            set { this.p_f_Mercenary_sword_and_shield = value; }
        }
        
        /// <summary>
        /// 武僧 特性 太极 (只有一种情况发生)
        /// 当对手攻击高于你防御时 防御(双防中低的那个)提高至对手攻击力
        /// 当对手防御高于你攻击时 攻击提高至对手防御力(双防中低的那个)
        /// </summary>
        private bool p_f_Monk_tai_ji = false;
        public bool p_feature_Monk_tai_ji
        {
            get { return this.p_f_Monk_tai_ji; }
            set { this.p_f_Monk_tai_ji = value; }
        }
        
        /// <summary>
        /// 死灵法师 特性 灵魂收割
        /// 每个杀死的敌人将会化为 0.1% 的生命恢复 最多5% 死亡将失去全部
        /// </summary>
        private bool p_f_Necro_soul_reaping = false;
        public bool p_feature_Necro_soul_reaping
        {
            get { return this.p_f_Necro_soul_reaping; }
            set { this.p_f_Necro_soul_reaping = value; }
        }
        
        /// <summary>
        /// 先知 特性 预见未来
        /// 每过4回合你都可以闪避一次技能
        /// </summary>
        private bool p_f_Oracle_future_sight = false;
        public bool p_feature_Oracle_future_sight
        {
            get { return this.p_f_Oracle_future_sight; }
            set { this.p_f_Oracle_future_sight = value; }
        }

        /// <summary>
        /// 霸主 特性 强制
        /// 在对手使用完技能后 下一回合必定是普通攻击
        /// </summary>
        private bool p_f_Overlord_force_attack = false;
        public bool p_feature_Overlord_force_attack
        {
            get { return this.p_f_Overlord_force_attack; }
            set { this.p_f_Overlord_force_attack = value; }
        }

        /// <summary>
        /// 圣骑士 特性 庇护
        /// 在你受到Debuff期间 受到的全部伤害 降低30%
        /// </summary>
        private bool p_f_Paladin_shelter = false;
        public bool p_feature_Paladin_shelter
        {
            get { return this.p_f_Paladin_shelter; }
            set { this.p_f_Paladin_shelter = value; }
        }

        /// <summary>
        /// 程序员 特性 开发 (一切都靠脸 10% 触发率)
        /// 先攻: 极限开发   : 你的攻击将造成对手 脱发2回合 不能攻击
        /// 后攻: 效率反编译 : 如果他的攻击比你将要使用的攻击力高 则反编译 你讲使用他的技能攻击他
        /// </summary>
        private bool p_f_Programmer_implementation = false;
        public bool p_feature_Programmer_implementation
        {
            get { return this.p_f_Programmer_implementation; }
            set { this.p_f_Programmer_implementation = value; }
        }


        /// <summary>
        /// 游侠 特性 风筝
        /// 你的第一回合将会一直攻击直到风筝失败 (失败几率50%)
        /// </summary>
        private bool p_f_Ranger_kite = false;
        public bool p_feature_Ranger_kite
        {
            get { return this.p_f_Ranger_kite; }
            set { this.p_f_Ranger_kite = value; }
        }

        /// <summary>
        /// 硒素生物 特性 同化
        /// 每杀死一个单位 你就会增加 0.1%生命 攻击 和 双防 最多增加10%
        /// </summary>
        private bool p_f_SeleniumCreature_assimilate = false;
        public bool p_feature_SeleniumCreature_assimilate
        {
            get { return this.p_f_SeleniumCreature_assimilate; }
            set { this.p_f_SeleniumCreature_assimilate = value; }
        }

        /// <summary>
        /// 萨满 特性 魔法反馈
        /// 如果使用魔法 使用率增加 15% 下一次的魔法伤害减少10%
        /// 连续使用三次后 清零
        /// </summary>
        private bool p_f_Shaman_magic_feedback = false;
        public bool p_feature_Shaman_magic_feedback
        {
            get { return this.p_f_Shaman_magic_feedback; }
            set { this.p_f_Shaman_magic_feedback = value; }
        }
        
        /// <summary>
        /// 魔剑士 特性 魔能转换
        /// 每次攻击都能转换对手的法术释放率 直到释放法术后归零
        /// </summary>
        private bool p_f_Spellsword_magic_conversion = false;
        public bool p_feature_Spellsword_magic_conversion
        {
            get { return this.p_f_Spellsword_magic_conversion; }
            set { this.p_f_Spellsword_magic_conversion = value; }
        }
        
        /// <summary>
        /// 虚空之主 特性 虚无
        /// 双方都无法自然恢复生命
        /// </summary>
        private bool p_f_Void_nihility = false;
        public bool p_feature_Void_nihility
        {
            get { return this.p_f_Void_nihility; }
            set { this.p_f_Void_nihility = value; }
        }


        /// <summary>
        /// 术士 特性 恐惧
        /// 每回合都有10% 的几率使敌人进入恐慌 恐慌中的敌人 攻击力防御力下降20% 3回合
        /// </summary>
        private bool p_f_Warlock_fear = false;
        public bool p_feature_Warlock_fear
        {
            get { return this.p_f_Warlock_fear; }
            set { this.p_f_Warlock_fear = value; }
        }


        /// <summary>
        /// 战士 特性 泰坦之力
        /// 受到魔法攻击会使你的攻击提升 5% 保持4回合 堆叠3次
        /// </summary>
        private bool p_f_Warrior_titan_force = false;
        public bool p_feature_Warrior_titan_force
        {
            get { return this.p_f_Warrior_titan_force; }
            set { this.p_f_Warrior_titan_force = value; }
        }

        /// <summary>
        /// 巫医 特性 哀怨诅咒
        /// 每次受到攻击 都会使对方的双防降低8% 堆叠3次 每次效果持续1回合
        /// </summary>
        private bool p_f_WitchDoctor_curse_of_sorrow = false;
        public bool p_feature_WitchDoctor_curse_of_sorrow
        {
            get { return this.p_f_WitchDoctor_curse_of_sorrow; }
            set { this.p_f_WitchDoctor_curse_of_sorrow = value; }
        }

        
        //----------通用特性

        /// <summary>
        /// 先攻 必定先攻
        /// </summary>
        private bool c_f_first_strike = false;
        public bool c_feature_first_strike
        {
            get { return this.c_f_first_strike; }
            set { this.c_f_first_strike = value; }
        }


        /// <summary>
        /// 坚定意志 降低精神伤害
        /// </summary>
        private bool c_f_unbreakable_will = false;
        public bool c_feature_unbreakable_will
        {
            get { return this.c_f_unbreakable_will; }
            set { this.c_f_unbreakable_will = value; }
        }


        /// <summary>
        /// 灵魂归属 降低灵魂伤害
        /// </summary>
        private bool c_f_soul_place = false;
        public bool c_feature_soul_place
        {
            get { return this.c_f_soul_place; }
            set { this.c_f_soul_place = value; }
        }


        /// <summary>
        /// 强壮 物理伤害降低
        /// </summary>
        private bool c_f_strong = false;
        public bool c_feature_strong
        {
            get { return this.c_f_strong; }
            set { this.c_f_strong = value; }
        }

        /// <summary>
        /// 有学问的 元素(魔法)伤害降低
        /// </summary>
        private bool c_f_learned = false;
        public bool c_feature_learned
        {
            get { return this.c_f_learned; }
            set { this.c_f_learned = value; }
        }

        /// <summary>
        /// 报复 可以多次反馈伤害
        /// </summary>
        private bool c_f_revenge = false;
        public bool c_feature_revenge
        {
            get { return this.c_f_revenge; }
            set { this.c_f_revenge = value; }
        }

        /// <summary>
        /// 不屈 受到暴击以后增加速度
        /// </summary>
        private bool c_f_tenacity = false;
        public bool c_feature_tenacity
        {
            get { return this.c_f_tenacity; }
            set { this.c_f_tenacity = value; }
        }

        /// <summary>
        /// 快速反应 在被闪避后 立即作出一次附加攻击
        /// </summary>
        private bool c_f_rapid_reaction = false;
        public bool c_feature_rapid_reaction
        {
            get { return this.c_f_rapid_reaction; }
            set { this.c_f_rapid_reaction = value; }
        }

        /// <summary>
        /// 暴怒 被格挡以后 攻击力提高
        /// </summary>
        private bool c_f_rampage = false;
        public bool c_feature_rampage
        {
            get { return this.c_f_rampage; }
            set { this.c_f_rampage = value; }
        }
        
    
        /// <summary>
        /// 冲击 降低对手的格挡效能
        /// </summary>
        private bool c_f_concussion = false;
        public bool c_feature_concussion
        {
            get { return this.c_f_concussion; }
            set { this.c_f_concussion = value; }
        }

        
        /// <summary>
        /// 魔法渗透 降低魔法反射率和抵抗率
        /// </summary>
        private bool c_f_magic_penetration = false;
        public bool c_feature_magic_penetratio
        {
            get { return this.c_f_magic_penetration; }
            set { this.c_f_magic_penetration = value; }
        }

        /// <summary>
        /// 法术连击 在法术被反射后立即重新释放法术
        /// </summary>
        private bool c_f_hot_streak = false;
        public bool c_feature_hot_streak
        {
            get { return this.c_f_hot_streak; }
            set { this.c_f_hot_streak = value; }
        }

        /// <summary>
        /// 伤痕诅咒 难以从状态复原
        /// </summary>
        private bool c_f_curse_of_bleeding = false;
        public bool c_feature_curse_of_bleeding
        {
            get { return this.c_f_curse_of_bleeding; }
            set { this.c_f_curse_of_bleeding = value; }
        }

        /// <summary>
        /// 自我复原 损失血量越高 自我恢复越快
        /// </summary>
        private bool c_f_self_healing = false;
        public bool c_feature_self_healing
        {
            get { return this.c_f_self_healing; }
            set { this.c_f_self_healing = value; }
        }


        //////////////////////////////////////////////////////
        //----Main Interface

        /// <summary>
        /// Class: Role
        /// 构造函数
        /// 设置人物的名字和初始种族 职业
        /// </summary>
        /// <param name="name"></param>
        /// <param name="player_race"></param>
        /// <param name="role_class"></param>
        public Role(String name, RACE player_race, CLASS role_class) {
            this.PLAYERNAME = name;
            //拷贝种族配置
            Race.instance.Selection(this,player_race);
            Class.instance.Selection(this, role_class);
        
        }


        /// <summary>
        /// Class:Role
        /// 设置种族以及配置
        /// </summary>
        /// <param name="player_race"></param>
        public void setRace(RACE race, String race_description,double str_r_b, double str_g, double agi_r_b, double agi_g,double int_r_b,double int_g, double sta_r_b,double sta_g, double luc_r_b, double luc_g)
        {
            this.PLAYER_RACE                = race;
            this.PLAYER_RACE_DESCRIPTION    = race_description;

            this.ma_dSTR_RACE_BONUS            = str_r_b;
            this.ma_dSTR_G = str_g;

            this.ma_dAGI_RACE_BONUS = agi_r_b;
            this.ma_dAGI_G = agi_g;

            this.ma_dINT_RACE_BONUS = int_r_b;
            this.ma_dINT_G = int_g;

            this.ma_dSTA_RACE_BONUS = sta_r_b;
            this.ma_dSTA_G = sta_g;

            this.ma_dLUC_RACE_BONUS = luc_r_b;
            this.ma_dLUC_G = luc_g;
        }


        public void setClass(CLASS role_class, String class_description, double str_g_b, double agi_g_b, double int_g_b, double sta_g_b, double luc_g_b)
        {
            this.ROLE_CLASS = role_class;
            this.ROLE_CLASS_DESCRIPTION = class_description;

            this.ma_dSTR_G_BONUS = str_g_b;

            this.ma_dAGI_G_BONUS = agi_g_b;

            this.ma_dINT_G_BONUS = int_g_b;

            this.ma_dSTA_G_BONUS = sta_g_b;

            this.ma_dLUC_G_BONUS = luc_g_b;
        }
    }
}
