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
        private static Object Convert(String Value, Type To) {
            if (To == typeof(List<String>)) {
                return new List<String> { Value };
            }

            return Value;
        }
    }
}
