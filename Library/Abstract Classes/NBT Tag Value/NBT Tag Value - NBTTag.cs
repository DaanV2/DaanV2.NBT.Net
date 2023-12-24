
namespace DaanV2.NBT;
public abstract partial class NBTTagValue<TypeValue> : NBTTag {
    /// <inheritdoc/>
    public override Object? GetValue() {
        return this._Value;
    }

    /// <inheritdoc/>
    public override T GetValue<T>() {
        if (this._Value is T val) {
            return val;
        }

        return default;
    }

    /// <inheritdoc/>
    public override Boolean TryGetValue<T>(out T Value) {
        if (this._Value is T val) {
            Value = val;
            return true;
        }

        Value = default;
        return false;
    }

    /// <inheritdoc/>
    public override void SetValue(Object? O) {
        if (O is TypeValue v) {
            this._Value = v;
        }
    }

    /// <inheritdoc/>
    public void SetValue(TypeValue O) {
        this._Value = O;
    }

    /// <inheritdoc/>
    public override T ConvertValue<T>() {
        return NBTCasting.ConvertTo<T>(this._Value);
    }
}
