/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.Runtime.Serialization;

namespace DaanV2.NBT {
    /// <summary>The class that stores the information for: List</summary>
	[Serializable, DataContract]
    public sealed partial class NBTTagList {
        /// <summary>Creates a new instance of <see cref="NBTTagList"/></summary>
        public NBTTagList() : this(NBTTagType.Unknown) { }

        /// <summary>Creates a new instance of <see cref="NBTTagList"/></summary>
        public NBTTagList(NBTTagType SubType) : base(10) {
            this._SubType = SubType;
        }

        /// <summary>Creates a new instance of <see cref="NBTTagList"/></summary>
        /// <param name="Capacity">The capacity to set the collection to</param>
        /// <param name="SubType">The type of all the sub <see cref="ITag"/></param>
        public NBTTagList(NBTTagType SubType, Int32 Capacity = 10) : base(Capacity) {
            this._SubType = SubType;
        }

        /// <summary>Creates a new instance of <see cref="NBTTagList"/></summary>
        /// <param name="SubType">The type of all the sub <see cref="ITag"/></param>
        /// <param name="SubTags">The collection of tags to process <see cref="ITag"/></param>
        public NBTTagList(NBTTagType SubType, ITag[] SubTags) : base(SubTags.Length) {
            this._SubType = SubType;
            this._Tags.AddRange(SubTags);
        }

        /// <summary>Creates a new instance of <see cref="NBTTagList"/></summary>
        /// <param name="Capacity">The capacity to set the collection to</param>
        /// <param name="SubType">The type of all the sub <see cref="ITag"/></param>
        /// <param name="Name">The name of this <see cref="NBTTagList"/></param>
        public NBTTagList(String Name, NBTTagType SubType, Int32 Capacity = 10) : base(Capacity) {
            this._Name = Name;
            this._SubType = SubType;
        }
    }
}
