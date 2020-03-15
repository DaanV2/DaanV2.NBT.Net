using System;
using System.Buffers;
using System.IO;
using DaanV2.Binary;

namespace DaanV2.NBT.Serialization {
    /// <summary>The context needed per (de)serialization process, only use one SerializationContext per thread. As the resource are not thread safe</summary>
    /// <remarks>This object cannot be shared among different threads</remarks>
    public partial class SerializationContext {
        /// <summary>Creates a new instance of <see cref="SerializationContext"/></summary>
        public SerializationContext() {
            this.Buffer = ArrayPool<Byte>.Shared.Rent(8);
            this._Renting = true;
            this.Stream = null;
            this.Endianness = Endianness.LittleEndian;
        }

        /// <summary>Creates a new instance of <see cref="SerializationContext"/></summary>
        /// <param name="endianness">The endianness of the NBt structure</param>
        /// <param name="stream">The stream for reading/writing</param>
        public SerializationContext(Endianness endianness, Stream stream) {
            this.Buffer = ArrayPool<Byte>.Shared.Rent(8);
            this._Renting = true;
            this.Endianness = endianness;
            this.Stream = stream;
        }

        /// <summary>Deconstructs the current <see cref="SerializationContext"/></summary>
        ~SerializationContext() {
            this.Dispose(false);
        }
    }
}
