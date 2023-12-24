namespace DaanV2.NBT;
public sealed partial class NBTTagByte : IEquatable<NBTTagByte> {
    /// <inheritdoc/>
    public override Boolean Equals(Object? Obj) {
        if (Obj is NBTTagByte Tag) {
            return this.Equals(Tag);
        }

        return base.Equals(Obj);
    }

    /// <inheritdoc/>
    public Boolean Equals(NBTTagByte? other) {
        return other is not null &&
               this._Value == other._Value &&
               this._Name == other._Name;
    }

    /// <inheritdoc/>
    public override Int32 GetHashCode() {
        return HashCode.Combine(this._Name, this._Value);   
    }

    /// <inheritdoc/>
    public override ITag Clone() {
        return new NBTTagByte() {
            Name = (String)this.Name.Clone(),
            Tags = this.Tags.Clone(),
            Value = this.Value
        };
    }

    /// <inheritdoc/>
    public override String ToString() {
        if (String.IsNullOrEmpty(this.Name)) {
            return $"{this._Value}";
        }
        else {
            return $"\"{this.Name}\": {this._Value}";
        }
    }
}
