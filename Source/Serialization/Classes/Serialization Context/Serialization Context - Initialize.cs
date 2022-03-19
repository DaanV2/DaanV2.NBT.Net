/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System.IO;
using DaanV2.Binary;

namespace DaanV2.NBT.Serialization {
    /// <summary>The context needed per (de)serialization process, only use one SerializationContext per thread. As the resource are not thread safe</summary>
    /// <remarks>This object cannot be shared among different threads</remarks>
    public sealed partial class SerializationContext {
        /// <summary>Creates a new instance of <see cref="SerializationContext"/></summary>
        public SerializationContext() {
            this.Stream = null;
            this.Endianness = Endianness.LittleEndian;
        }

        /// <summary>Creates a new instance of <see cref="SerializationContext"/></summary>
        /// <param name="endianness">The endianness of the NBt structure</param>
        /// <param name="stream">The stream for reading/writing</param>
        public SerializationContext(Endianness endianness, Stream stream) {
            this.Endianness = endianness;
            this.Stream = stream;
        }
    }
}
