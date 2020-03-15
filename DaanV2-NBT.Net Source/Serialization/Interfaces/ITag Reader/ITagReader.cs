using System.IO;
using DaanV2.Binary;

namespace DaanV2.NBT.Serialization {
    /// <summary>The interface responsible for determing on how to </summary>
    public interface ITagReader {
        /// <summary>Reads the nbt's header from the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to read from the <see cref="Stream"/></param>
        /// <param name="Context">The context that provides a buffer, the stream and endianness of the NBT</param>
        void ReadHeader(ITag tag, SerializationContext Context);

        /// <summary>Reads the nbt's content from the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to read from the <see cref="Stream"/></param>
        /// <param name="Context">The context that provides a buffer, the stream and endianness of the NBT</param>
        void ReadContent(ITag tag, SerializationContext Context);

        /// <summary>Gets the type for which this object can read</summary>
        NBTTagType[] ForType { get; }
    }
}
