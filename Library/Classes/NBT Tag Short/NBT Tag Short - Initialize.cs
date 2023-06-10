/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.Runtime.Serialization;

namespace DaanV2.NBT; 
/// <summary>The class that stores the information for: Short</summary>
	[Serializable, DataContract]
public sealed partial class NBTTagShort : NBTTagValue<Int16> {
    /// <summary>Creates a new instance of <see cref="NBTTagShort"/></summary>
    public NBTTagShort() : base() { }

    /// <summary>Creates a new instance of <see cref="NBTTagShort"/></summary>
    /// <param name="Name">The name of the tag</param>
    /// <param name="Value">The value of the tag</param>
    public NBTTagShort(String Name, Int16 Value) : base(Name, Value) { }

    /// <summary>Returns the tag type of this this <see cref="ITag"/></summary>
    private const NBTTagType _Type = NBTTagType.Short;

    /// <summary>Returns the tag type of this this <see cref="ITag"/></summary>
    public override NBTTagType Type => _Type;
}
