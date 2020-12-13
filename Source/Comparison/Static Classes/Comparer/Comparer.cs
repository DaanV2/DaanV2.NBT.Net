using System;
using System.Collections.Generic;

namespace DaanV2.NBT.Comparison {
    ///DOLATER <summary>add description for class: Comparer</summary>
    public static partial class Comparer {
        /// <summary>Compares the two gives list of tags to each other and checks if they are the same</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Boolean Equals<T>(List<T> A, List<T> B)
            where T : ITag {

            Int32 Value = 0;
            if (A != null) { Value++; }
            if (B != null) { Value++; }

            if (Value == 0) { return true; }
            if (Value == 1) { return false; }

            if (A.Count != B.Count) {
                return false;
            }

            for (Int32 I = 0; I < A.Count; I++) {
                if (!A[I].Equals(B[I])) {
                    return false;
                }
            }

            return true;
        }

        /// <summary>Compares the two gives list of tags to each other and checks if they are the same. uses B as if it was a List of tags</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Boolean Equals<T>(List<T> A, ITag B)
    where T : ITag {

            Int32 Value = 0;
            if (A != null) { Value++; }
            if (B != null) { Value++; }

            if (Value == 0) { return true; }
            if (Value == 1) { return false; }

            if (A.Count != B.Count) {
                return false;
            }

            for (Int32 I = 0; I < A.Count; I++) {
                if (!A[I].Equals(B[I])) {
                    return false;
                }
            }

            return true;
        }
    }
}
