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
    ///DOLATER <summary> add description for class: NBTTagByte</summary>
	[Serializable, DataContract]
    public partial class NBTTagByte : NBTTagValue<Byte> {
        /// <summary>Creates a new instance of <see cref="NBTTagByte"/></summary>
        public NBTTagByte() : base() { }

        /// <summary>Creates a new instance of <see cref="NBTTagByte"/></summary>
        /// <param name="Name">The name of the tag</param>
        /// <param name="Value">The value of the tag</param>
        public NBTTagByte(String Name, Byte Value) : base(Name, Value) { }

        /// <summary>Creates a new instance of <see cref="NBTTagByte"/></summary>
        /// <param name="Name">The name of the tag</param>
        /// <param name="Value">The value of the tag</param>
        public NBTTagByte(String Name, Boolean Value) : base(Name, (Byte)(Value ? 1 : 0)) { }


        ///DOLATER <summary>Add Description</summary>
        private static readonly NBTTagType _Type = NBTTagType.Byte;

        ///DOLATER <summary>Add Description</summary>
        [IgnoreDataMember]
        public override NBTTagType Type => _Type;
    }
}
