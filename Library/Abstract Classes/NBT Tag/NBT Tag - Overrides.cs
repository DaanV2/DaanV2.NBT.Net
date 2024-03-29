﻿namespace DaanV2.NBT;
public abstract partial class NBTTag {
    /// <inheritdoc/>
    public override String ToString() {
        return $"\"{this.Name}\": \"{this.GetValue()}\"";
    }

    /// <inheritdoc/>
    public override Boolean Equals(Object? obj) {
        if (obj is null) {
            return false;
        }
        if (obj is NBTTag Tag) {
            return this.Equals(Tag);
        }
        if (obj is ITag Interface) {
            return this.Equals(Interface);
        }

        return base.Equals(obj);
    }

    /// <inheritdoc/>
    public Boolean Equals(NBTTag? other) {
        return other is not null &&
            this._Name == other._Name &&
            Comparison.Comparer.Equals(this._Tags, other._Tags);
    }

    /// <inheritdoc/>
    public override Int32 GetHashCode() {
        return HashCode.Combine(this._Tags, this._Name);
    }
}
