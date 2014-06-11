using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.GameContent
{
    /// <summary>
    /// 在生命中 所有通用规则将被实现
    /// 例如:
    /// 数值之间的关系
    /// 边界范围
    /// </summary>
    abstract class Life:Bio 
    {
        protected List<Source> ActiveSource = new List<Source>();

        public Life(){
        
        }

        /// <summary>
        /// Class:Life->Role
        /// 等级改变
        /// 改变等级 与关联有效等级
        /// 将触发点数分配,平衡,检测方法.
        /// </summary>
        private void Level_Change() {
            
        }

        /// <summary>
        /// Class:Life->Role
        /// 经验改变 检测经验
        /// 经验的刷新不会和图像刷新率同步
        /// 因此 需要两个值来改变经验值得变化
        /// </summary>
        public void pFun_Exp_Change(int exp) {
        }

        private void Feature_Worker() {
        }


        /// <summary>
        /// Class:Life->Role
        /// 基础 属性方法
        /// 控制有效属性
        /// 有效属性 = (基础属性 + 等级*(种族增长))*种族分配率 (基本属性) + 等级* 职业成长 (成长属性)
        /// 在等级为0时 默认基础属性为5
        /// 种族增长总合  =  1 (每项增长0.2)
        /// 分配率平均为  =  1 
        /// 职业成长综合  =  3 (每项增长0.6)
        /// 升级附加点数  =  1/10 (自由分配)
        /// 为了防止属性造成数据的过量 假设100级时有
        /// 80+5 + 10 = 95 /85 = 1.1176
        /// 因此 假设 150%的有效属性可以使某项效果属性的比例达到最大
        /// 如此 在60000级时 所有附加属性点 可以使 某项属性达到112.5% 有效属性 大约25% 封顶比例
        /// 当溢出封顶属性后 该效果属性的对应基础属性将会受到惩罚 比例大约在5倍
        /// </summary>
        private void Basic_Attribute() {
            
        }

        /// <summary>
        /// Class:Life->Role
        /// 基础 额外属性 - 装备属性
        /// </summary>
        private void Bonus_Attribute() {
        }


        /// <summary>
        /// Class:Life->Role
        /// 受体 方法
        /// 受体会受到源的伤害
        /// </summary>
        public void Receptor(Source s) {


        }
    }
}
