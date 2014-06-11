using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.GameContent
{
    /// <summary>
    /// Biology 
    /// 我认为所有的人物都会有某些特定的基本特征
    /// 这个类将会有所有的基础属性 以及关联属性
    /// 所有的人物将会作为这个类的子类来开发
    /// </summary>
    public abstract class Bio
    {
        public Bio() {
        }

        /// <summary>
        /// 力量
        /// strength
        /// </summary>
        protected double ma_dSTR = 5;
        /// <summary>
        /// 力量分配率
        /// </summary>
        protected double ma_dSTR_RACE_BONUS = 1;
        /// <summary>
        /// 力量增长值
        /// </summary>
        protected double ma_dSTR_G = 0;
        /// <summary>
        /// 力量增长值职业修正
        /// </summary>
        protected double ma_dSTR_G_BONUS = 1;

        /// <summary>
        /// 敏捷
        /// agility
        /// </summary>
        protected double ma_dAGI = 5;
        /// <summary>
        /// 敏捷分配率
        /// </summary>
        protected double ma_dAGI_RACE_BONUS = 1;
        /// <summary>
        /// 敏捷增长值
        /// </summary>
        protected double ma_dAGI_G = 0;
        /// <summary>
        /// 敏捷增长值职业修正
        /// </summary>
        protected double ma_dAGI_G_BONUS = 1;


        /// <summary>
        /// 智力
        /// intelligent 
        /// </summary>
        protected double ma_dINT = 5;
        /// <summary>
        /// 智力分配率
        /// </summary>
        protected double ma_dINT_RACE_BONUS = 1;
        /// <summary>
        /// 智力增长值
        /// </summary>
        protected double ma_dINT_G = 0;
        /// <summary>
        /// 智力增长值职业修正
        /// </summary>
        protected double ma_dINT_G_BONUS = 1;


        /// <summary>
        /// 耐力
        /// stamina
        /// </summary>
        protected double ma_dSTA = 5;
        /// <summary>
        /// 耐力分配率
        /// </summary>
        protected double ma_dSTA_RACE_BONUS = 1;
        /// <summary>
        /// 耐力增长值
        /// </summary>
        protected double ma_dSTA_G = 0;
        /// <summary>
        /// 耐力增长值职业修正
        /// </summary>
        protected double ma_dSTA_G_BONUS = 1;


        /// <summary>
        /// 幸运
        /// Luck
        /// </summary>
        protected double ma_dLUC = 5;
        /// <summary>
        /// 幸运分配率
        /// </summary>
        protected double ma_dLUC_RACE_BONUS = 1;
        /// <summary>
        /// 幸运增长值ea_
        /// </summary>
        protected double ma_dLUC_G = 0;
        /// <summary>
        /// 幸运增长值职业修正
        /// </summary>
        protected double ma_dLUC_G_BONUS = 1;

        ////extra

        /// <summary>
        /// 攻击力 默认为 15;
        /// attack
        /// 成长将由主属性决定
        /// </summary>
        protected UInt32 ea_ATT = 15;
        /// <summary>
        /// 攻击力 总的输出比例
        /// </summary>
        protected double ea_dATT_RATE { get; set; }
        /// <summary>
        /// 攻击力 职业加成
        /// </summary>
        protected double ea_dATT_CLASS_BONUS { get; set; }
        /// <summary>
        /// 修正
        /// </summary>
        protected double ea_dATT_CORRECTION_VALUE { get; set; }
        /// <summary>
        /// 比例修正
        /// </summary>
        protected double ea_dATT_CORRECTION_RATE { get; set; }


        //-----------------STR
        /// <summary>
        /// 反击率 默认为 0
        /// counter strike rate
        /// </summary>
        protected double ea_dCOU = 0;
        protected double ea_dCOU_CLASS_BONUS { get; set; }
        protected double ea_dCOU_CORRECTION_VALUE { get; set; }
        protected double ea_dCOU_CORRECTION_RATE { get; set; }

        /// <summary>
        /// 格挡率 默认为 0;
        /// block rate
        /// </summary>
        protected double ea_dBLO = 0;
        protected double ea_dBLO_CLASS_BONUS { get; set; }
        protected double ea_dBLO_CORRECTION_VALUE { get; set; }
        protected double ea_dBLO_CORRECTION_RATE { get; set; }

        /// <summary>
        /// 格挡效能 默认为 0.1d
        /// block eddort
        /// </summary>
        protected double ea_dBLO_EFF = 0.1d;
        protected double ea_dBLO_EFF_CLASS_BONUS { get; set; }
        protected double ea_dBLO_EFF_CORRECTION_VALUE { get; set; }
        protected double ea_dBLO_EFF_CORRECTION_RATE { get; set; }

        //-----------------------------------

        //------------------AGI
        /// <summary>
        /// 暴击率 默认为0
        /// critical rate
        /// </summary>
        protected double ea_dCRI = 0;
        protected double ea_dCRI_CLASS_BONUS { get; set; }
        protected double ea_dCRI_CORRECTION_VALUE { get; set; }
        protected double ea_dCRI_CORRECTION_RATE { get; set; }

        /// <summary>
        /// 暴击倍率 默认为1.05d
        /// critical multiplier
        /// </summary>
        protected double ea_dCRI_MUL = 1.05d;
        protected double ea_dCRI_MUL_CLASS_BONUS { get; set; }
        protected double ea_dCRI_MUL_CORRECTION_VALUE { get; set; }
        protected double ea_dCRI_MUL_CORRECTION_RATE { get; set; }

        /// <summary>
        /// 闪避率 默认为 0
        /// dodge rate
        /// </summary>
        protected double ea_dDOD = 0;
        protected double ea_dDOD_CLASS_BONUS { get; set; }
        protected double ea_dDOD_CORRECTION_VALUE { get; set; }
        protected double ea_dDOD_CORRECTION_RATE { get; set; }

        /// <summary>
        /// 命中率 默认为 1d
        /// hit rate
        /// </summary>
        protected double ea_dHIT = 1d;
        protected double ea_dHIT_CLASS_BONUS { get; set; }
        protected double ea_dHIT_CORRECTION_VALUE { get; set; }
        protected double ea_dHIT_CORRECTION_RATE { get; set; }

        /// <summary>
        /// 速度 默认50;
        /// Speed
        /// 影响先攻
        /// </summary>
        protected UInt32 ea_SPE = 50;
        protected double ea_dSPE_CLASS_BONUS { get; set; }
        protected double ea_dSPE_CORRECTION_VALUE { get; set; }
        protected double ea_dSPE_CORRECTION_RATE { get; set; }

        //----------------------------------

        //----------------INT
        /// <summary>
        /// 技艺 技能释放率
        /// skill
        /// </summary>
        protected double ea_dSKI = 1d;
        protected double ea_dSKI_CLASS_BONUS { get; set; }
        protected double ea_dSKI_CORRECTION_VALUE { get; set; }
        protected double ea_dSKI_CORRECTION_RATE { get; set; }

        /// <summary>
        /// 反射率 默认为 0
        /// magic redlection rate 
        /// </summary>
        protected double ea_dMAG_REF = 0;
        protected double ea_dMAG_REF_CLASS_BONUS { get; set; }
        protected double ea_dMAG_REF_CORRECTION_VALUE { get; set; }
        protected double ea_dMAG_REF_CORRECTION_RATE { get; set; }

        /// <summary>
        /// 魔法抵抗率 默认为 0;
        /// magic resistance
        /// </summary>
        protected double ea_dMAG_RES = 0;
        protected double ea_dMAG_RES_CLASS_BONUS { get; set; }
        protected double ea_dMAG_RES_CORRECTION_VALUE { get; set; }
        protected double ea_dMAG_RES_CORRECTION_RATE { get; set; }

        //-------------------

        //--------------STA

        /// <summary>
        /// 生命值 默认100;
        /// health point
        /// </summary>
        protected double ea_dHP = 100;
        protected double ea_dHP_CLASS_BONUS { get; set; }
        protected double ea_dHP_CORRECTION_VALUE { get; set; }
        protected double ea_dHP_CORRECTION_RATE { get; set; }

        /// <summary>
        /// 生命恢复 默认为1
        /// hp regeneration
        /// </summary>
        protected double ea_dHP_REG = 1;
        protected double ea_dHP_REG_CLASS_BONUS { get; set; }
        protected double ea_dHP_REG_CORRECTION_VALUE { get; set; }
        protected double ea_dHP_REG_CORRECTION_RATE { get; set; }



        /// <summary>
        /// 防御力 默认为 10
        /// dedence
        /// </summary>
        protected Int32 ea_DEF = 10;
        protected double ea_dDEF_CLASS_BONUS { get; set; }
        protected double ea_dDEF_CORRECTION_VALUE { get; set; }
        protected double ea_dDEF_CORRECTION_RATE { get; set; }
        protected double ea_dDEF_RATE = 1;

        /// <summary>
        /// 魔法防御力 默认为 10
        /// magic dedence
        /// </summary>
        protected Int32 ea_DEF_MAG = 10;
        protected double ea_dDEF_MAG_CLASS_BONUS { get; set; }
        protected double ea_dDEF_MAG_CORRECTION_VALUE { get; set; }
        protected double ea_dDEF_MAG_CORRECTION_RATE { get; set; }
        protected double ea_dDEF_MAG_RATE = 1;

        /// <summary>
        /// 负面抗性 默认为 0
        /// Negative resistance
        /// </summary>
        protected double ea_dNEG_RES = 0.05d;
        protected double ea_dNEG_RES_CLASS_BONUS { get; set; }
        protected double ea_dNEG_RES_CORRECTION_VALUE { get; set; }
        protected double ea_dNEG_RES_CORRECTION_RATE { get; set; }

        //--------------------

        //-----------------------LUC
        /// <summary>
        /// 眷顾 默认为   0.01d
        /// davor
        protected double ea_dFAV = 0.01d;
        protected double ea_dFAV_CLASS_BONUS { get; set; }
        protected double ea_dFAV_CORRECTION_VALUE { get; set; }
        protected double ea_dFAV_CORRECTION_RATE { get; set; }

        /// <summary>
        /// 康复率 默认为 0.2d;
        /// 从负面状态复原
        /// renew
        /// </summary>
        protected double ea_dREN = 0.2d;
        protected double ea_dREN_CLASS_BONUS { get; set; }
        protected double ea_dREN_CORRECTION_VALUE { get; set; }
        protected double ea_dREN_CORRECTION_RATE { get; set; }

        /// <summary>
        /// 触发率 默认为 0.2d;
        /// 技能触发率 和主属性关联
        /// trigger rate
        /// </summary>
        protected double ea_dTRI = 0.2d;
        protected double ea_dTRI_CLASS_BONUS { get; set; }
        protected double ea_dTRI_CORRECTION_VALUE { get; set; }
        protected double ea_dTRI_CORRECTION_RATE { get; set; }
    }
}
