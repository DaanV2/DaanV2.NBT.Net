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

namespace DaanV2.NBT {
    public static partial class StreamExtension {
        /// <summary>Reads the amount of specified bytes from the stream</summary>
        /// <param name="stream">The stream to read from</param>
        /// <param name="Amount">The amount of bytes to read</param>
        /// <returns>Reads the amount of specified bytes from the stream</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte[] ReadBytes(this Stream stream, Int32 Amount) {
            Byte[] Out = new Byte[Amount];

            stream.Read(Out, 0, Amount);
            return Out;
        }

        /// <summary>Writes the given byte array into the stream</summary>
        /// <param name="stream">The stream to write into</param>
        /// <param name="Data">The data to write</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBytes(this Stream stream, Byte[] Data) {
            stream.Write(Data, 0, Data.Length);
        }
    }
}
