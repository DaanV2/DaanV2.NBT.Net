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

namespace DaanV2.NBT.Builders {
    public partial class CompoundBuilder {

        /// <summary>Adds the given tag to the internal list</summary>
        /// <param name="tag">The tag to add</param>
        public void Add(ITag tag) {
            this._Tag.Add(tag);
        }

        #region Base Types
        /// <summary>Adds a new sub <see cref="NBTTag"/> to the collection</summary>
        /// <param name="Name">The name of the tag to add to the collection</param>
        /// <param name="Value">The value of the tag to add to the collection</param>
        public void Add(String Name, Byte Value) {
            this._Tag.Add(NBTTagFactory.Create(NBTTagType.Byte, Name, Value));
        }

        /// <summary>Adds a new sub <see cref="NBTTag"/> to the collection</summary>
        /// <param name="Name">The name of the tag to add to the collection</param>
        /// <param name="Value">The value of the tag to add to the collection</param>
        public void Add(String Name, Boolean Value) {
            this._Tag.Add(NBTTagFactory.Create(NBTTagType.Byte, Name, (Byte)(Value ? 1 : 0)));
        }

        /// <summary>Adds a new sub <see cref="NBTTag"/> to the collection</summary>
        /// <param name="Name">The name of the tag to add to the collection</param>
        /// <param name="Value">The value of the tag to add to the collection</param>
        public void Add(String Name, Byte[] Value) {
            this._Tag.Add(NBTTagFactory.Create(NBTTagType.ByteArray, Name, Value));
        }

        /// <summary>Adds a new sub <see cref="NBTTag"/> to the collection</summary>
        /// <param name="Name">The name of the tag to add to the collection</param>
        /// <param name="Value">The value of the tag to add to the collection</param>
        public void Add(String Name, Double Value) {
            this._Tag.Add(NBTTagFactory.Create(NBTTagType.Double, Name, Value));
        }

        /// <summary>Adds a new sub <see cref="NBTTag"/> to the collection</summary>
        /// <param name="Name">The name of the tag to add to the collection</param>
        /// <param name="Value">The value of the tag to add to the collection</param>
        public void Add(String Name, Single Value) {
            this._Tag.Add(NBTTagFactory.Create(NBTTagType.Float, Name, Value));
        }

        /// <summary>Adds a new sub <see cref="NBTTag"/> to the collection</summary>
        /// <param name="Name">The name of the tag to add to the collection</param>
        /// <param name="Value">The value of the tag to add to the collection</param>
        public void Add(String Name, Int32 Value) {
            this._Tag.Add(NBTTagFactory.Create(NBTTagType.Int, Name, Value));
        }

        /// <summary>Adds a new sub <see cref="NBTTag"/> to the collection</summary>
        /// <param name="Name">The name of the tag to add to the collection</param>
        /// <param name="Value">The value of the tag to add to the collection</param>
        public void Add(String Name, Int32[] Value) {
            this._Tag.Add(NBTTagFactory.Create(NBTTagType.IntArray, Name, Value));
        }

        /// <summary>Adds a new sub <see cref="NBTTag"/> to the collection</summary>
        /// <param name="Name">The name of the tag to add to the collection</param>
        /// <param name="Value">The value of the tag to add to the collection</param>
        public void Add(String Name, Int64 Value) {
            this._Tag.Add(NBTTagFactory.Create(NBTTagType.Long, Name, Value));
        }

        /// <summary>Adds a new sub <see cref="NBTTag"/> to the collection</summary>
        /// <param name="Name">The name of the tag to add to the collection</param>
        /// <param name="Value">The value of the tag to add to the collection</param>
        public void Add(String Name, Int64[] Value) {
            this._Tag.Add(NBTTagFactory.Create(NBTTagType.LongArray, Name, Value));
        }

        /// <summary>Adds a new sub <see cref="NBTTag"/> to the collection</summary>
        /// <param name="Name">The name of the tag to add to the collection</param>
        /// <param name="Value">The value of the tag to add to the collection</param>
        public void Add(String Name, Int16 Value) {
            this._Tag.Add(NBTTagFactory.Create(NBTTagType.Short, Name, Value));
        }

        /// <summary>Adds a new sub <see cref="NBTTag"/> to the collection</summary>
        /// <param name="Name">The name of the tag to add to the collection</param>
        /// <param name="Value">The value of the tag to add to the collection</param>
        public void Add(String Name, String Value) {
            this._Tag.Add(NBTTagFactory.Create(NBTTagType.String, Name, Value));
        }
        #endregion

        #region Lists

        /// <summary>Adds a new sub <see cref="NBTTag"/> to the collection</summary>
        /// <param name="Name">The name of the tag to add to the collection</param>
        /// <param name="Value">The value of the tag to add to the collection</param>
        public void Add(String Name, List<Byte> Value) {
            this._Tag.Add(NBTTagFactory.Create(Name, Value));
        }

        /// <summary>Adds a new sub <see cref="NBTTag"/> to the collection</summary>
        /// <param name="Name">The name of the tag to add to the collection</param>
        /// <param name="Value">The value of the tag to add to the collection</param>
        public void Add(String Name, List<Boolean> Value) {
            this._Tag.Add(NBTTagFactory.Create(Name, Value));
        }

        /// <summary>Adds a new sub <see cref="NBTTag"/> to the collection</summary>
        /// <param name="Name">The name of the tag to add to the collection</param>
        /// <param name="Value">The value of the tag to add to the collection</param>
        public void Add(String Name, List<Double> Value) {
            this._Tag.Add(NBTTagFactory.Create(Name, Value));
        }

        /// <summary>Adds a new sub <see cref="NBTTag"/> to the collection</summary>
        /// <param name="Name">The name of the tag to add to the collection</param>
        /// <param name="Value">The value of the tag to add to the collection</param>
        public void Add(String Name, List<Single> Value) {
            this._Tag.Add(NBTTagFactory.Create(Name, Value));
        }

        /// <summary>Adds a new sub <see cref="NBTTag"/> to the collection</summary>
        /// <param name="Name">The name of the tag to add to the collection</param>
        /// <param name="Value">The value of the tag to add to the collection</param>
        public void Add(String Name, List<Int32> Value) {
            this._Tag.Add(NBTTagFactory.Create(Name, Value));
        }

        /// <summary>Adds a new sub <see cref="NBTTag"/> to the collection</summary>
        /// <param name="Name">The name of the tag to add to the collection</param>
        /// <param name="Value">The value of the tag to add to the collection</param>
        public void Add(String Name, List<Int64> Value) {
            this._Tag.Add(NBTTagFactory.Create(Name, Value));
        }

        /// <summary>Adds a new sub <see cref="NBTTag"/> to the collection</summary>
        /// <param name="Name">The name of the tag to add to the collection</param>
        /// <param name="Value">The value of the tag to add to the collection</param>
        public void Add(String Name, List<Int16> Value) {
            this._Tag.Add(NBTTagFactory.Create(Name, Value));
        }

        /// <summary>Adds a new sub <see cref="NBTTag"/> to the collection</summary>
        /// <param name="Name">The name of the tag to add to the collection</param>
        /// <param name="Value">The value of the tag to add to the collection</param>
        public void Add(String Name, List<String> Value) {
            this._Tag.Add(NBTTagFactory.Create(Name, Value));
        }

        #endregion

        /// <summary>Adds a new sub <see cref="NBTTagCompound"/> to the collection</summary>
        /// <param name="Name">The name of the tag to add to the collection</param>
        /// <returns>Adds a new sub <see cref="NBTTagCompound"/> to the collection</returns>
        public CompoundBuilder AddSubCompound(String Name, Int32 Capacity = 10) {
            CompoundBuilder builder = new CompoundBuilder(Name, Capacity);
            this._Tag.Add(builder._Tag);
            return builder;
        }

        /// <summary>Adds a new sub <see cref="NBTTagList"/> to the collection</summary>
        /// <param name="Name">The name of the tag to add to the collection</param>
        /// <param name="SubType">The subtype of the tags inside the list</param>
        /// <param name="Capacity">The capacity to start the list with</param>
        /// <returns>Adds a new sub <see cref="NBTTagList"/> to the collection</returns>
        public ListBuilder AddSubList(String Name, NBTTagType SubType, Int32 Capacity = 10) {
            NBTTagList Tag = new NBTTagList(Name, SubType, Capacity);
            ListBuilder Builder = new ListBuilder(Tag);
            this._Tag.Add(Tag);
            return Builder;
        }
    }
}
