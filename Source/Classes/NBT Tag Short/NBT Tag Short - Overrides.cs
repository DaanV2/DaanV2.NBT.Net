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
    public partial class NBTTagShort {
        /// <summary>Compare this this <see cref="ITag"/> to the given object</summary>
        /// <param name="Obj">The object to compare to</param>
        /// <returns>Compare this this <see cref="ITag"/> to the given object</returns>
        public override Boolean Equals(Object Obj) {
            if (Obj is NBTTagShort Tag) {
                return this.Equals(Tag);
            }

            return base.Equals(Obj);
        }

        /// <summary>Compare this this <see cref="ITag"/> to the given object</summary>
        /// <param name="other">The object to compare to</param>
        /// <returns>Compare this this <see cref="ITag"/> to the given object</returns>
        public Boolean Equals(NBTTagShort other) {
            return other != null &&
                   EqualityComparer<Int16>.Default.Equals(this._Value, other._Value) &&
                   EqualityComparer<String>.Default.Equals(this._Name, other._Name);
        }

        /// <summary>Returns the hashcode of this this <see cref="ITag"/></summary>
        /// <returns>Returns the hashcode of this this <see cref="ITag"/></returns>
        public override Int32 GetHashCode() {
            Int32 hashCode = 1513385649;
            hashCode = (hashCode * -1521134295) + EqualityComparer<Int16>.Default.GetHashCode(this._Value);
            hashCode = (hashCode * -1521134295) + EqualityComparer<String>.Default.GetHashCode(this._Name);
            return hashCode;
        }

        /// <summary>Clones this this <see cref="ITag"/> into a new one</summary>
        /// <returns>Clones this this <see cref="ITag"/> into a new one</returns>
        public override ITag Clone() {
            return new NBTTagShort() {
                Name = (String)this.Name.Clone(),
                Tags = this.Tags.Clone(),
                Value = this.Value
            };
        }

        /// <summary>Returns a string representation of this this <see cref="ITag"/></summary>
        /// <returns>Returns a string representation of this this <see cref="ITag"/></returns>
        public override String ToString() {
            if (String.IsNullOrEmpty(this.Name)) {
                return $"{this._Value}";
            }
            else {
                return $"\"{this.Name}\": {this._Value}";
            }
        }
    }
}
