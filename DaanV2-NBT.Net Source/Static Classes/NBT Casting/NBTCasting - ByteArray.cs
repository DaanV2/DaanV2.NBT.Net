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
        /// <returns></returns>
        private static Object Convert(Byte[] Value, Type To) {
            if (To == typeof(List<Byte>)) {
                return new List<Byte>(Value);
            }

            return Value;
        }
    }
}
