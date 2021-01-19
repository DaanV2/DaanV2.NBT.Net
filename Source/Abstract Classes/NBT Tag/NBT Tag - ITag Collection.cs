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
        /// <summary>Gets the amount of sub tag this this <see cref="ITag"/> has</summary>
        [IgnoreDataMember]
        public Int32 Count => this._Tags.Count;

        /// <summary>Gets or sets the subtag of this this <see cref="ITag"/></summary>
        [DataMember]
        public List<ITag> Tags { get => this._Tags; set => this._Tags = value; }

        /// <summary>Gets or sets the subtag with the given name</summary>
        /// <param name="Name">The name of the tag</param>
        /// <returns>Gets or sets the subtag with the given name</returns>
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

        /// <summary>Gets or sets the subtag with the given index</summary>
        /// <param name="Index">The index of </param>
        /// <returns>Gets or sets the subtag with the given index</returns>
        [IgnoreDataMember]
        public ITag this[Int32 Index] {
            get => this._Tags[Index];
            set => this._Tags[Index] = value;
        }

        /// <summary>Adds the specified tag to this this <see cref="ITag"/></summary>
        /// <param name="tag">The tag to add</param>
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

        /// <summary>Adds the given tags to the internal list</summary>
        /// <param name="tags">The tags to add</param>
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

        /// <summary>clears the internal list</summary>
        public virtual void Clear() {
            this._Tags.Clear();
        }

        /// <summary>Removes the tag at the specified index</summary>
        /// <param name="Index">The index of the element</param>
        public virtual void Remove(Int32 Index) {
            this._Tags.RemoveAt(Index);
        }

        /// <summary>Removes the tag with the specified name</summary>
        /// <param name="Name">The name of the tag</param>
        public virtual void Remove(String Name) {
            Int32 Max = this._Tags.Count;

            for (Int32 I = 0; I < Max; I++) {
                if (this._Tags[I].Name == Name) {
                    this._Tags.RemoveAt(I--);
                }
            }
        }

        /// <summary>Retrieves the tag with the given name</summary>
        /// <param name="Name">The name to find</param>
        /// <returns>Retrieves the tag with the given name</returns>
        public ITag GetSubTag(String Name) {
            Int32 Max = this._Tags.Count;

            for (Int32 I = 0; I < Max; I++) {
                if (this._Tags[I].Name == Name) {
                    return this._Tags[I];
                }
            }

            return null;
        }

        /// <summary>Retrieves the tag with the given index</summary>
        /// <param name="Index">The index of the tag to retrieve</param>
        /// <returns>Retrieves the tag with the given index</returns>
        public ITag GetSubTag(Int32 Index) {
            if (Index >= this._Tags.Count || Index < 0) {
                return null;
            }

            return this._Tags[Index];
        }

        /// <summary>Retrieves the tag's value with the given name</summary>
        /// <typeparam name="T">The type to return</typeparam>
        /// <param name="Name">The name to find</param>
        /// <returns>Retrieves the tag's value with the given name</returns>
        public T GetSubValue<T>(String Name) {
            Int32 Max = this._Tags.Count;

            for (Int32 I = 0; I < Max; I++) {
                if (this._Tags[I].Name == Name) {
                    return this._Tags[I].ConvertValue<T>();
                }
            }

            return default;
        }

        /// <summary>Retrieves the tag's value with the given index</summary>
        /// <typeparam name="T">The type to return</typeparam>
        /// <param name="Index">The index to look at</param>
        /// <returns>Retrieves the tag's value with the given index</returns>
        public T GetSubValue<T>(Int32 Index) {
            return this._Tags[Index].GetValue<T>();
        }
    }
}
