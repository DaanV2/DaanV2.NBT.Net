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

namespace DaanV2.NBT.Builders {
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
}
