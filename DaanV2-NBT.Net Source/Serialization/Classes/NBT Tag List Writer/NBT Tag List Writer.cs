using System;
using System.IO;
using DaanV2.Binary;

namespace DaanV2.NBT.Serialization.Serialization {
    ///DOLATER <summary> add description for class: NBTTagListWriter</summary>
    internal partial class NBTTagListWriter : ITagWriter {
        /// <summary>Gets the type for which this object can write</summary>
        private static readonly NBTTagType[] _ForType = new NBTTagType[] { NBTTagType.List };

        /// <summary>Writes the nbt's header to the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to write to the <see cref="Stream"/></param>
        /// <param name="Writer">The <see cref="Stream"/> to write to</param>
        public void WriteHeader(ITag tag, Stream Writer, Endianness endianness) {
            Writer.WriteByte((Byte)tag.Type);
            NBTWriter.WriteString(Writer, tag.Name, endianness);
            Writer.WriteByte((Byte)tag.GetInformation(NBTTagInformation.ListSubtype));
            Writer.WriteInt32((Int32)tag.GetInformation(NBTTagInformation.ListSize), endianness);
        }

        /// <summary>Writes the nbt's content to the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to write to the <see cref="Stream"/></param>
        /// <param name="Writer">The <see cref="Stream"/> to write to</param>
        public void WriteContent(ITag tag, Stream Writer, Endianness endianness) {
            for (Int32 I = 0; I < tag.Count; I++) {
                NBTWriter.WriteContent(tag[I], Writer, endianness);
            }
        }

        /// <summary>Gets the type for which this object can write</summary>
        public NBTTagType[] ForType => _ForType;
    }
}
