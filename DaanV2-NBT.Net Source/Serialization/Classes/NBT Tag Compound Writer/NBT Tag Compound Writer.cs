using System;
using System.IO;

namespace DaanV2.NBT.Serialization {
    ///DOLATER <summary> add description for class: NBTTagCompoundWriter</summary>
    public partial class NBTTagCompoundWriter : ITagWriter {
        /// <summary>Gets the type for which this object can write</summary>
        private static readonly NBTTagType[] _ForType = new NBTTagType[] { NBTTagType.Compound };

        /// <summary>Writes the nbt's header to the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to write to the <see cref="Stream"/></param>
        /// <param name="Writer">The <see cref="Stream"/> to write to</param>
        public void WriteHeader(ITag tag, Stream Writer) {
            Writer.WriteByte((Byte)tag.Type);
            NBTWriter.WriteString(Writer, tag.Name);
        }

        /// <summary>Writes the nbt's content to the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to write to the <see cref="Stream"/></param>
        /// <param name="Writer">The <see cref="Stream"/> to write to</param>
        public void WriteContent(ITag tag, Stream Writer) {
            for (Int32 I = 0; I < tag.Count; I++) {
                NBTWriter.Write(tag[I], Writer);
            }
            Writer.WriteByte((Byte)NBTTagType.End);
        }

        /// <summary>Gets the type for which this object can write</summary>
        public NBTTagType[] ForType => _ForType;
    }
}
