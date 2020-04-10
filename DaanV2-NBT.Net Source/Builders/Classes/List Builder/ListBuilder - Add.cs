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

namespace DaanV2.NBT.Builders {
    public partial class ListBuilder {
        /// <summary>Add an item to the list</summary>
        /// <param name="Value">The value of the tag to add to the collection</param>
        public void Add(Byte Value) {
            this._Tag.Add(NBTTagFactory.Create(NBTTagType.Byte, String.Empty, Value));
        }

        /// <summary>Add an item to the list</summary>
        /// <param name="Value">The value of the tag to add to the collection</param>
        public void Add(Boolean Value) {
            this._Tag.Add(NBTTagFactory.Create(NBTTagType.Byte, String.Empty, (Byte)(Value ? 1 : 0)));
        }

        /// <summary>Add an item to the list</summary>
        /// <param name="Value">The value of the tag to add to the collection</param>
        public void Add(Byte[] Value) {
            this._Tag.Add(NBTTagFactory.Create(NBTTagType.ByteArray, String.Empty, Value));
        }

        /// <summary>Add an item to the list</summary>
        /// <param name="Value">The value of the tag to add to the collection</param>
        public void Add(Double Value) {
            this._Tag.Add(NBTTagFactory.Create(NBTTagType.Double, String.Empty, Value));
        }

        /// <summary>Add an item to the list</summary>
        /// <param name="Value">The value of the tag to add to the collection</param>
        public void Add(Single Value) {
            this._Tag.Add(NBTTagFactory.Create(NBTTagType.Float, String.Empty, Value));
        }

        /// <summary>Add an item to the list</summary>
        /// <param name="Value">The value of the tag to add to the collection</param>
        public void Add(Int32 Value) {
            this._Tag.Add(NBTTagFactory.Create(NBTTagType.Int, String.Empty, Value));
        }

        /// <summary>Add an item to the list</summary>
        /// <param name="Value">The value of the tag to add to the collection</param>
        public void Add(Int32[] Value) {
            this._Tag.Add(NBTTagFactory.Create(NBTTagType.IntArray, String.Empty, Value));
        }

        /// <summary>Add an item to the list</summary>
        /// <param name="Value">The value of the tag to add to the collection</param>
        public void Add(Int64 Value) {
            this._Tag.Add(NBTTagFactory.Create(NBTTagType.Long, String.Empty, Value));
        }

        /// <summary>Add an item to the list</summary>
        /// <param name="Value">The value of the tag to add to the collection</param>
        public void Add(Int64[] Value) {
            this._Tag.Add(NBTTagFactory.Create(NBTTagType.LongArray, String.Empty, Value));
        }

        /// <summary>Add an item to the list</summary>
        /// <param name="Value">The value of the tag to add to the collection</param>
        public void Add(Int16 Value) {
            this._Tag.Add(NBTTagFactory.Create(NBTTagType.Short, String.Empty, Value));
        }

        /// <summary>Add an item to the list</summary>
        /// <param name="Value">The value of the tag to add to the collection</param>
        public void Add(String Value) {
            this._Tag.Add(NBTTagFactory.Create(NBTTagType.String, String.Empty, Value));
        }

        /// <summary>Add a tag to the list</summary>
        /// <param name="Tag">The tag to add</param>
        public void Add(ITag Tag) {
            this._Tag.Add(Tag);
        }
    }
}
