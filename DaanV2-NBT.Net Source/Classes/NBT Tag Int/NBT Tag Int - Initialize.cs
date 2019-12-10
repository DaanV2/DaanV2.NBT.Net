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
    ///DOLATER <summary> add description for class: NBTTagInt</summary>
	[Serializable, DataContract]
    public partial class NBTTagInt : NBTTagValue<Int32> {
        /// <summary>Creates a new instance of <see cref="NBTTagInt"/></summary>
        public NBTTagInt() : base() { }

        /// <summary>Creates a new instance of <see cref="NBTTagInt"/></summary>
        /// <param name="Name">The name of the tag</param>
        /// <param name="Value">The value of the tag</param>
        public NBTTagInt(String Name, Int32 Value) : base(Name, Value) { }

        ///DOLATER <summary>Add Description</summary>
        private static readonly NBTTagType _Type = NBTTagType.Int;

        ///DOLATER <summary>Add Description</summary>
        public override NBTTagType Type => _Type;
    }
}
