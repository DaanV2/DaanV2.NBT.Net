using System;
using System.IO;


namespace DaanV2.NBT.Serialization; 
public partial class SerializationContext {
    /// <summary>Gets or sets the Endian for this instance</summary>
    public Endian Endian { get; private set; }

    /// <summary>Gets or sets the Stream for this instance</summary>
    public Stream Stream { get; private set; }
}
