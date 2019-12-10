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
        private static Object Convert(Int16 Value, Type To) {
            if (To == typeof(List<Int16>)) {
                return new List<Int16> { Value };
            }

            return Value;
        }
    }
}
