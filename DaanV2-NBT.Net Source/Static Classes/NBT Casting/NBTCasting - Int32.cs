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
        private static Object Convert(Int32 Value, Type To) {
            if (To == typeof(List<Int32>)) {
                return new List<Int32> { Value };
            }

            return Value;
        }
    }
}
