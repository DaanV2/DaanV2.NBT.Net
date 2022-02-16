/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace DaanV2.NBT {
    public abstract partial class NBTTag {
        /// <summary>Compare the two given tag with each other</summary>
        /// <param name="A">The first object to compare</param>
        /// <param name="B">The second object to compare</param>
        /// <returns>Compare the two given tag with each other</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean operator ==(NBTTag A, NBTTag B) {
            return EqualityComparer<NBTTag>.Default.Equals(A, B);
        }

        /// <summary>Compare the two given tag with each other</summary>
        /// <param name="A">The first object to compare</param>
        /// <param name="B">The second object to compare</param>
        /// <returns>Compare the two given tag with each other</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean operator !=(NBTTag A, NBTTag B) {
            return !(A == B);
        }
    }
}
