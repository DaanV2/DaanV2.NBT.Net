/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System.Runtime.Serialization;

namespace DaanV2.NBT; 
public abstract partial class NBTTagValue<TypeValue> {
    /// <summary>Gets or sets the value of this this <see cref="ITag"/></summary>
    [DataMember]
    public TypeValue Value { get => this._Value; set => this._Value = value; }
}
