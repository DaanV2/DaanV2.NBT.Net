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
    public partial class NBTTagCompound : NBTTag {
        /// <summary>
        /// 
        /// </summary>
        private const NBTTagType _Type = NBTTagType.Compound;

        ///DOLATER <summary>Add Description</summary>
        [IgnoreDataMember]
        public override NBTTagType Type => _Type;

        ///DOLATER <summary>Add Description</summary>
        /// <returns></returns>
        public override Object GetValue() {
            return this._Tags;
        }

        ///DOLATER <summary>Add Description</summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public override T GetValue<T>() {
            return this._Tags is T Out ? Out : (default);
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="O"></param>
        public override void SetValue(Object O) {
            if (O is List<ITag> Temp) {
                this._Tags = Temp;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public override T ConvertValue<T>() {
            throw new NotImplementedException("Cannot cast value of NBTTagCompound");
        }
    }
}
