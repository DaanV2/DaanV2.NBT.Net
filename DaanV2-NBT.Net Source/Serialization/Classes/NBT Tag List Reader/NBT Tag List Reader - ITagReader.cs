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

namespace DaanV2.NBT.Serialization.Serialization {
    /// <summary>The class that read an nbt tag list from the stream</summary>
    internal partial class NBTTagListReader : ITagReader {
        /// <summary>Gets the type for which this object can read</summary>
        private static readonly NBTTagType[] _ForType = new NBTTagType[] { NBTTagType.List };

        /// <summary>Gets the type for which this object can read</summary>
        public NBTTagType[] ForType => _ForType;

        /// <summary>Reads the nbt's content from the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to read from the <see cref="Stream"/></param>
        /// <param name="Context">The context to read from</param>
        public void ReadContent(ITag tag, SerializationContext Context) {
            ITag SubTag;
            Object O = tag.GetInformation(NBTTagInformation.ListSubtype);
            if (O == null) {
                throw new Exception("List returned no subtype");
            }

            var SubTagType = (NBTTagType)O;
            ITagReader Reader = NBTReader.GetReader(SubTagType);

            if (Reader == null) {
                throw new Exception($"No reader for type: {SubTagType}");
            }

            for (Int32 I = 0; I < tag.Count; I++) {
                SubTag = NBTTagFactory.Create(SubTagType);
                tag[I] = SubTag;
                Reader.ReadContent(SubTag, Context);
            }
        }

        /// <summary>Reads the nbt's header from the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to read from the <see cref="Stream"/></param>
        /// <param name="Context">The context to read from</param>
        public void ReadHeader(ITag tag, SerializationContext Context) {
            tag.Name = NBTReader.ReadString(Context);
            //Read subtype
            tag.SetInformation(NBTTagInformation.ListSubtype, (NBTTagType)Context.Stream.ReadByte());

            //Read size
            tag.SetInformation(NBTTagInformation.ListSize, Context.ReadInt32());
        }
    }
}
