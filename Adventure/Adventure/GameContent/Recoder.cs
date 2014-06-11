using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.GameContent
{
    public sealed class Recoder
    {
        private Recoder()
        {
        }

        /// <summary>
        /// 静态只读模式
        /// </summary>
        public static readonly Recoder instance= new Recoder();
    }
}
