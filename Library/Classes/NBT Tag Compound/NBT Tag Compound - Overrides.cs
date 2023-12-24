namespace DaanV2.NBT;
public sealed partial class NBTTagCompound: IEquatable<NBTTagCompound> {
    /// <inheritdoc/>
    public override Boolean Equals(Object? Obj) {
        if (Obj is NBTTagCompound Tag) {
            return this.Equals(Tag);
        }

        return base.Equals(Obj);
    }

    /// <inheritdoc/>
    public Boolean Equals(NBTTagCompound? other) {
        if (other is not null) {
            return Comparison.Comparer.Equals(this, other);
        }

        return false;
    }

    /// <inheritdoc/>
    public override Int32 GetHashCode() {
        return HashCode.Combine(this._Name, this._Tags);
    }

    /// <inheritdoc/>
    public override ITag Clone() {
        return new NBTTagCompound() {
            Name = (String)this.Name.Clone(),
            Tags = this.Tags.Clone()
        };
    }

    /// <inheritdoc/>
    public override String ToString() {
        return $"\"{this.Name}\": {{{String.Join(", ", this._Tags)}}}]";
    }
}
