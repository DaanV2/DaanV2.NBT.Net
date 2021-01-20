/*ISC License

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
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace DaanV2.NBT {
    public static partial class NBTCasting {
        /// <summary>Converts the given tag into a list</summary>
        /// <typeparam name="T">The type to convert the items to</typeparam>
        /// <param name="Tag">The tag to convert to a list</param>
        /// <returns>Converts the given tag into a list</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static List<T> ConvertList<T>(ITag Tag) {
            Int32 Count = Tag.Count;
            var Out = new List<T>(Count);

            for (Int32 I = 0; I < Count; I++) {
                Out.Add(Tag.GetSubValue<T>(I));
            }

            return Out;
        }
    }
}
