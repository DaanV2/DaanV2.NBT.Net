using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.NBT {
    public static partial class NBTCasting {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="To"></param>
        /// <returns></returns>
        private static Object Convert(Single Value, Type To) {
            if (To == typeof(List<Single>)) {
                return new List<Single> { Value };
            }

            return Value;
        }
    }
}
