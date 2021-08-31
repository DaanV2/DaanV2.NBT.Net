/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.IO;

namespace DaanV2.NBT.Serialization.Serialization {
    /// <summary>The class that write a given NBT Tag compound into stream</summary>
    internal partial class NBTTagCompoundWriter : ITagWriter {
        /// <summary>Gets the type for which this object can write</summary>
        private static readonly NBTTagType[] _ForType = new NBTTagType[] { NBTTagType.Compound };

        /// <summary>Writes the nbt's header to the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to write to the <see cref="Stream"/></param>
        /// <param name="Context">The context to write to</param>
        public void WriteHeader(ITag tag, SerializationContext Context) {
            Context.Stream.WriteByte((Byte)tag.Type);
            NBTWriter.WriteString(Context, tag.Name);
        }

        /// <summary>Writes the nbt's content to the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to write to the <see cref="Stream"/></param>
        /// <param name="Context">The context to write to</param>
        public void WriteContent(ITag tag, SerializationContext Context) {
            Int32 Count = tag.Count;

            for (Int32 I = 0; I < Count; I++) {
                NBTWriter.Write(tag[I], Context);
            }

            Context.Stream.WriteByte((Byte)NBTTagType.End);
        }

        /// <summary>Gets the type for which this object can write</summary>
        public NBTTagType[] ForType => _ForType;
    }
}
