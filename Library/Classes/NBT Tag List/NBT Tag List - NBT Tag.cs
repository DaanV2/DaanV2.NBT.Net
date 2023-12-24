namespace DaanV2.NBT;

public sealed partial class NBTTagList : NBTTag {
    /// <inheritdoc/>
    private const NBTTagType _Type = NBTTagType.List;

    /// <inheritdoc/>
    public override NBTTagType Type => _Type;

    /// <inheritdoc/>
    public override Object GetValue() {
        return this.Tags;
    }

    /// <inheritdoc/>
    public override T GetValue<T>() {
        return this.Tags is T val ? val : default;
    }

    /// <inheritdoc/>
    public override Boolean TryGetValue<T>(out T Value) {
        if (this.Tags is T Out) {
            Value = Out;
            return true;
        }

        Value = default;
        return false;
    }

    /// <inheritdoc/>
    public override void SetValue(Object O) {
        if (O is List<ITag> T) {
            this.Tags = T;
        }
        else {
            throw new ArgumentException($"{nameof(O)} must be of type {nameof(List<ITag>)}");
        }
    }

    /// <inheritdoc/>
    public override T ConvertValue<T>() {
        return NBTCasting.ConvertTo<T>(this._Tags);
    }
}
