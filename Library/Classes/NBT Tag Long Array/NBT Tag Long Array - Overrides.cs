namespace DaanV2.NBT;
public sealed partial class NBTTagLongArray : IEquatable<NBTTagLongArray> {
    /// <inheritdoc/>
    public override Boolean Equals(Object? Obj) {
        if (Obj is NBTTagLongArray Tag) {
            return this.Equals(Tag);
        }

        return base.Equals(Obj);
    }

    /// <inheritdoc/>
    public Boolean Equals(NBTTagLongArray? other) {
        return other is not null &&
               this._Value.SequenceEqual(other._Value) &&
               this._Name == other._Name;
    }

    /// <inheritdoc/>
    public override Int32 GetHashCode() {
        Int32 hashCode = 1513385649;
        hashCode = (hashCode * -1521134295) + EqualityComparer<Int64[]>.Default.GetHashCode(this._Value);
        hashCode = (hashCode * -1521134295) + EqualityComparer<String>.Default.GetHashCode(this._Name);
        return hashCode;
    }

    /// <inheritdoc/>
    public override ITag Clone() {
        return new NBTTagLongArray() {
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
