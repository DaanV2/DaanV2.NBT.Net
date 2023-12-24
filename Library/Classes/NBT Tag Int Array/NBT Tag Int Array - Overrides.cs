namespace DaanV2.NBT;
public sealed partial class NBTTagIntArray : IEquatable<NBTTagIntArray> {
    /// <inheritdoc/>
    public override Boolean Equals(Object? Obj) {
        if (Obj is NBTTagIntArray Tag) {
            return this.Equals(Tag);
        }

        return base.Equals(Obj);
    }

    /// <inheritdoc/>
    public Boolean Equals(NBTTagIntArray? other) {
        return other is not null &&
               this._Value.SequenceEqual(other._Value) &&
               this._Name == other._Name;
    }

    /// <inheritdoc/>
    public override Int32 GetHashCode() {
        return HashCode.Combine(this._Name, this._Value);
    }

    /// <inheritdoc/>
    public override ITag Clone() {
        return new NBTTagIntArray() {
            Name = (String)this.Name.Clone(),
            Tags = this.Tags.Clone(),
            Value = this.Value
        };
    }

    /// <inheritdoc/>
    public override String ToString() {
        return $"\"{this.Name}\": [{String.Join(", ", this._Value)}]";
    }
}
