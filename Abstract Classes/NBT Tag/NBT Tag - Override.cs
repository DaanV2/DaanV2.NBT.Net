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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.NBT {
    public abstract partial class NBTTag {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override String ToString() {
            return $"'{this.Name}': {this.Type}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override Boolean Equals(Object obj) {

            if (obj is NBTTag Tag) {
                if (this._Name.Equals(Tag._Name) && this._Tags.Count == Tag.Count) {
                    for (Int32 I = 0; I < this._Tags.Count; I++) {
                        if (!this._Tags[I].Equals(Tag[I])) {
                            return false;
                        }
                    }

                    return true;
                }
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
    }
}
