﻿/*ISC License

Copyright (c) 2019, Daan Verstraten, daanverstraten@hotmail.com

Permission to use, copy, modify, and/or distribute this software for any
purpose with or without fee is hereby granted, provided that the above
copyright notice and this permission notice appear in all copies.

THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF
OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.*/
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
        /// <param name="Capacity">The capacity to set the collection to</param>
        /// <param name="SubType">The type of all the sub <see cref="ITag"/></param>
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
