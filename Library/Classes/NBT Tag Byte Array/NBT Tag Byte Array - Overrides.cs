namespace DaanV2.NBT;
public sealed partial class NBTTagByteArray : IEquatable<NBTTagByteArray> {
    /// <summary>Compare this this <see cref="ITag"/> to the given object</summary>
    /// <param name="obj">The object to compare to</param>
    /// <returns>Compare this this <see cref="ITag"/> to the given object</returns>
    public override Boolean Equals(Object? obj) {
        if (obj is NBTTagByteArray Tag) {
            return this.Equals(Tag);
        }

        return base.Equals(obj);
    }

    /// <summary>Compare this this <see cref="ITag"/> to the given object</summary>
    /// <param name="other">The object to compare to</param>
    /// <returns>Compare this this <see cref="ITag"/> to the given object</returns>
    public Boolean Equals(NBTTagByteArray? other) {
        return other is not null &&
                this._Name == other._Name &&
                this._Value.SequenceEqual(other._Value);
    }

    /// <summary>Returns the hashcode of this this <see cref="ITag"/></summary>
    /// <returns>Returns the hashcode of this this <see cref="ITag"/></returns>
    public override Int32 GetHashCode() {
        Int32 hashCode = 1513385649;
        hashCode = (hashCode * -1521134295) + EqualityComparer<Byte[]>.Default.GetHashCode(this._Value);
        hashCode = (hashCode * -1521134295) + EqualityComparer<String>.Default.GetHashCode(this._Name);
        return hashCode;
    }

    /// <summary>Clones this this <see cref="ITag"/> into a new one</summary>
    /// <returns>Clones this this <see cref="ITag"/> into a new one</returns>
    public override ITag Clone() {
        return new NBTTagByteArray() {
            Name = (String)this.Name.Clone(),
            Tags = this.Tags.Clone(),
            Value = this.Value
        };
    }

    /// <summary>Returns a string representation of this this <see cref="ITag"/></summary>
    /// <returns>Returns a string representation of this this <see cref="ITag"/></returns>
    public override String ToString() {
        if (String.IsNullOrEmpty(this.Name)) {
            return $"[{String.Join(", ", this._Value)}]";
        }
        else {
            return $"\"{this.Name}\": [{String.Join(", ", this._Value)}]";
        }
    }
}
