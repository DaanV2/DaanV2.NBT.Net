using System.IO;

namespace DaanV2.NBT.Serialization {
    /// <summary>
    /// 
    /// </summary>
    public partial class NBTTagCompoundReader : ITagReader {
        /// <summary>Gets the type for which this object can read</summary>
        private static readonly NBTTagType[] _ForType = new NBTTagType[] { NBTTagType.Compound };

        /// <summary>Gets the type for which this object can read</summary>
        public NBTTagType[] ForType => _ForType;

        /// <summary>Reads the nbt's content from the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to read from the <see cref="Stream"/></param>
        /// <param name="Writer">The <see cref="Stream"/> to read from</param>
        public void ReadContent(ITag tag, Stream Reader) {
            ITag SubTag = NBTReader.Read(Reader);

            while (SubTag != null) {
                tag.Add(SubTag);
                SubTag = NBTReader.Read(Reader);
            }
        }

        /// <summary>Reads the nbt's header from the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to read from the <see cref="Stream"/></param>
        /// <param name="Writer">The <see cref="Stream"/> to read from</param>
        public void ReadHeader(ITag tag, Stream Reader) {
            tag.Name = NBTReader.ReadString(Reader);
        }
    }
}
