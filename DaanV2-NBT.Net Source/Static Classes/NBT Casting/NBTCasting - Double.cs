using System;
using System.Collections.Generic;

namespace DaanV2.NBT {
    public static partial class NBTCasting {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        private static Object Convert(Double Value, Type To) {
            if (To == typeof(List<Double>)) {
                return new List<Double> { Value };
            }

            return Value;
        }
    }
}
