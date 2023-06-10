using System;
using System.Runtime.Serialization;

namespace DaanV2.NBT; 
/// <summary> add description for class: NBTTagByte</summary>
	[Serializable, DataContract]
public sealed partial class NBTTagByte : NBTTagValue<Byte> {
    /// <summary>Creates a new instance of <see cref="NBTTagByte"/></summary>
    public NBTTagByte() : base() { }

    /// <summary>Creates a new instance of <see cref="NBTTagByte"/></summary>
    /// <param name="Name">The name of the tag</param>
    /// <param name="Value">The value of the tag</param>
    public NBTTagByte(String Name, Byte Value) : base(Name, Value) { }

    /// <summary>Creates a new instance of <see cref="NBTTagByte"/></summary>
    /// <param name="Name">The name of the tag</param>
    /// <param name="Value">The value of the tag</param>
    public NBTTagByte(String Name, Boolean Value) : base(Name, (Byte)(Value ? 1 : 0)) { }

    /// <summary>Returns the tag type of this this <see cref="ITag"/></summary>
    private const NBTTagType _Type = NBTTagType.Byte;

    /// <summary>Returns the tag's type</summary>
    [IgnoreDataMember]
    public override NBTTagType Type => _Type;
}
