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
    public abstract partial class NBTTag {
        ///DOLATER <summary>Add Description</summary>
        /// <returns></returns>
        public override String ToString() {
            return $"'{this.Name}': {this.Type}";
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="obj">The object to compare to</param>
        /// <returns></returns>
        public override Boolean Equals(Object obj) {

            if (obj is NBTTag Tag) {
                return this.Equals(Tag);
            }
            else if (obj is ITag Interface) {
                if (this._Name.Equals(Interface.Name) && this._Tags.Count == Interface.Count) {

                    for (Int32 I = 0; I < this._Tags.Count; I++) {
                        if (!this._Tags[I].Equals(Interface[I])) {
                            return false;
                        }
                    }

                    return true;
                }
            }

            return base.Equals(obj);
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Boolean Equals(NBTTag other) {
            return other != null &&
                   base.Equals(other) &&
                   EqualityComparer<List<ITag>>.Default.Equals(this._Tags, other._Tags) &&
                   EqualityComparer<String>.Default.Equals(this._Name, other._Name);
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Boolean Equals(ITag other) {
            if (other != null && base.Equals(other) && EqualityComparer<String>.Default.Equals(this._Name, other.Name)) {

                for (Int32 I = 0; I < this._Tags.Count; I++) {
                    if (!this._Tags[I].Equals(other[I])) {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }

        ///DOLATER <summary>Add Description</summary>
        /// <returns></returns>
        public override Int32 GetHashCode() {
            Int32 hashCode = 1513385649;
            hashCode = (hashCode * -1521134295) + EqualityComparer<List<ITag>>.Default.GetHashCode(this._Tags);
            hashCode = (hashCode * -1521134295) + EqualityComparer<String>.Default.GetHashCode(this._Name);
            return hashCode;
        }
    }
}
