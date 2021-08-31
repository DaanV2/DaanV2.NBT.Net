/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DaanV2.NBT {
    public sealed partial class NBTTagCompound : NBTTag {
        /// <summary>The constant type used for this this <see cref="ITag"/></summary>
        private const NBTTagType _Type = NBTTagType.Compound;

        /// <summary>Returns the tag's type</summary>
        [IgnoreDataMember]
        public override NBTTagType Type => _Type;

        /// <summary>Returns the value of this Nbttag</summary>
        /// <returns>Returns the value of this Nbttag</returns>
        public override Object GetValue() {
            return this._Tags;
        }

        /// <summary>Safetly returns the value of this object, if object is not suspected type then the default value for that type is returned</summary>
        /// <typeparam name="T">The type to return</typeparam>
        /// <returns>Safetly returns the value of this object, if object is not suspected type then the default value for that type is returned</returns>
        public override T GetValue<T>() {
            return this._Tags is T Out ? Out : (default);
        }

        /// <summary>Sets the value of this <see cref="NBTTag" /></summary>
        /// <param name="O">The object to store</param>
        public override void SetValue(Object O) {
            if (O is List<ITag> Temp) {
                this._Tags = Temp;
            }
        }

        /// <summary>Converts the value of this this <see cref="ITag"/> to the specified type</summary>
        /// <typeparam name="T">The type to convert to</typeparam>
        /// <returns>Converts the value of this this <see cref="ITag"/> to the specified type</returns>
        public override T ConvertValue<T>() {
            throw new NotImplementedException("Cannot cast value of NBTTagCompound");
        }
    }
}
