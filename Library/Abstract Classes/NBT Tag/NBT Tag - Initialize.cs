/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DaanV2.NBT {
    /// <summary>An abstract classes that forms the basis of any NBT Tag</summary>
    [Serializable, DataContract]
    public abstract partial class NBTTag {
        /// <summary>Creates a new instance of <see cref="NBTTag"/></summary>
        public NBTTag() {
            this._Tags = new List<ITag>(10);
            this._Name = String.Empty;
        }

        /// <summary>Creates a new instance of <see cref="NBTTag"/></summary>
        /// <param name="Capacity">The suspected amount of capacity to add</param>
        public NBTTag(Int32 Capacity) {
            this._Tags = new List<ITag>(Capacity);
            this._Name = String.Empty;
        }
    }
}
