/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.Runtime.CompilerServices;

namespace DaanV2.NBT {
    public sealed partial class NBTTagByteArray : IEquatable<NBTTagByteArray> {
        /// <summary>Compare the two given tag with each other</summary>
        /// <param name="A">The first object to compare</param>
        /// <param name="B">The second object to compare</param>
        /// <returns>Compare the two given tag with each other</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean operator ==(NBTTagByteArray A, NBTTagByteArray B) {
            Boolean NA = ((Object)A) == null;
            Boolean NB = ((Object)B) == null;

            if (NA && NB) { return true; }
            if (NA || NB) { return false; }

            return A.Equals(B);
        }

        /// <summary>Compare the two given tag with each other</summary>
        /// <param name="A">The first object to compare</param>
        /// <param name="B">The second object to compare</param>
        /// <returns>Compare the two given tag with each other</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean operator !=(NBTTagByteArray A, NBTTagByteArray B) {
            return !(A == B);
        }

        /// <summary>Compare the two given tag with each other</summary>
        /// <param name="A">The first object to compare</param>
        /// <param name="B">The second object to compare</param>
        /// <returns>Compare the two given tag with each other</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean operator ==(NBTTagByteArray A, Object B) {
            Boolean NA = ((Object)A) == null;
            Boolean NB = ((Object)B) == null;

            if (NA && NB) { return true; }
            if (NA || NB) { return false; }

            return A.Equals(B);
        }

        /// <summary>Compare the two given tag with each other</summary>
        /// <param name="A">The first object to compare</param>
        /// <param name="B">The second object to compare</param>
        /// <returns>Compare the two given tag with each other</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean operator !=(NBTTagByteArray A, Object B) {
            return !(A == B);
        }
    }
}
