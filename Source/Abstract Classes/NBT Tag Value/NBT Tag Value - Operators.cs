/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace DaanV2.NBT {
    public abstract partial class NBTTagValue<TypeValue> {

        /// <summary>Compare two <see cref="NBTTagValue{TypeValue}"/> to see if they are equal</summary>
        /// <param name="A">The first object to compare to</param>
        /// <param name="B">The second object to compare</param>
        /// <returns>Compare two <see cref="NBTTagValue{TypeValue}"/> to see if they are equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean operator ==(NBTTagValue<TypeValue> A, NBTTagValue<TypeValue> B) {
            return EqualityComparer<NBTTagValue<TypeValue>>.Default.Equals(A, B);
        }

        /// <summary>Compare two <see cref="NBTTagValue{TypeValue}"/> to see if they are not equal</summary>
        /// <param name="A">The first object to compare to</param>
        /// <param name="B">The second object to compare</param>
        /// <returns>Compare two <see cref="NBTTagValue{TypeValue}"/> to see if they are not equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean operator !=(NBTTagValue<TypeValue> A, NBTTagValue<TypeValue> B) {
            return !(A == B);
        }
    }
}
