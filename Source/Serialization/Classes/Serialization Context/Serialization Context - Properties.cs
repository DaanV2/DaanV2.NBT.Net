/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.IO;
using DaanV2.Binary;

namespace DaanV2.NBT.Serialization {
    public partial class SerializationContext {
        /// <summary>Gets or sets the Endianness for this instance</summary>
        public Endianness Endianness { get; private set; }

        /// <summary>Gets or sets the Buffer for this instance</summary>
        public Byte[] Buffer { get; private set; }

        /// <summary>Gets or sets the Stream for this instance</summary>
        public Stream Stream { get; private set; }
    }
}
