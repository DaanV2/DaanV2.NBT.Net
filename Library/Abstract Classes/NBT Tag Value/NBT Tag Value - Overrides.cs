﻿namespace DaanV2.NBT;
public abstract partial class NBTTagValue<TypeValue> : IEquatable<NBTTagValue<TypeValue>> {
    /// <inheritdoc/>
    public override void SetInformation(NBTTagInformation InfoType, Object Info) {
        switch (InfoType) {
            case NBTTagInformation.Name:
                this._Name = (String)Info;
                break;

            case NBTTagInformation.Tag:
                this._Tags.Add((ITag)Info);
                break;

            case NBTTagInformation.Value:
                this._Value = (TypeValue)Info;
                break;

            case NBTTagInformation.ListSize:
            case NBTTagInformation.ListSubtype:
            default:
                break;
        }
    }

    /// <inheritdoc/>
    public override Object GetInformation(NBTTagInformation InfoType) {
        switch (InfoType) {
            case NBTTagInformation.Name:
                return this._Name;

            case NBTTagInformation.Tag:
                return this._Tags;

            case NBTTagInformation.ListSize:
                return this._Tags.Count;

            case NBTTagInformation.Value:
                return this._Value;

            case NBTTagInformation.ListSubtype:
            default:
                return null;
        }
    }

    /// <inheritdoc/>
    public override Boolean Equals(Object? obj) {
        if (obj is NBTTagValue<TypeValue> TValue) {
            return this.Equals(TValue);
        }

        return base.Equals(obj);
    }

    /// <inheritdoc/>
    public Boolean Equals(NBTTagValue<TypeValue>? other) {
        return other is not null &&
               this._Name == other._Name &&
               this._Value.Equals(other._Value);
    }

    /// <inheritdoc/>
    public override Int32 GetHashCode() {
        Int32 hashCode = 1513385649;
        hashCode = (hashCode * -1521134295) + EqualityComparer<TypeValue>.Default.GetHashCode(this._Value);
        hashCode = (hashCode * -1521134295) + EqualityComparer<String>.Default.GetHashCode(this._Name);
        return hashCode;
    }

    /// <inheritdoc/>
    public override String ToString() {
        switch (this.Type) {
            case NBTTagType.Compound:
                return $"\"{this.Name}\": {{{String.Join(", ", this._Tags)}}}";

            case NBTTagType.List:
            case NBTTagType.IntArray:
            case NBTTagType.LongArray:
            case NBTTagType.ByteArray:
                return $"\"{this.Name}\": [{String.Join(", ", this._Tags)}]";

            default:
            case NBTTagType.Unknown:
            case NBTTagType.End:
            case NBTTagType.Byte:
            case NBTTagType.Short:
            case NBTTagType.Int:
            case NBTTagType.Long:
            case NBTTagType.Float:
            case NBTTagType.Double:
                return $"\"{this.Name}\": {this.GetValue()}";

            case NBTTagType.String:
                return $"\"{this.Name}\": \"{this.GetValue()}\"";
        }
    }
}
