using System;
using System.Runtime.Serialization;

namespace DaanV2.NBT; 
/// <summary>The class that stores the information for: Compound</summary>
	[Serializable, DataContract]
public sealed partial class NBTTagCompound {
    /// <summary>Creates a new instance of <see cref="NBTTagCompound"/></summary>
    public NBTTagCompound() : base(10) { }

    /// <summary>Creates a new instance of <see cref="NBTTagCompound"/></summary>
    /// <param name="Capacity">The capacity to set the collection to</param>
    public NBTTagCompound(Int32 Capacity) : base(Capacity) { }

    /// <summary>Creates a new instance of <see cref="NBTTagCompound"/></summary>
    /// <param name="Capacity">The capacity to set the collection to</param>
    /// <param name="Name">The name of this new <see cref="NBTTagCompound"/></param>
    public NBTTagCompound(String Name, Int32 Capacity = 10) : base(Capacity) {
        this._Name = Name;
    }
}
