/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.Runtime.Serialization;

namespace DaanV2.NBT {
    /// <summary>The type of compressions this NBT library uses</summary>
	[Serializable, DataContract]
    public enum NBTCompression {
        /// <summary>Marks that no compression should be used</summary>
        None = 0,
        /// <summary>Marks that the (de)serializers should detect which compression has been used</summary>
        Auto,
        /// <summary>Marks that the (de)serializers should use a GZIP stream</summary>
        Gzip,
        /// <summary>Marks that the (de)serializers should use a Zlib stream</summary>
        Zlib
    }
}
