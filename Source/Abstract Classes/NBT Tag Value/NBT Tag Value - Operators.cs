﻿/*ISC License

Copyright (c) 2019, Daan Verstraten, daanverstraten@hotmail.com

Permission to use, copy, modify, and/or distribute this software for any
purpose with or without fee is hereby granted, provided that the above
copyright notice and this permission notice appear in all copies.

THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF
OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.*/
using System;
using System.Runtime.CompilerServices;

namespace DaanV2.NBT {
    public abstract partial class NBTTagValue<TypeValue> {

        /// <summary>Compare two <see cref="NBTTagValue{TypeValue}"/> to see if they are equal</summary>
        /// <param name="A">The first object to compare to</param>
        /// <param name="B">The second object to compare</param>
        /// <returns>Compare two <see cref="NBTTagValue{TypeValue}"/> to see if they are equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean operator ==(NBTTagValue<TypeValue> A, NBTTagValue<TypeValue> B) {
            Boolean NA = ((Object)A) == null;
            Boolean NB = ((Object)B) == null;

            if (NA && NB) { return true; }
            if (NA || NB) { return false; }

            return A.Equals(B);
        }

        /// <summary>Compare two <see cref="NBTTagValue{TypeValue}"/> to see if they are not equal</summary>
        /// <param name="A">The first object to compare to</param>
        /// <param name="B">The second object to compare</param>
        /// <returns>Compare two <see cref="NBTTagValue{TypeValue}"/> to see if they are not equal</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean operator !=(NBTTagValue<TypeValue> A, NBTTagValue<TypeValue> B) {
            return !(A == B);
        }

        /// <summary>Compare one <see cref="NBTTagValue{TypeValue}"/> equals a given object</summary>
        /// <param name="A">The first object to compare to</param>
        /// <param name="B">The second object to compare</param>
        /// <returns>Compare one <see cref="NBTTagValue{TypeValue}"/> equals a given object</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean operator ==(NBTTagValue<TypeValue> A, Object B) {
            Boolean NA = ((Object)A) == null;
            Boolean NB = ((Object)B) == null;

            if (NA && NB) { return true; }
            if (NA || NB) { return false; }

            return A.Equals(B);
        }

        /// <summary>Compare one <see cref="NBTTagValue{TypeValue}"/> not equals a given object</summary>
        /// <param name="A">The first object to compare to</param>
        /// <param name="B">The second object to compare</param>
        /// <returns>Compare one <see cref="NBTTagValue{TypeValue}"/> not equals a given object</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean operator !=(NBTTagValue<TypeValue> A, Object B) {
            return !(A == B);
        }

        /// <summary>Compare one <see cref="NBTTagValue{TypeValue}"/> equals a given object</summary>
        /// <param name="A">The first object to compare to</param>
        /// <param name="B">The second object to compare</param>
        /// <returns>Compare one <see cref="NBTTagValue{TypeValue}"/> equals a given object</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean operator ==(NBTTagValue<TypeValue> A, TypeValue B) {
            Boolean NA = ((Object)A) == null;
            Boolean NB = ((Object)B) == null;

            if (NA && NB) { return true; }
            if (NA || NB) { return false; }

            return A.Equals(B);
        }

        /// <summary>Compare one <see cref="NBTTagValue{TypeValue}"/> not equals a given object</summary>
        /// <param name="A">The first object to compare to</param>
        /// <param name="B">The second object to compare</param>
        /// <returns>Compare one <see cref="NBTTagValue{TypeValue}"/> not equals a given object</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean operator !=(NBTTagValue<TypeValue> A, TypeValue B) {
            return !(A == B);
        }
    }
}
