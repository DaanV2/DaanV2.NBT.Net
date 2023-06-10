using System;
using System.Runtime.Serialization;

namespace DaanV2.NBT.Builders; 
/// <summary>The class that helps with building a nbt tag compound</summary>
	[Serializable, DataContract]
public partial class CompoundBuilder {
    /// <summary>Creates a new instance of <see cref="CompoundBuilder"/></summary>
    /// <param name="Name">The name of the tag</param>
    /// <param name="Capacity">The amount of suspected sub tags</param>
    public CompoundBuilder(String Name, Int32 Capacity = 10) {
        this._Tag = new NBTTagCompound(Name, Capacity);
    }

    /// <summary>Creates a new instance of <see cref="CompoundBuilder"/></summary>
    /// <param name="Base">The base to use</param>
    public CompoundBuilder(NBTTagCompound Base) {
        this._Tag = Base;
    }
}
