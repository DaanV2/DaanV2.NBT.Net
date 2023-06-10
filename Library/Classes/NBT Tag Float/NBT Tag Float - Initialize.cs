/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.Runtime.Serialization;

namespace DaanV2.NBT; 
/// <summary>The class that stores the information for: Float</summary>
	[Serializable, DataContract]
public sealed partial class NBTTagFloat : NBTTagValue<Single> {
    /// <summary>Creates a new instance of <see cref="NBTTagFloat"/></summary>
    public NBTTagFloat() : base() { }

    /// <summary>Creates a new instance of <see cref="NBTTagFloat"/></summary>
    /// <param name="Name">The name of the tag</param>
    /// <param name="Value">The value of the tag</param>
    public NBTTagFloat(String Name, Single Value) : base(Name, Value) { }

    /// <summary>Returns the tag type of this this <see cref="ITag"/></summary>
    private const NBTTagType _Type = NBTTagType.Float;

    /// <summary>Returns the tag type of this this <see cref="ITag"/></summary>
    public override NBTTagType Type => _Type;
}
