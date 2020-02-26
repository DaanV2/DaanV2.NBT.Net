using System.IO;
using DaanV2.Binary;

namespace DaanV2.NBT.Serialization.Serialization {
    /// <summary>
    /// 
    /// </summary>
    internal partial class NBTTagCompoundReader : ITagReader {
        /// <summary>Gets the type for which this object can read</summary>
        private static readonly NBTTagType[] _ForType = new NBTTagType[] { NBTTagType.Compound };

        /// <summary>Gets the type for which this object can read</summary>
        internal NBTTagType[] ForType => _ForType;

        /// <summary>Reads the nbt's content from the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to read from the <see cref="Stream"/></param>
        /// <param name="Reader">The <see cref="Stream"/> to read from</param>
        internal void ReadContent(ITag tag, Stream Reader, Endianness endianness) {
            ITag SubTag = NBTReader.Read(Reader, endianness);

            while (SubTag != null) {
                tag.Add(SubTag);
                SubTag = NBTReader.Read(Reader, endianness);
            }
        }

        /// <summary>Reads the nbt's header from the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to read from the <see cref="Stream"/></param>
        /// <param name="Reader">The <see cref="Stream"/> to read from</param>
        internal void ReadHeader(ITag tag, Stream Reader, Endianness endianness) {
            tag.Name = NBTReader.ReadString(Reader, endianness);
        }
    }
}
