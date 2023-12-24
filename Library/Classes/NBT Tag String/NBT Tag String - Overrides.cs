namespace DaanV2.NBT; 

public sealed partial class NBTTagString: IEquatable<NBTTagString> {
    /// <inheritdoc/>
    public override Boolean Equals(Object? Obj) {
        if (Obj is NBTTagString Tag) {
            return this.Equals(Tag);
        }

        return base.Equals(Obj);
    }

    /// <inheritdoc/>
    public Boolean Equals(NBTTagString? other) {
        return other is not null &&
               this._Name == other._Name &&
               this._Value == other._Value;
    }

    /// <inheritdoc/>
    public override Int32 GetHashCode() {
        return HashCode.Combine(this._Name, this._Value);
    }

    /// <inheritdoc/>
    public override ITag Clone() {
        return new NBTTagString() {
            Name = (String)this.Name.Clone(),
            Tags = this.Tags.Clone(),
            Value = (String)this.Value.Clone()
        };
    }

    /// <inheritdoc/>
    public override String ToString() {
        if (String.IsNullOrEmpty(this.Name)) {
            return $"{this._Value}";
        }
        else {
            return $"\"{this.Name}\": \"{this._Value}\"";
        }
    }
}
