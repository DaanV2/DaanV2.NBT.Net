using System;
using System.Runtime.Serialization;

namespace DaanV2.NBT; 
/// <summary>The class that stores the information for: String</summary>
	[Serializable, DataContract]
public sealed partial class NBTTagString : NBTTagValue<String> {
    /// <summary>Creates a new instance of <see cref="NBTTagString"/></summary>
    public NBTTagString() : base() { }

    /// <summary>Creates a new instance of <see cref="NBTTagString"/></summary>
    /// <param name="Name">The name of the tag</param>
    /// <param name="Value">The value of the tag</param>
    public NBTTagString(String Name, String Value) : base(Name, Value) { }

    /// <summary>Returns the tag type of this this <see cref="ITag"/></summary>
    private const NBTTagType _Type = NBTTagType.String;

    /// <summary>Returns the tag type of this this <see cref="ITag"/></summary>
    public override NBTTagType Type => _Type;
}
