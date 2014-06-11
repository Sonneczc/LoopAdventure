using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.GameContent
{
    interface Bio_Interface
    {
        /// <summary>
        /// 力量
        /// strength
        /// </summary>
        double ma_dSTR { get; set; }
        /// <summary>
        /// 力量分配率
        /// </summary>
        double ma_dSTR_RACE_BONUS { get; set; }
        /// <summary>
        /// 力量增长值
        /// </summary>
        double ma_dSTR_G { get; set; }
        /// <summary>
        /// 力量增长值职业修正
        /// </summary>
        double ma_dSTR_G_BONUS { get; set; }

        /// <summary>
        /// 敏捷
        /// agility
        /// </summary>
        double ma_dAGI { get; set; }
        /// <summary>
        /// 敏捷分配率
        /// </summary>
        double ma_dAGI_RACE_BONUS { get; set; }
        /// <summary>
        /// 敏捷增长值
        /// </summary>
        double ma_dAGI_G { get; set; }
        /// <summary>
        /// 敏捷增长值职业修正
        /// </summary>
        double ma_dAGI_G_BONUS { get; set; }


        /// <summary>
        /// 智力
        /// intelligent 
        /// </summary>
        double ma_dINT { get; set; }
        /// <summary>
        /// 智力分配率
        /// </summary>
        double ma_dINT_RACE_BONUS { get; set; }
        /// <summary>
        /// 智力增长值
        /// </summary>
        double ma_dINT_G { get; set; }
        /// <summary>
        /// 智力增长值职业修正
        /// </summary>
        double ma_dINT_G_BONUS { get; set; }


        /// <summary>
        /// 耐力
        /// stamina
        /// </summary>
        double ma_dSTA { get; set; }
        /// <summary>
        /// 耐力分配率
        /// </summary>
        double ma_dSTA_RACE_BONUS { get; set; }
        /// <summary>
        /// 耐力增长值
        /// </summary>
        double ma_dSTA_G { get; set; }
        /// <summary>
        /// 耐力增长值职业修正
        /// </summary>
        double ma_dSTA_G_BONUS { get; set; }


        /// <summary>
        /// 幸运
        /// Luck
        /// </summary>
        double ma_dLUC { get; set; }
        /// <summary>
        /// 幸运分配率
        /// </summary>
        double ma_dLUC_RACE_BONUS { get; set; }
        /// <summary>
        /// 幸运增长值
        /// </summary>
        double ma_dLUC_G { get; set; }
        /// <summary>
        /// 幸运增长值职业修正
        /// </summary>
        double ma_dLUC_G_BONUS { get; set; }


        /// <summary>
        /// 攻击力 默认为 15;
        /// attack
        /// 成长将由主属性决定
        /// </summary>
        UInt32 ea_ATT { get; set; }
        double ea_fATT_RATE { get; set; }



        //-----------------STR
        /// <summary>
        /// 反击率 默认为 0
        /// counter strike rate
        /// </summary>
        double ea_fCOU { get; set; }
        double ea_fCOU_CLASS_BONUS { get; set; }
        double ea_fCOU_CORRECTION_VALUE { get; set; }
        double ea_fCOU_CORRECTION_RATE { get; set; }

        /// <summary>
        /// 格挡率 默认为 0;
        /// block rate
        /// </summary>
        double ea_fBLO { get; set; }
        double ea_fBLO_CLASS_BONUS { get; set; }
        double ea_fBLO_CORRECTION_VALUE { get; set; }
        double ea_fBLO_CORRECTION_RATE { get; set; }

        /// <summary>
        /// 格挡效能 默认为 0.1f
        /// block effort
        /// </summary>
        double ea_fBLO_EFF { get; set; }
        double ea_fBLO_EFF_CLASS_BONUS { get; set; }
        double ea_fBLO_EFF_CORRECTION_VALUE { get; set; }
        double ea_fBLO_EFF_CORRECTION_RATE { get; set; }

        //-----------------------------------

        //------------------AGI
        /// <summary>
        /// 暴击率 默认为0
        /// critical rate
        /// </summary>
        double ea_fCRI { get; set; }
        double ea_fCRI_CLASS_BONUS { get; set; }
        double ea_fCRI_CORRECTION_VALUE { get; set; }
        double ea_fCRI_CORRECTION_RATE { get; set; }

        /// <summary>
        /// 暴击倍率 默认为1.05f
        /// critical multiplier
        /// </summary>
        double ea_fCRI_MUL { get; set; }
        double ea_fCRI_MUL_CLASS_BONUS { get; set; }
        double ea_fCRI_MUL_CORRECTION_VALUE { get; set; }
        double ea_fCRI_MUL_CORRECTION_RATE { get; set; }

        /// <summary>
        /// 闪避率 默认为 0
        /// dodge rate
        /// </summary>
        double ea_fDOD { get; set; }
        double ea_fDOD_CLASS_BONUS { get; set; }
        double ea_fDOD_CORRECTION_VALUE { get; set; }
        double ea_fDOD_CORRECTION_RATE { get; set; }

        /// <summary>
        /// 命中率 默认为 1f
        /// hit rate
        /// </summary>
        double ea_fHIT { get; set; }
        double ea_fHIT_CLASS_BONUS { get; set; }
        double ea_fHIT_CORRECTION_VALUE { get; set; }
        double ea_fHIT_CORRECTION_RATE { get; set; }

        /// <summary>
        /// 速度 默认50;
        /// Speed
        /// 影响先攻
        /// </summary>
        UInt32 ea_SPE { get; set; }
        double ea_fSPE_CLASS_BONUS { get; set; }
        double ea_fSPE_CORRECTION_VALUE { get; set; }
        double ea_fSPE_CORRECTION_RATE { get; set; }

        //----------------------------------

        //----------------INT
        /// <summary>
        /// 技艺 技能释放率
        /// skill
        /// </summary>
        double ea_fSKI { get; set; }
        double ea_fSKI_CLASS_BONUS { get; set; }
        double ea_fSKI_CORRECTION_VALUE { get; set; }
        double ea_fSKI_CORRECTION_RATE { get; set; }

        /// <summary>
        /// 反射率 默认为 0
        /// magic reflection rate 
        /// </summary>
        double ea_fMAG_REF { get; set; }
        double ea_fMAG_REF_CLASS_BONUS { get; set; }
        double ea_fMAG_REF_CORRECTION_VALUE { get; set; }
        double ea_fMAG_REF_CORRECTION_RATE { get; set; }

        /// <summary>
        /// 魔法抵抗率 默认为 0;
        /// magic resistance
        /// </summary>
        double ea_fMAG_RES { get; set; }
        double ea_fMAG_RES_CLASS_BONUS { get; set; }
        double ea_fMAG_RES_CORRECTION_VALUE { get; set; }
        double ea_fMAG_RES_CORRECTION_RATE { get; set; }

        //-------------------

        //--------------STA

        /// <summary>
        /// 生命值 默认100;
        /// health point
        /// </summary>
        double ea_dHP { get; set; }
        double ea_dHP_CLASS_BONUS { get; set; }
        double ea_dHP_CORRECTION_VALUE { get; set; }
        double ea_dHP_CORRECTION_RATE { get; set; }

        /// <summary>
        /// 生命恢复 默认为1
        /// hp regeneration
        /// </summary>
        double ea_fHP_REG { get; set; }
        double ea_fHP_REG_CLASS_BONUS { get; set; }
        double ea_fHP_REG_CORRECTION_VALUE { get; set; }
        double ea_fHP_REG_CORRECTION_RATE { get; set; }



        /// <summary>
        /// 防御力 默认为 10
        /// defence
        /// </summary>
        Int32 ea_DEF { get; set; }
        double ea_fDEF_CLASS_BONUS { get; set; }
        double ea_fDEF_CORRECTION_VALUE { get; set; }
        double ea_fDEF_CORRECTION_RATE { get; set; }
        double ea_fDEF_RATE { get; set; }

        /// <summary>
        /// 魔法防御力 默认为 10
        /// magic defence
        /// </summary>
        Int32 ea_DEF_MAG { get; set; }
        double ea_fDEF_MAG_CLASS_BONUS { get; set; }
        double ea_fDEF_MAG_CORRECTION_VALUE { get; set; }
        double ea_fDEF_MAG_CORRECTION_RATE { get; set; }
        double ea_fDEF_MAG_RATE { get; set; }

        /// <summary>
        /// 负面抗性 默认为 0
        /// Negative resistance
        /// </summary>
        double ea_fNEG_RES { get; set; }
        double ea_fNEG_RES_CLASS_BONUS { get; set; }
        double ea_fNEG_RES_CORRECTION_VALUE { get; set; }
        double ea_fNEG_RES_CORRECTION_RATE { get; set; }

        //--------------------

        //-----------------------LUC
        /// <summary>
        /// 眷顾 默认为   0.01f
        /// favor
        double ea_fFAV { get; set; }
        double ea_fFAV_CLASS_BONUS { get; set; }
        double ea_fFAV_CORRECTION_VALUE { get; set; }
        double ea_fFAV_CORRECTION_RATE { get; set; }

        /// <summary>
        /// 康复率 默认为 0.2f;
        /// 从负面状态复原
        /// renew
        /// </summary>
        double ea_fREN { get; set; }
        double ea_fREN_CLASS_BONUS { get; set; }
        double ea_fREN_CORRECTION_VALUE { get; set; }
        double ea_fREN_CORRECTION_RATE { get; set; }

        /// <summary>
        /// 触发率 默认为 0.2f;
        /// 技能触发率 和主属性关联
        /// trigger rate
        /// </summary>
        double ea_fTRI { get; set; }
        double ea_fTRI_CLASS_BONUS { get; set; }
        double ea_fTRI_CORRECTION_VALUE { get; set; }
        double ea_fTRI_CORRECTION_RATE { get; set; }
    }
}
