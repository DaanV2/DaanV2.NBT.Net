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
using System.IO;
using System.Runtime.CompilerServices;
using DaanV2.Binary;

namespace DaanV2.NBT {
    /// <summary>The static class that extends upon the default streams</summary>
    public static partial class StreamExtension {
        /// <summary>Writes an <see cref="Int16"/> into the <see cref="Stream"/></summary>
        /// <param name="Stream">The stream to write to</param>
        /// <param name="Value">The value to convert and write to <see cref="Stream"/></param>
        /// <param name="Endianness">The endiannness of the data</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteInt16(this Stream Stream, Int16 Value, Endianness Endianness) {
            Byte[] Buffer = DaanV2.Binary.BitConverter.Endian.ToBytes(Value, Endianness);
            Stream.Write(Buffer, 0, Buffer.Length);
        }
    }
}
