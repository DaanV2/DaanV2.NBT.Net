/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.Runtime.Serialization;

namespace DaanV2.NBT {
    /// <summary>The class that stores the information for: Long</summary>
	[Serializable, DataContract]
    public sealed partial class NBTTagLong : NBTTagValue<Int64> {
        /// <summary>Creates a new instance of <see cref="NBTTagLong"/></summary>
        public NBTTagLong() : base() { }

        /// <summary>Creates a new instance of <see cref="NBTTagLong"/></summary>
        /// <param name="Name">The name of the tag</param>
        /// <param name="Value">The value of the tag</param>
        public NBTTagLong(String Name, Int64 Value) : base(Name, Value) { }

        /// <summary>Returns the tag type of this this <see cref="ITag"/></summary>
        private const NBTTagType _Type = NBTTagType.Long;

        /// <summary>Returns the tag type of this this <see cref="ITag"/></summary>
        public override NBTTagType Type => _Type;
    }
}
