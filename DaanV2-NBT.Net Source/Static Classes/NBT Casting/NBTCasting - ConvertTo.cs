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
        /// <typeparam name="T"></typeparam>
        /// <param name="Value"></param>
        /// <returns></returns>
        static public T ConvertTo<T>(Object Value) {
            if (Value == null)
                return default;

            Type To = typeof(T);

            if (To == Value.GetType())
                return (T)Value;

            if (Value is Byte B)
                return (T)NBTCasting.Convert(B, To);

            else if (Value is Byte[] Barray)
                return (T)NBTCasting.Convert(Barray, To);

            else if (Value is Double D)
                return (T)NBTCasting.Convert(D, To);

            else if (Value is float F)
                return (T)NBTCasting.Convert(F, To);

            else if (Value is Int32 I32)
                return (T)NBTCasting.Convert(I32, To);

            else if (Value is Int32[] I32array)
                return (T)NBTCasting.Convert(I32array, To);

            else if (Value is Int64 I64)
                return (T)NBTCasting.Convert(I64, To);

            else if (Value is Int64[] I64array)
                return (T)NBTCasting.Convert(I64array, To);

            else if (Value is Int16 I16)
                return (T)NBTCasting.Convert(I16, To);

            else if (Value is String S)
                return (T)NBTCasting.Convert(S, To);

            return (T)Value;
        }
    }
}
