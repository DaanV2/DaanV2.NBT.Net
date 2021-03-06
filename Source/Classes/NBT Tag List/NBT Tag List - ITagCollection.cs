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
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DaanV2.NBT {
    public sealed partial class NBTTagList : ITagCollection, IEnumerable<ITag>, IEnumerable {
        /// <summary>Gets or sets the subtag with the given name</summary>
        /// <param name="Name">The name of the tag</param>
        /// <returns>Gets or sets the subtag with the given name</returns>
        [IgnoreDataMember]
        public new ITag this[String Name] {
            get {
                Int32 Max = this._Tags.Count;

                for (Int32 I = 0; I < Max; I++) {
                    if (this._Tags[I].Name == Name) {
                        return this._Tags[I];
                    }
                }

                return null;
            }
            set {
                if (value.Type == this.SubType) {
                    throw new ArgumentException($"value type must be same as the lists subtype");
                }

                Int32 Max = this._Tags.Count;

                for (Int32 I = 0; I < Max; I++) {
                    if (this._Tags[I].Name == value.Name) {
                        this._Tags[I] = value;
                        return;
                    }
                }

                this._Tags.Add(value);
            }
        }

        /// <summary>Gets or sets the subtag with the given index</summary>
        /// <param name="Index">The index of </param>
        /// <returns>Gets or sets the subtag with the given index</returns>
        [IgnoreDataMember]
        public new ITag this[Int32 Index] {
            get => this._Tags[Index];
            set {
                if (value.Type != this.SubType) {
                    throw new ArgumentException($"value type must be same as the lists subtype");
                }

                if (this._Tags.Count <= Index) {
                    this.Tags.AddRange(new ITag[Index - this._Tags.Count + 1]);
                }

                this._Tags[Index] = value;
            }
        }

        /// <summary>Add the given tag to the internal list</summary>
        /// <param name="tag">The tag to add</param>
        public override void Add(ITag tag) {
            if (tag.Type != this.SubType) {
                throw new ArgumentException($"value type must be same as the lists subtype");
            }

            this._Tags.Add(tag);
        }

        /// <summary>Returns an enumerator that iteraters through <see cref="NBTTagList"/></summary>
        /// <returns>Returns an enumerator that iteraters through <see cref="NBTTagList"/></returns>
        public IEnumerator GetEnumerator() {
            return this._Tags.GetEnumerator();
        }

        /// <summary>Returns an enumerator that iteraters through <see cref="NBTTagList"/></summary>
        /// <returns>Returns an enumerator that iteraters through <see cref="NBTTagList"/></returns>
        IEnumerator<ITag> IEnumerable<ITag>.GetEnumerator() {
            return this._Tags.GetEnumerator();
        }
    }
}
