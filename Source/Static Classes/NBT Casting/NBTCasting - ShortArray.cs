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
        /// <summary>Converts the given byte to the specified type</summary>
        /// <param name="Value">The value to convert</param>
        /// <param name="To">The type to convert to</param>
        /// <returns>Converts the given byte to the specified type</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Object Convert(Int16[] Value, Type To) {
            if (To == typeof(List<Int16>)) {
                return new List<Int16>(Value);
            }

            return Value;
        }
    }
}
