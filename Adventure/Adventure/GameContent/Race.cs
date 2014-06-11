using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.GameContent
{

    public enum RACE {
    Human,      //人类
    Undead,     //亡灵
    Elemental,  //元素
    Elf,        //精灵
    Goblin,     //地精
    Troll,      //巨魔
    Dwarf,      //矮人
    Orc,        //兽人
    Cyborg,     //机械生物
    Underworld, //黑暗生物
    Demon,      //恶魔
    Angel,     //天使
    Halfbeast,  //半兽生物
    Spirit,     //灵魂
    Parasyte    //寄生生物
    }
    /// <summary>
    /// 包含所有的种族配置文件：
    /// 种族会改变主属性的基础分配率 和增长值
    /// 14.6.1
    /// S:我决定改变这个类的模式
    /// 我将会用数据库来存放所有的种族分配率成长值
    /// 原因是因为我觉得这个类应该具有更多职业相关的方法
    /// 而不是分配与成长
    /// </summary>
    public sealed class Race
    {
        /// <summary>
        /// 独子模式
        /// </summary>
        private Race() {
        }

        /// <summary>
        /// 静态只读模式
        /// </summary>
        public static readonly Race instance= new Race();

        /// <summary>
        /// Class:Race
        /// 选择种族
        /// 调用内部方法修改参数的 基础分配率 和增长值
        /// </summary>
        /// <param name="role"></param>
        /// <param name="race"></param>
        public void Selection(Role role, RACE race) {
            switch (race) {
                case RACE.Angel:
                    break;
        
                case RACE.Cyborg:
                    break;

                case RACE.Demon:
                    break;

                case RACE.Dwarf:
                    break;

                case RACE.Elemental:
                    break;

                case RACE.Elf:
                    break;

                case RACE.Goblin:
                    break;

                case RACE.Halfbeast:
                    break;

                case RACE.Human:
                    this.Human(role);
                    break;
                
                case RACE.Orc:
                    break;

                case RACE.Parasyte:
                    break;

                case RACE.Spirit:
                    break;

                case RACE.Troll:
                    break;

                case RACE.Undead:
                    break;

                case RACE.Underworld:
                    break;   
            }
        }

        /// <summary>
        /// 天使
        /// 额外的Luc
        /// </summary>
        /// <param name="role"></param>
        private void Angel(Role role) {
            String discription = "居住在天空的尽头,拥有者和人类一样的社会体系,他们是圣洁的象征,由光和神圣守护着.与恶魔为敌.";
            //分配率
            double _str_r_b = 0.95;
            double _agi_r_b = 0.95;
            double _int_r_b = 1.1;
            double _sta_r_b = 0.9;
            double _luc_r_b = 1.2;
            //成长值
            double _str_g = 0.15;
            double _agi_g = 0.15;
            double _int_g = 0.25;
            double _sta_g = 0.2;
            double _luc_g = 0.25;

            role.r_feature_Angel_judgement_of_light = true;
            role.setRace(RACE.Angel, discription,
                        _str_r_b,
                        _str_g,
                        _agi_r_b,
                        _agi_g,
                        _int_r_b,
                        _int_g,
                        _sta_r_b,
                        _sta_g,
                        _luc_r_b,
                        _luc_g);
        }

        /// <summary>
        /// 赛博格 机械生物
        /// </summary>
        /// <param name="role"></param>
        private void Cyborg(Role role)
        {
            String discription = "在机器拥有了自主意识以后便拥有了自己的生命,他们善于进化与模仿.机械生物的生命会随着物质的衰败而衰老,他们的精神可以被转移和再造.机器人没有灵魂.";
            //分配率
            double _str_r_b = 1.1;
            double _agi_r_b = 1.1;
            double _int_r_b = 0.8;
            double _sta_r_b = 1.1;
            double _luc_r_b = 0.9;
            //成长值
            double _str_g = 0.25;
            double _agi_g = 0.25;
            double _int_g = 0.1;
            double _sta_g = 0.25;
            double _luc_g = 0.15;


            role.setRace(RACE.Cyborg, discription,
                        _str_r_b,
                        _str_g,
                        _agi_r_b,
                        _agi_g,
                        _int_r_b,
                        _int_g,
                        _sta_r_b,
                        _sta_g,
                        _luc_r_b,
                        _luc_g);
        }

        /// <summary>
        /// 恶魔
        /// </summary>
        /// <param name="role"></param>
        private void Demon(Role role)
        {
            String discription = "恶魔诞生于地狱之中,他们可以来往于地狱和世界之间.他们收集生物的牙齿和指甲,亲近烈火与恐惧,恶魔族世代与天使族为敌.";
            //分配率
            double _str_r_b = 1.1;
            double _agi_r_b = 1.1;
            double _int_r_b = 0.8;
            double _sta_r_b = 1.1;
            double _luc_r_b = 0.9;
            //成长值
            double _str_g = 0.25;
            double _agi_g = 0.25;
            double _int_g = 0.1;
            double _sta_g = 0.25;
            double _luc_g = 0.15;


            role.setRace(RACE.Demon, discription,
                        _str_r_b,
                        _str_g,
                        _agi_r_b,
                        _agi_g,
                        _int_r_b,
                        _int_g,
                        _sta_r_b,
                        _sta_g,
                        _luc_r_b,
                        _luc_g);
        }

        /// <summary>
        /// 矮人
        /// </summary>
        /// <param name="role"></param>
        private void Dwarf(Role role)
        {
            String discription = "矮人们居住在群山深处,他们有着精湛的挖掘和锻造技艺.矮人是一个与世无争的种族,他们的文明和人类不相上下.";
            //分配率
            double _str_r_b = 1.1;
            double _agi_r_b = 1.1;
            double _int_r_b = 0.8;
            double _sta_r_b = 1.1;
            double _luc_r_b = 0.9;
            //成长值
            double _str_g = 0.25;
            double _agi_g = 0.25;
            double _int_g = 0.1;
            double _sta_g = 0.25;
            double _luc_g = 0.15;


            role.setRace(RACE.Dwarf, discription,
                        _str_r_b,
                        _str_g,
                        _agi_r_b,
                        _agi_g,
                        _int_r_b,
                        _int_g,
                        _sta_r_b,
                        _sta_g,
                        _luc_r_b,
                        _luc_g);
        }

        /// <summary>
        /// 元素
        /// </summary>
        /// <param name="role"></param>
        private void Elemental(Role role)
        {
            String discription = "元素生物是自然的灵魂与精神的体现,他们拥有生命,创造元素,并保证元素的稳定与平衡.他们的生命诞生于元素,也随着元素的消散而消失.他们拥有赋予的智慧与精神.但是他们没有灵魂,因为他们已经是灵魂的体现.";
            //分配率
            double _str_r_b = 1.1;
            double _agi_r_b = 1.1;
            double _int_r_b = 0.8;
            double _sta_r_b = 1.1;
            double _luc_r_b = 0.9;
            //成长值
            double _str_g = 0.25;
            double _agi_g = 0.25;
            double _int_g = 0.1;
            double _sta_g = 0.25;
            double _luc_g = 0.15;


            role.setRace(RACE.Elemental, discription,
                        _str_r_b,
                        _str_g,
                        _agi_r_b,
                        _agi_g,
                        _int_r_b,
                        _int_g,
                        _sta_r_b,
                        _sta_g,
                        _luc_r_b,
                        _luc_g);
        }

        /// <summary>
        /// 精灵
        /// </summary>
        /// <param name="role"></param>
        private void Elf(Role role)
        {
            String discription = "精灵,自然的馈赠.他们是自然地守护者,与山川河流为伍,森林为伴.他们受到森林的祝福和庇护,因此他们可以与森林交流.";
            //分配率
            double _str_r_b = 1.1;
            double _agi_r_b = 1.1;
            double _int_r_b = 0.8;
            double _sta_r_b = 1.1;
            double _luc_r_b = 0.9;
            //成长值
            double _str_g = 0.25;
            double _agi_g = 0.25;
            double _int_g = 0.1;
            double _sta_g = 0.25;
            double _luc_g = 0.15;


            role.setRace(RACE.Elf, discription,
                        _str_r_b,
                        _str_g,
                        _agi_r_b,
                        _agi_g,
                        _int_r_b,
                        _int_g,
                        _sta_r_b,
                        _sta_g,
                        _luc_r_b,
                        _luc_g);
        }

        /// <summary>
        /// 地精
        /// </summary>
        /// <param name="role"></param>
        private void Goblin(Role role)
        {
            String discription = "他们是工业时代的巅峰,拥有很高的智慧.他们的科学产物精妙绝伦.他们以部落的形式散布在世界各地.";
            //分配率
            double _str_r_b = 1.1;
            double _agi_r_b = 1.1;
            double _int_r_b = 0.8;
            double _sta_r_b = 1.1;
            double _luc_r_b = 0.9;
            //成长值
            double _str_g = 0.25;
            double _agi_g = 0.25;
            double _int_g = 0.1;
            double _sta_g = 0.25;
            double _luc_g = 0.15;


            role.setRace(RACE.Goblin, discription,
                        _str_r_b,
                        _str_g,
                        _agi_r_b,
                        _agi_g,
                        _int_r_b,
                        _int_g,
                        _sta_r_b,
                        _sta_g,
                        _luc_r_b,
                        _luc_g);
        }

        /// <summary>
        /// 半兽
        /// </summary>
        /// <param name="role"></param>
        private void Halfbeast(Role role)
        {
            String discription = "拥有近似人类的智慧和野兽般的身体,他们是远古时代的产物,生活在世界的角落,不同的部落间并不会互相往来,大部分的半兽会独自生活.";
            //分配率
            double _str_r_b = 1;
            double _agi_r_b = 1;
            double _int_r_b = 1;
            double _sta_r_b = 1;
            double _luc_r_b = 1;
            //成长值
            double _str_g = 1;
            double _agi_g = 1;
            double _int_g = 1;
            double _sta_g = 1;
            double _luc_g = 1;


            role.setRace(RACE.Halfbeast, discription,
                        _str_r_b,
                        _str_g,
                        _agi_r_b,
                        _agi_g,
                        _int_r_b,
                        _int_g,
                        _sta_r_b,
                        _sta_g,
                        _luc_r_b,
                        _luc_g);

        }


        /// <summary>
        /// 人类
        /// </summary>
        /// <param name="role"></param>
        private void Human(Role role) {
            String discription = "人类是自然文明的产物,他们有自己的阶级与体系,信仰和种族,文化和意识.人类的起源可以追溯到生命体的诞生,历经几万年的进化使他们可以适应多变的环境.人类相信精神身体灵魂的三位一体.";
            //分配率
            double _str_r_b = 1;
            double _agi_r_b = 1;
            double _int_r_b = 1;
            double _sta_r_b = 1;
            double _luc_r_b = 1;
            //成长值
            double _str_g = 1;
            double _agi_g = 1;
            double _int_g = 1;
            double _sta_g = 1;
            double _luc_g = 1;


            role.setRace(RACE.Human, discription,
                        _str_r_b,
                        _str_g,
                        _agi_r_b,
                        _agi_g,
                        _int_r_b,
                        _int_g,
                        _sta_r_b,
                        _sta_g,
                        _luc_r_b,
                        _luc_g);
        
        }


        /// <summary>
        /// 兽人
        /// </summary>
        /// <param name="role"></param>
        private void Orc(Role role)
        {
            String discription = "兽人是在人形生物的一个分支,他们是部落文明,拥有坚定的共同意志.他们拥有强壮的身体,好战.";
            //分配率
            double _str_r_b = 1;
            double _agi_r_b = 1;
            double _int_r_b = 1;
            double _sta_r_b = 1;
            double _luc_r_b = 1;
            //成长值
            double _str_g = 1;
            double _agi_g = 1;
            double _int_g = 1;
            double _sta_g = 1;
            double _luc_g = 1;


            role.setRace(RACE.Orc, discription,
                        _str_r_b,
                        _str_g,
                        _agi_r_b,
                        _agi_g,
                        _int_r_b,
                        _int_g,
                        _sta_r_b,
                        _sta_g,
                        _luc_r_b,
                        _luc_g);

        }



        /// <summary>
        /// 寄生生物
        /// </summary>
        /// <param name="role"></param>
        private void Parasyte(Role role)
        {
            String discription = "寄生生物无法独立存活,他们通常会依附于某种生物,并且凌驾于生物的精神之上.虽然共存,但是他们取代了生物的精神,控制了他们的肉体.";
            //分配率
            double _str_r_b = 1;
            double _agi_r_b = 1;
            double _int_r_b = 1;
            double _sta_r_b = 1;
            double _luc_r_b = 1;
            //成长值
            double _str_g = 1;
            double _agi_g = 1;
            double _int_g = 1;
            double _sta_g = 1;
            double _luc_g = 1;


            role.setRace(RACE.Parasyte, discription,
                        _str_r_b,
                        _str_g,
                        _agi_r_b,
                        _agi_g,
                        _int_r_b,
                        _int_g,
                        _sta_r_b,
                        _sta_g,
                        _luc_r_b,
                        _luc_g);

        }


        /// <summary>
        /// 灵魂体
        /// </summary>
        /// <param name="role"></param>
        private void Spirit(Role role)
        {
            String discription = "代表着灵魂与肉体的羁绊,他们并不是肉体,也并不属于灵魂.他们是被分割的灵魂,以灵魂的形式展现着肉体.他们的生命可能已经延续了近万年.";
            //分配率
            double _str_r_b = 1;
            double _agi_r_b = 1;
            double _int_r_b = 1;
            double _sta_r_b = 1;
            double _luc_r_b = 1;
            //成长值
            double _str_g = 1;
            double _agi_g = 1;
            double _int_g = 1;
            double _sta_g = 1;
            double _luc_g = 1;


            role.setRace(RACE.Spirit, discription,
                        _str_r_b,
                        _str_g,
                        _agi_r_b,
                        _agi_g,
                        _int_r_b,
                        _int_g,
                        _sta_r_b,
                        _sta_g,
                        _luc_r_b,
                        _luc_g);

        }


        /// <summary>
        /// 巨魔
        /// </summary>
        /// <param name="role"></param>
        private void Troll(Role role)
        {
            String discription = "他们的种族与兽人接近,在进化的过程中选择了游牧和捕猎的种族.并没有部落文明.他们精通猎杀和追踪,善于用冷兵器.文明程度比兽人低.";
            //分配率
            double _str_r_b = 1;
            double _agi_r_b = 1;
            double _int_r_b = 1;
            double _sta_r_b = 1;
            double _luc_r_b = 1;
            //成长值
            double _str_g = 1;
            double _agi_g = 1;
            double _int_g = 1;
            double _sta_g = 1;
            double _luc_g = 1;


            role.setRace(RACE.Troll, discription,
                        _str_r_b,
                        _str_g,
                        _agi_r_b,
                        _agi_g,
                        _int_r_b,
                        _int_g,
                        _sta_r_b,
                        _sta_g,
                        _luc_r_b,
                        _luc_g);

        }


        /// <summary>
        /// 不死
        /// </summary>
        /// <param name="role"></param>
        private void Undead(Role role)
        {
            String discription = "他们的灵魂被取走,只剩下肉体与精神.";
            //分配率
            double _str_r_b = 1;
            double _agi_r_b = 1;
            double _int_r_b = 1;
            double _sta_r_b = 1;
            double _luc_r_b = 1;
            //成长值
            double _str_g = 1;
            double _agi_g = 1;
            double _int_g = 1;
            double _sta_g = 1;
            double _luc_g = 1;


            role.setRace(RACE.Undead, discription,
                        _str_r_b,
                        _str_g,
                        _agi_r_b,
                        _agi_g,
                        _int_r_b,
                        _int_g,
                        _sta_r_b,
                        _sta_g,
                        _luc_r_b,
                        _luc_g);

        }


        /// <summary>
        /// 黑暗生物
        /// </summary>
        /// <param name="role"></param>
        private void Underworld(Role role)
        {
            String discription = "他们不是自然所预期的进化产物,生活在黑暗与虚空之间,捕猎任何生命.以生命延续生命.";
            //分配率
            double _str_r_b = 1;
            double _agi_r_b = 1;
            double _int_r_b = 1;
            double _sta_r_b = 1;
            double _luc_r_b = 1;
            //成长值
            double _str_g = 1;
            double _agi_g = 1;
            double _int_g = 1;
            double _sta_g = 1;
            double _luc_g = 1;


            role.setRace(RACE.Underworld, discription,
                        _str_r_b,
                        _str_g,
                        _agi_r_b,
                        _agi_g,
                        _int_r_b,
                        _int_g,
                        _sta_r_b,
                        _sta_g,
                        _luc_r_b,
                        _luc_g);

        }

    }
}
