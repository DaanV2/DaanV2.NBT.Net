using System;
using System.Runtime.Serialization;

namespace DaanV2.NBT.Builders; 
/// <summary> add description for class: ListBuilder</summary>
	[Serializable, DataContract]
public partial class ListBuilder {
    /// <summary>Creates a new instance of <see cref="ListBuilder"/></summary>
    /// <param name="Name">The name of the tag</param>
    /// <param name="SubType">FILL IN</param>
    /// <param name="Capacity">FILL IN</param>
    public ListBuilder(String Name, NBTTagType SubType, Int32 Capacity = 10) {
        this._Tag = new NBTTagList(Name, SubType, Capacity);
    }

    /// <summary>Creates a new instance of <see cref="ListBuilder"/></summary>
    /// <param name="Base">FILL IN</param>
    public ListBuilder(NBTTagList Base) {
        this._Tag = Base;
    }
}
