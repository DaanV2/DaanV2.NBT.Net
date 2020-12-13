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

namespace DaanV2.NBT {
    /// <summary>The static class that extends upon existing array/collections</summary>
    public static partial class ArrayExtension {
        /// <summary>Extends the clone mechanics of all the tags to collections</summary>
        /// <param name="Values">The values of sub tags to convert</param>
        /// <returns>Extends the clone mechanics of all the tags to collections</returns>
        public static List<ITag> Clone(this List<ITag> Values) {
            Int32 Count = Values.Count;
            List<ITag> Out = new List<ITag>(Count);

            for (Int32 I = 0; I < Count; I++) {
                Out.Add(Values[I].Clone());
            }

            return Out;
        }

        /// <summary>Extends the clone mechanics of all the tags to collections</summary>
        /// <param name="Values">The values of sub tags to convert</param>
        /// <returns>Extends the clone mechanics of all the tags to collections</returns>
        public static List<ITag> Clone(this ITagCollection Values) {
            Int32 Count = Values.Count;
            List<ITag> Out = new List<ITag>(Count);

            for (Int32 I = 0; I < Count; I++) {
                Out.Add(Values[I].Clone());
            }

            return Out;
        }
    }
}
