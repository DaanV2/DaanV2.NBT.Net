using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.NBT.Serialization {
    ///DOLATER <summary> add description for interface: ITagReader</summary>
    public interface ITagReader {
        /// <summary>Reads the nbt's header from the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to read from the <see cref="Stream"/></param>
        /// <param name="Writer">The <see cref="Stream"/> to read from</param>
        void ReadHeader(ITag tag, Stream Reader);

        /// <summary>Reads the nbt's content from the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to read from the <see cref="Stream"/></param>
        /// <param name="Writer">The <see cref="Stream"/> to read from</param>
        void ReadContent(ITag tag, Stream Reader);

        /// <summary>Gets the type for which this object can read</summary>
        NBTTagType[] ForType { get; }
    }
}
