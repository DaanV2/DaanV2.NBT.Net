/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.Runtime.Serialization;

namespace DaanV2.NBT; 
/// <summary>The class that stores the information for: IntArray</summary>
	[Serializable, DataContract]
public sealed partial class NBTTagIntArray : NBTTagValue<Int32[]> {
    /// <summary>Creates a new instance of <see cref="NBTTagIntArray"/></summary>
    public NBTTagIntArray() : base() { }

    /// <summary>Creates a new instance of <see cref="NBTTagIntArray"/></summary>
    /// <param name="Name">The name of the tag</param>
    /// <param name="Value">The value of the tag</param>
    public NBTTagIntArray(String Name, Int32[] Value) : base(Name, Value) { }

    /// <summary>Returns the tag type of this this <see cref="ITag"/></summary>
    private const NBTTagType _Type = NBTTagType.IntArray;

    /// <summary>Returns the tag type of this this <see cref="ITag"/></summary>
    public override NBTTagType Type => _Type;
}
