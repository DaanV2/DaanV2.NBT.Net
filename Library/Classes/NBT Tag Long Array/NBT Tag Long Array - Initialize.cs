/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.Runtime.Serialization;

namespace DaanV2.NBT {
    /// <summary>The class that stores the information for: LongArray</summary>
	[Serializable, DataContract]
    public sealed partial class NBTTagLongArray : NBTTagValue<Int64[]> {
        /// <summary>Creates a new instance of <see cref="NBTTagLongArray"/></summary>
        public NBTTagLongArray() : base() { }

        /// <summary>Creates a new instance of <see cref="NBTTagLongArray"/></summary>
        /// <param name="Name">The name of the tag</param>
        /// <param name="Value">The value of the tag</param>
        public NBTTagLongArray(String Name, Int64[] Value) : base(Name, Value) { }

        /// <summary>Returns the tag type of this this <see cref="ITag"/></summary>
        private const NBTTagType _Type = NBTTagType.LongArray;

        /// <summary>Returns the tag type of this this <see cref="ITag"/></summary>
        public override NBTTagType Type => _Type;
    }
}
