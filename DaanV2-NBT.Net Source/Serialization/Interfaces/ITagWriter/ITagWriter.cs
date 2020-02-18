using System.IO;
using DaanV2.Binary;

namespace DaanV2.NBT.Serialization {
    ///DOLATER <summary> add description for interface: ITagWriter</summary>
    public interface ITagWriter {
        /// <summary>Writes the nbt's header to the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to write to the <see cref="Stream"/></param>
        /// <param name="Writer">The <see cref="Stream"/> to write to</param>
        void WriteHeader(ITag tag, Stream Writer, Endianness endianness);

        /// <summary>Writes the nbt's content to the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to write to the <see cref="Stream"/></param>
        /// <param name="Writer">The <see cref="Stream"/> to write to</param>
        void WriteContent(ITag tag, Stream Writer, Endianness endianness);

        /// <summary>Gets the type for which this object can write</summary>
        NBTTagType[] ForType { get; }
    }
}
