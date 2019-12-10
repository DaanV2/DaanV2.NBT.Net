using System;

namespace DaanV2.NBT {
    public static partial class NBTCasting {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        private static Object Convert(Byte Value, Type To) {
            if (To == typeof(Boolean)) {
                return Value > 0;
            }

            return Value;
        }
    }
}
