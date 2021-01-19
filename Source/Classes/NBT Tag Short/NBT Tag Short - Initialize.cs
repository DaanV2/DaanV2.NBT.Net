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
using System.Runtime.Serialization;

namespace DaanV2.NBT {
    /// <summary>The class that stores the information for: Short</summary>
	[Serializable, DataContract]
    public sealed partial class NBTTagShort : NBTTagValue<Int16> {
        /// <summary>Creates a new instance of <see cref="NBTTagShort"/></summary>
        public NBTTagShort() : base() { }

        /// <summary>Creates a new instance of <see cref="NBTTagShort"/></summary>
        /// <param name="Name">The name of the tag</param>
        /// <param name="Value">The value of the tag</param>
        public NBTTagShort(String Name, Int16 Value) : base(Name, Value) { }

        /// <summary>Returns the tag type of this this <see cref="ITag"/></summary>
        private const NBTTagType _Type = NBTTagType.Short;

        /// <summary>Returns the tag type of this this <see cref="ITag"/></summary>
        public override NBTTagType Type => _Type;
    }
}
