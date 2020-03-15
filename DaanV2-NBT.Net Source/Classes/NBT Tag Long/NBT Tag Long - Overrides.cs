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

namespace DaanV2.NBT {
    public partial class NBTTagLong {

        /// <summary>Compares this <see cref="Itag"/> to the given object</summary>
        /// <param name="obj">The object to compare to</param>
        /// <returns>Compares this <see cref="Itag"/> to the given object</returns>
        public override Boolean Equals(Object Obj) {
            if (Obj is NBTTagLong Tag) {
                return this.Equals(Tag);
            }

            return base.Equals(Obj);
        }

        /// <summary>Compare this <see cref="Itag"/> to the given object</summary>
        /// <param name="other">The object to compare to</param>
        /// <returns>Compare this <see cref="Itag"/> to the given object</returns>
        public Boolean Equals(NBTTagLong other) {
            return other != null &&
                   base.Equals(other) &&
                   EqualityComparer<Int64>.Default.Equals(this._Value, other._Value) &&
                   EqualityComparer<String>.Default.Equals(this._Name, other._Name);
        }

        /// <summary>Returns the hashcode of this <see cref="Itag"/></summary>
        /// <returns>Returns the hashcode of this <see cref="Itag"/></returns>
        public override Int32 GetHashCode() {
            Int32 hashCode = 1513385649;
            hashCode = (hashCode * -1521134295) + EqualityComparer<Int64>.Default.GetHashCode(this._Value);
            hashCode = (hashCode * -1521134295) + EqualityComparer<String>.Default.GetHashCode(this._Name);
            return hashCode;
        }

        /// <summary>Clones this <see cref="Itag"/> into a new one</summary>
        /// <returns>Clones this <see cref="Itag"/> into a new one</returns>
        public override ITag Clone() {
            return new NBTTagLong() {
                Name = (String)this.Name.Clone(),
                Tags = this.Tags.Clone(),
                Value = this.Value
            };
        }
    }
}
