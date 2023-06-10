/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;

namespace DaanV2.NBT {
    public sealed partial class NBTTagIntArray {
        /// <summary>Gets the value of this this <see cref="ITag"/></summary>
        /// <returns>Gets the value of this this <see cref="ITag"/></returns>
        public sealed override Object GetValue() {
            return this.Value;
        }

        /// <summary>Converts the value of this this <see cref="ITag"/> to the specified type</summary>
        /// <typeparam name="T">The type to convert to</typeparam>
        /// <returns>Converts the value of this this <see cref="ITag"/> to the specified type</returns>
        public sealed override T GetValue<T>() {
            return this._Value is T val ? val : default;
        }

        /// <summary>Casts the value of this <see cref="NBTTagValue{T}"/> to the specifed type, routes through <see cref="NBTCasting"/></summary>
        /// <typeparam name="T">Add Type description</typeparam>
        /// <returns>Casts the value of this <see cref="NBTTagValue{T}"/> to the specifed type, routes through <see cref="NBTCasting"/></returns>
        public sealed override T ConvertValue<T>() {
            return NBTCasting.ConvertTo<T>(this._Value);
        }
    }
}
