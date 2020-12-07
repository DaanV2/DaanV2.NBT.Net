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

namespace DaanV2.NBT.Serialization {
    public static partial class NBTReader {
        /// <summary>Reads the NBTTag from the given stream</summary>
        /// <param name="stream">The stream to read from</param>
        /// <param name="endianness">the endianness of the NBT structure</param>
        /// <returns>Reads the NBTTag from the given stream</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ITag Read(Stream stream, Endianness endianness) {
            return Read(new SerializationContext(endianness, stream));
        }

        /// <summary>Reads the NBTTag from the given stream</summary>
        /// <param name="Context">The context to read from</param>
        /// <returns>Reads the NBTTag from the given stream</returns>
        public static ITag Read(SerializationContext Context) {
            Int32 FirstByte = Context.Stream.ReadByte();
            if (FirstByte == -1) {
                return default;
            }

            var Type = (NBTTagType)FirstByte;
            ITag Receiver = NBTTagFactory.Create(Type);

            if (Type == NBTTagType.End || Type == NBTTagType.Unknown) {
                return Receiver;
            }

            NBTReader._Readers.TryGetValue(Type, out ITagReader Reader);

            if (Reader == null) {
                throw new Exception($"No ITagWriter found for: {Type}");
            }

            Reader.ReadHeader(Receiver, Context);
            Reader.ReadContent(Receiver, Context);

            return Receiver;
        }

        /// <summary>Reads the header of the given tag</summary>
        /// <param name="Type">The type to read</param>
        /// <param name="Context">The context needed to read from</param>
        /// <param name="Receiver">The receing tag</param>
        public static void ReadHeader(NBTTagType Type, SerializationContext Context, ITag Receiver) {
            NBTReader._Readers.TryGetValue(Type, out ITagReader Reader);

            if (Reader == null) {
                throw new Exception($"No ITagWriter found for: {Type}");
            }

            Reader.ReadHeader(Receiver, Context);
        }

        /// <summary>Reads the content of the given tag</summary>
        /// <param name="Type">The type to read</param>
        /// <param name="Context">The context needed to read from</param>
        /// <param name="Receiver">The receing tag</param>
        public static void ReadContent(NBTTagType Type, SerializationContext Context, ITag Receiver) {
            NBTReader._Readers.TryGetValue(Type, out ITagReader Reader);

            if (Reader == null) {
                throw new Exception($"No ITagWriter found for: {Type}");
            }

            Reader.ReadContent(Receiver, Context);
        }
    }
}