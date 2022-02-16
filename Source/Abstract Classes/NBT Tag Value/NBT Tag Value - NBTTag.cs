/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;

namespace DaanV2.NBT {
    public abstract partial class NBTTagValue<TypeValue> : NBTTag {
        /// <inheritdoc/>
        public override Object GetValue() {
            return this._Value;
        }

        /// <inheritdoc/>
        public override T GetValue<T>() {
            return this._Value is T val ? val : default;
        }

        /// <inheritdoc/>
        public override void SetValue(Object O) {
            this._Value = (TypeValue)O;
        }

        /// <inheritdoc/>
        public override T ConvertValue<T>() {
            return NBTCasting.ConvertTo<T>(this._Value);
        }
    }
}
