/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.Runtime.CompilerServices;

namespace DaanV2.NBT {
    public sealed partial class NBTTagFloat {
        /// <summary>Compare two objects to one another to see if they are equal</summary>
        /// <param name="A">The first object to compare</param>
        /// <param name="B">The second object to compare</param>
        /// <returns>Compare two objects to one another to see if they are equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean operator ==(NBTTagFloat A, NBTTagFloat B) {
            Boolean NA = ((Object)A) is null;
            Boolean NB = ((Object)B) is null;

            if (NA && NB) { return true; }
            if (NA || NB) { return false; }

            return A.Equals(B);
        }

        /// <summary>Compare two objects to one another to see if they are not equal</summary>
        /// <param name="A">The first object to compare</param>
        /// <param name="B">The second object to compare</param>
        /// <returns>Compare two objects to one another to see if they are not equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean operator !=(NBTTagFloat A, NBTTagFloat B) {
            return !(A == B);
        }

        /// <summary>Compare two objects to one another to see if they are equal</summary>
        /// <param name="A">The first object to compare</param>
        /// <param name="B">The second object to compare</param>
        /// <returns>Compare two objects to one another to see if they are equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean operator ==(NBTTagFloat A, Object B) {
            Boolean NA = ((Object)A) is null;
            Boolean NB = ((Object)B) is null;

            if (NA && NB) { return true; }
            if (NA || NB) { return false; }

            return A.Equals(B);
        }

        /// <summary>Compare two objects to one another to see if they are not equal</summary>
        /// <param name="A">The first object to compare</param>
        /// <param name="B">The second object to compare</param>
        /// <returns>Compare two objects to one another to see if they are not equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean operator !=(NBTTagFloat A, Object B) {
            return !(A == B);
        }
    }
}
