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
    public abstract partial class NBTTag : ITagCollection {
        ///DOLATER <summary>Add Description</summary>
        [IgnoreDataMember]
        public Int32 Count => this._Tags.Count;

        ///DOLATER <summary>Add Description</summary>
        [DataMember]
        public List<ITag> Tags { get => this._Tags; set => this._Tags = value; }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="Name">The name of the tag</param>
        /// <returns></returns>
        [IgnoreDataMember]
        public ITag this[String Name] {
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

        ///DOLATER <summary>Add Description</summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        [IgnoreDataMember]
        public ITag this[Int32 Index] {
            get => this._Tags[Index];
            set => this._Tags[Index] = value;
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name=""></param>
        public virtual void Add(ITag tag) {
            Int32 Max = this._Tags.Count;

            for (Int32 I = 0; I < Max; I++) {
                if (this._Tags[I].Name == tag.Name) {
                    this._Tags[I] = tag;
                    return;
                }
            }

            this._Tags.Add(tag);
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name=""></param>
        public virtual void Add(ITag[] tags) {
            Int32 MaxTag = tags.Length;
            ITag tag;

            for (Int32 J = 0; J < MaxTag; J++) {
                tag = tags[J];

                Int32 Max = this._Tags.Count;
                for (Int32 I = 0; I < Max; I++) {
                    if (this._Tags[I].Name == tag.Name) {
                        this._Tags[I] = tag;
                        continue;
                    }
                }

                this._Tags.Add(tag);
            }
        }

        ///DOLATER <summary>Add Description</summary>
        public virtual void Clear() {
            this._Tags.Clear();
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="Index"></param>
        public virtual void Remove(Int32 Index) {
            this._Tags.RemoveAt(Index);
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="Name">The name of the tag</param>
        public virtual void Remove(String Name) {
            Int32 Max = this._Tags.Count;

            for (Int32 I = 0; I < Max; I++) {
                if (this._Tags[I].Name == Name) {
                    this._Tags.RemoveAt(I--);
                }
            }
        }
    }
}
