using System;
using System.Runtime.Serialization;

namespace DaanV2.NBT; 
/// <summary>The class that stores the information for: ByteArray</summary>
	[Serializable, DataContract]
public sealed partial class NBTTagByteArray : NBTTagValue<Byte[]> {
    /// <summary>Creates a new instance of <see cref="NBTTagByteArray"/></summary>
    public NBTTagByteArray() : base() { }

    /// <summary>Creates a new instance of <see cref="NBTTagByteArray"/></summary>
    /// <param name="Name">The name of the tag</param>
    /// <param name="Value">The value of the tag</param>
    public NBTTagByteArray(String Name, Byte[] Value) : base(Name, Value) { }

    /// <summary>Returns the tag type of this this <see cref="ITag"/></summary>
    private const NBTTagType _Type = NBTTagType.ByteArray;

    /// <summary>Returns the tag's type</summary>
    [IgnoreDataMember]
    public override NBTTagType Type => _Type;
}
