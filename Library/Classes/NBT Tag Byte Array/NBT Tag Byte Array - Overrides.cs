namespace DaanV2.NBT;
public sealed partial class NBTTagByteArray : IEquatable<NBTTagByteArray> {
    /// <inheritdoc/>
    public override Boolean Equals(Object? obj) {
        if (obj is NBTTagByteArray Tag) {
            return this.Equals(Tag);
        }

        return base.Equals(obj);
    }

    /// <inheritdoc/>
    public Boolean Equals(NBTTagByteArray? other) {
        return other is not null &&
                this._Name == other._Name &&
                this._Value.SequenceEqual(other._Value);
    }

    /// <inheritdoc/>
    public override Int32 GetHashCode() {
        return HashCode.Combine(this._Name, this._Value);
    }

    /// <inheritdoc/>
    public override ITag Clone() {
        return new NBTTagByteArray() {
            Name = (String)this.Name.Clone(),
            Tags = this.Tags.Clone(),
            Value = this.Value
        };
    }

    /// <inheritdoc/>
    public override String ToString() {
        if (String.IsNullOrEmpty(this.Name)) {
            return $"[{String.Join(", ", this._Value)}]";
        }
        else {
            return $"\"{this.Name}\": [{String.Join(", ", this._Value)}]";
        }
    }
}
