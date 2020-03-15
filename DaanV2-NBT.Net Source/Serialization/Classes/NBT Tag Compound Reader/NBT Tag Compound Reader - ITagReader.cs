using System.IO;
using DaanV2.Binary;

namespace DaanV2.NBT.Serialization.Serialization {
    /// <summary>The nbt tag compound reader</summary>
    internal partial class NBTTagCompoundReader : ITagReader {
        /// <summary>Gets the type for which this object can read</summary>
        private static readonly NBTTagType[] _ForType = new NBTTagType[] { NBTTagType.Compound };

        /// <summary>Gets the type for which this object can read</summary>
        public NBTTagType[] ForType => _ForType;

        /// <summary>Reads the nbt's content from the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to read from the <see cref="Stream"/></param>
        /// <param name="Context">The context that provides a buffer, the stream and endianness of the NBT</param>
        public void ReadContent(ITag tag, SerializationContext Context) {
            ITag SubTag = NBTReader.Read(Context);

            while (SubTag != null) {
                tag.Add(SubTag);
                SubTag = NBTReader.Read(Context);
            }
        }

        /// <summary>Reads the nbt's header from the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to read from the <see cref="Stream"/></param>
        /// <param name="Context">The context that provides a buffer, the stream and endianness of the NBT</param>
        public void ReadHeader(ITag tag, SerializationContext Context) {
            tag.Name = NBTReader.ReadString(Context.Stream, Context.Endianness);
        }
    }
}
