/*ISC License

Copyright (c) 2019, Daan Verstraten */

namespace DaanV2.NBT;
public abstract partial class NBTTagValue<TypeValue> : NBTTag {
    /// <summary>Returns the value of this <see cref="NBTTagValue{TypeValue}"/> as an <see cref="Object"/></summary>
    /// <returns>Returns the value of this <see cref="NBTTagValue{TypeValue}"/> as an <see cref="Object"/></returns>
    public override Object? GetValue() {
        return this._Value;
    }

    /// <summary>Returns the value of this <see cref="NBTTagValue{TypeValue}"/> as an object of T, returns null if castings values</summary>
    /// <typeparam name="T">The generic type to return</typeparam>
    /// <returns>Returns the value of this <see cref="NBTTagValue{TypeValue}"/> as an object of T, returns null if castings values</returns>
    public override T GetValue<T>() {
        if (this._Value is T val) {
            return val;
        }

        return default;
    }

    /// <summary>Sets the value of this <see cref="NBTTagValue{TypeValue}"/></summary>
    /// <param name="O">The object to store inside</param>
    public override void SetValue(Object? O) {
        if (O is TypeValue v) {
            this._Value = v;
        }
    }

    /// <summary>Sets the value of this <see cref="NBTTagValue{TypeValue}"/></summary>
    /// <param name="O">The object to store inside</param>
    public void SetValue(TypeValue O) {
        this._Value = O;
    }

    /// <summary>Casts the value of this <see cref="NBTTagValue{T}"/> to the specifed type, routes through <see cref="NBTCasting"/></summary>
    /// <typeparam name="T">Add Type description</typeparam>
    /// <returns>Casts the value of this <see cref="NBTTagValue{T}"/> to the specifed type, routes through <see cref="NBTCasting"/></returns>
    public override T ConvertValue<T>() {
        return NBTCasting.ConvertTo<T>(this._Value);
    }
}
