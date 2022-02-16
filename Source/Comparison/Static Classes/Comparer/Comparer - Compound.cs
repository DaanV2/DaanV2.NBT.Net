using System;
using System.Runtime.CompilerServices;

namespace DaanV2.NBT.Comparison {
    ///DOLATER <summary>add description for class: Comparer</summary>
    public static partial class Comparer {
        /// <summary>Compares the two gives list of tags to each other and checks if they are the same</summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean Equals(NBTTagCompound A, NBTTagCompound B) {
            Int32 Value = 0;
            if (A is not null) { Value++; }
            if (B is not null) { Value++; }

            if (Value == 0) { return true; }
            if (Value == 1) { return false; }

            if (A.Count != B.Count || A.Name != B.Name) {
                return false;
            }

            for (Int32 I = 0; I < A.Count; I++) {
                ITag Item = A[I];

                ITag Compare = B[Item.Name];

                if (Item is null || !Item.Equals(Compare)) {
                    return false;
                }
            }

            return true;
        }
    }
}