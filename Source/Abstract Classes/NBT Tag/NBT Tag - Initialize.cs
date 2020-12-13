/*ISC License

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
