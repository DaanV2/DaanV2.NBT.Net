using System;
using System.Runtime.Serialization;

namespace DaanV2.NBT; 
/// <summary>The class that stores the information for: Int</summary>
	[Serializable, DataContract]
public sealed partial class NBTTagInt : NBTTagValue<Int32> {
    /// <summary>Creates a new instance of <see cref="NBTTagInt"/></summary>
    public NBTTagInt() : base() { }

    /// <summary>Creates a new instance of <see cref="NBTTagInt"/></summary>
    /// <param name="Name">The name of the tag</param>
    /// <param name="Value">The value of the tag</param>
    public NBTTagInt(String Name, Int32 Value) : base(Name, Value) { }

    /// <summary>Returns the tag type of this this <see cref="ITag"/></summary>
    private const NBTTagType _Type = NBTTagType.Int;

    /// <summary>Returns the tag type of this this <see cref="ITag"/></summary>
    public override NBTTagType Type => _Type;
}
