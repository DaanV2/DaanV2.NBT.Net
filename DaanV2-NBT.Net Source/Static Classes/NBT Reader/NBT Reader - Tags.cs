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
using DaanV2.Binary;
using DaanV2.NBT.Serialization;

namespace DaanV2.NBT {
    public static partial class NBTReader {
        ///DOLATER <summary>Add Description</summary>
        /// <param name="Reader"></param>
        /// <returns></returns>
        public static ITag Read(Stream stream, Endianness endianness) {
            Int32 FirstByte = stream.ReadByte();
            if (FirstByte == -1) {
                return default;
            }

            NBTTagType Type = (NBTTagType)FirstByte;
            ITag Receiver = NBTTagFactory.Create(Type);

            if (Type == NBTTagType.End || Type == NBTTagType.Unknown) {
                return Receiver;
            }

            ITagReader Reader;
            NBTReader._Readers.TryGetValue(Type, out Reader);

            if (Reader == null) {
                throw new Exception($"No ITagWriter found for: {Type}");
            }

            Reader.ReadHeader(Receiver, stream, endianness);
            Reader.ReadContent(Receiver, stream, endianness);

            return Receiver;
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="Reader"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static void ReadHeader(NBTTagType Type, Stream stream, ITag Receiver, Endianness endianness) {
            ITagReader Reader;
            NBTReader._Readers.TryGetValue(Type, out Reader);

            if (Reader == null) {
                throw new Exception($"No ITagWriter found for: {Type}");
            }

            Reader.ReadHeader(Receiver, stream, endianness);
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="Type"></param>
        /// <param name="Tag"></param>
        public static void ReadContent(NBTTagType Type, Stream stream, ITag Receiver, Endianness endianness) {
            ITagReader Reader;
            NBTReader._Readers.TryGetValue(Type, out Reader);

            if (Reader == null) {
                throw new Exception($"No ITagWriter found for: {Type}");
            }

            Reader.ReadContent(Receiver, stream, endianness);
        }
    }
}