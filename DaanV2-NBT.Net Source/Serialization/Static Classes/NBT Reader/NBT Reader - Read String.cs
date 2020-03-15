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
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using DaanV2.Binary;

namespace DaanV2.NBT.Serialization {
    public static partial class NBTReader {
        /// <summary>Read a string from the given stream</summary>
        /// <param name="Reader">The stream to read from</param>
        /// <param name="endianness">The endianness of the NBT structure</param>
        /// <returns>Read a string from the given stream</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static String ReadString(Stream Reader, Endianness endianness) {
            Byte[] Data = new Byte[2];

            Reader.Read(Data, 0, Data.Length);
            Int32 Length = Binary.BitConverter.Endian.ToInt16(Data, endianness);
            return Encoding.UTF8.GetString(Reader.ReadBytes(Length));
        }

        /// <summary>Read a string from the given context</summary>
        /// <param name="Context">The context to read from</param>
        /// <returns>Read a string from the given context</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static String ReadString(SerializationContext Context) {
            Int32 Length = Context.ReadInt16();
            return Encoding.UTF8.GetString(Context.ReadBytes(Length));
        }
    }
}