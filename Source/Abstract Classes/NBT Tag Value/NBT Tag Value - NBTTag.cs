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
    public abstract partial class NBTTagValue<TypeValue> : NBTTag {
        /// <summary>Returns the value of this <see cref="NBTTagValue{TypeValue}"/> as an <see cref="Object"/></summary>
        /// <returns>Returns the value of this <see cref="NBTTagValue{TypeValue}"/> as an <see cref="Object"/></returns>
        public override Object GetValue() {
            return this._Value;
        }

        /// <summary>Returns the value of this <see cref="NBTTagValue{TypeValue}"/> as an object of T, returns null if castings values</summary>
        /// <typeparam name="T">The generic type to return</typeparam>
        /// <returns>Returns the value of this <see cref="NBTTagValue{TypeValue}"/> as an object of T, returns null if castings values</returns>
        public override T GetValue<T>() {
            return this._Value is T val ? val : default;
        }

        /// <summary>Sets the value of this <see cref="NBTTagValue{TypeValue}"/></summary>
        /// <param name="O">The object to store inside</param>
        public override void SetValue(Object O) {
            this._Value = (TypeValue)O;
        }

        /// <summary>Casts the value of this <see cref="NBTTagValue{T}"/> to the specifed type, routes through <see cref="NBTCasting"/></summary>
        /// <typeparam name="T">Add Type description</typeparam>
        /// <returns>Casts the value of this <see cref="NBTTagValue{T}"/> to the specifed type, routes through <see cref="NBTCasting"/></returns>
        public override T ConvertValue<T>() {
            return NBTCasting.ConvertTo<T>(this._Value);
        }
    }
}
