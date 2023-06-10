/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.Runtime.Serialization;

namespace DaanV2.NBT {
    /// <summary>The base class that handles generic values of an <see cref="NBTTag"/></summary>
    [Serializable, DataContract]
    public abstract partial class NBTTagValue<TypeValue> {
        /// <summary>Creates a new instance of <see cref="NBTTagValue{T}"/></summary>
        public NBTTagValue() : base(0) {
            this._Value = default;
        }

        /// <summary>Creates a new instance of <see cref="NBTTagValue{T}"/></summary>
        /// <param name="Name">The name of the tag</param>
        /// <param name="Value">The value of the tag</param>
        public NBTTagValue(String Name, TypeValue Value) : base(0) {
            this.Name = Name;
            this._Value = Value;
        }
    }
}
