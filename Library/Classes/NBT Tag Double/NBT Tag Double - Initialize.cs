using System;
using System.Runtime.Serialization;

namespace DaanV2.NBT; 
/// <summary>The class that stores the information for: Double</summary>
	[Serializable, DataContract]
public sealed partial class NBTTagDouble : NBTTagValue<Double> {
    /// <summary>Creates a new instance of <see cref="NBTTagDouble"/></summary>
    public NBTTagDouble() : base() { }

    /// <summary>Creates a new instance of <see cref="NBTTagDouble"/></summary>
    /// <param name="Name">The name of the tag</param>
    /// <param name="Value">The value of the tag</param>
    public NBTTagDouble(String Name, Double Value) : base(Name, Value) { }

    /// <summary>Returns the tag type of this this <see cref="ITag"/></summary>
    private const NBTTagType _Type = NBTTagType.Double;

    /// <summary>Returns the tag type of this this <see cref="ITag"/></summary>
    public override NBTTagType Type => _Type;
}
