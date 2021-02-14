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

namespace DaanV2.NBT {
    public sealed partial class NBTTagLongArray {
        /// <summary>Gets the value of this this <see cref="ITag"/></summary>
        /// <returns>Gets the value of this this <see cref="ITag"/></returns>
        public sealed override Object GetValue() {
            return this.Value;
        }

        /// <summary>Converts the value of this this <see cref="ITag"/> to the specified type</summary>
        /// <typeparam name="T">The type to convert to</typeparam>
        /// <returns>Converts the value of this this <see cref="ITag"/> to the specified type</returns>
        public sealed override T GetValue<T>() {
            return this._Value is T val ? val : (default);
        }

        /// <summary>Casts the value of this <see cref="NBTTagValue{T}"/> to the specifed type, routes through <see cref="NBTCasting"/></summary>
        /// <typeparam name="T">Add Type description</typeparam>
        /// <returns>Casts the value of this <see cref="NBTTagValue{T}"/> to the specifed type, routes through <see cref="NBTCasting"/></returns>
        public sealed override T ConvertValue<T>() {
            return NBTCasting.ConvertTo<T>(this._Value);
        }
    }
}
