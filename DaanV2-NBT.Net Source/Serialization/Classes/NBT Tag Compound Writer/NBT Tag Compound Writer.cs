﻿using System;
using System.IO;
using DaanV2.Binary;

namespace DaanV2.NBT.Serialization.Serialization {
    ///DOLATER <summary> add description for class: NBTTagCompoundWriter</summary>
    internal partial class NBTTagCompoundWriter : ITagWriter {
        /// <summary>Gets the type for which this object can write</summary>
        private static readonly NBTTagType[] _ForType = new NBTTagType[] { NBTTagType.Compound };

        /// <summary>Writes the nbt's header to the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to write to the <see cref="Stream"/></param>
        /// <param name="Writer">The <see cref="Stream"/> to write to</param>
        public void WriteHeader(ITag tag, Stream Writer, Endianness endianness) {
            Writer.WriteByte((Byte)tag.Type);
            NBTWriter.WriteString(Writer, tag.Name, endianness);
        }

        /// <summary>Writes the nbt's content to the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to write to the <see cref="Stream"/></param>
        /// <param name="Writer">The <see cref="Stream"/> to write to</param>
        public void WriteContent(ITag tag, Stream Writer, Endianness endianness) {
            for (Int32 I = 0; I < tag.Count; I++) {
                NBTWriter.Write(tag[I], Writer, endianness);
            }
            Writer.WriteByte((Byte)NBTTagType.End);
        }

        /// <summary>Gets the type for which this object can write</summary>
        public NBTTagType[] ForType => _ForType;
    }
}
