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
using System.Text;
using DaanV2.Binary;

namespace DaanV2.NBT.Serialization {
    public static partial class NBTWriter {
        ///DOLATER <summary>Add Description</summary>
        /// <param name="Reader"></param>
        ///DOLATER <returns>Fill return</returns>
        public static void WriteString(Stream Writer, String Text, Endianness endianness) {
            Byte[] Bytes = Encoding.UTF8.GetBytes(Text);
            Writer.WriteInt16((Int16)Bytes.Length, endianness);
            Writer.WriteBytes(Bytes);
        }
    }
}