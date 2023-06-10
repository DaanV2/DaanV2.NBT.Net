/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System.IO;

namespace DaanV2.NBT.Serialization {
    /// <summary>The interface responsible for forming the contract on how Tag writer should behave</summary>
    public interface ITagWriter {
        /// <summary>Writes the nbt's header to the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to write to the <see cref="Stream"/></param>
        /// <param name="Context">The context that provides a buffer, the stream and endianness of the NBT</param>
        void WriteHeader(ITag tag, SerializationContext Context);

        /// <summary>Writes the nbt's content to the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to write to the <see cref="Stream"/></param>
        /// <param name="Context">The context that provides a buffer, the stream and endianness of the NBT</param>
        void WriteContent(ITag tag, SerializationContext Context);

        /// <summary>Gets the type for which this object can write</summary>
        NBTTagType[] ForType { get; }
    }
}
