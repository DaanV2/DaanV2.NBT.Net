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
    public partial class NBTTagList : NBTTag {
        /// <summary>Returns the tag type of this this <see cref="ITag"/></summary>
        private const NBTTagType _Type = NBTTagType.List;

        /// <summary>Returns the tag type of this this <see cref="ITag"/></summary>
        public override NBTTagType Type => _Type;

        /// <summary>Returns the value of this this <see cref="ITag"/></summary>
        /// <returns>Returns the value of this this <see cref="ITag"/></returns>
        public override Object GetValue() {
            return this.Tags;
        }

        /// <summary>Converts the value of this this <see cref="ITag"/> to the specified type</summary>
        /// <typeparam name="T">The type to convert to</typeparam>
        /// <returns>Converts the value of this this <see cref="ITag"/> to the specified type</returns>
        public override T GetValue<T>() {
            return this.Tags is T val ? val : default;
        }

        /// <summary>Sets the value of this this <see cref="ITag"/></summary>
        /// <param name="O">The value to set</param>
        public override void SetValue(Object O) {
            if (O is List<ITag> T) {
                this.Tags = T;
            }
            else {
                throw new ArgumentException($"{nameof(O)} must be of type {nameof(List<ITag>)}");
            }
        }

        /// <summary>Converts the value of this this <see cref="ITag"/> to the specified type</summary>
        /// <typeparam name="T">The type to convert to</typeparam>
        /// <returns>Converts the value of this this <see cref="ITag"/> to the specified type</returns>
        public override T ConvertValue<T>() {
            return NBTCasting.ConvertTo<T>(this._Tags);
        }
    }
}
