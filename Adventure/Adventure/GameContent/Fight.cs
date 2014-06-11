using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.GameContent
{
    class Fight
    {
        public Player player { get; set; }


        public Enemy enemy{get;set;}

        private Fight() {
        }

        /// <summary>
        /// 静态模式
        /// </summary>
        public static Fight instance= new Fight();



    }
}
