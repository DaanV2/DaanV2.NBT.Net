using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DaanV2.NBT; 
public sealed partial class NBTTagCompound : NBTTag {
    /// <inheritdoc/>
    private const NBTTagType _Type = NBTTagType.Compound;

    /// <inheritdoc/>
    [IgnoreDataMember]
    public override NBTTagType Type => _Type;

    /// <inheritdoc/>
    public override Object GetValue() {
        return this._Tags;
    }

    /// <inheritdoc/>
    public override T GetValue<T>() {
        return this._Tags is T Out ? Out : default;
    }

    /// <inheritdoc/>
    public override Boolean TryGetValue<T>(out T Value) {
        if (this._Tags is T Out) {
            Value = Out;
            return true;
        }

        Value = default;
        return false;
    }

    /// <inheritdoc/>
    public override void SetValue(Object O) {
        if (O is List<ITag> Temp) {
            this._Tags = Temp;
        }
    }

    /// <inheritdoc/>
    public override T ConvertValue<T>() {
        throw new NotImplementedException("Cannot cast value of NBTTagCompound");
    }
}
