namespace DaanV2.NBT;
public sealed partial class NBTTagList : IEquatable<NBTTagList> {
    /// <inheritdoc/>
    public override void SetInformation(NBTTagInformation InfoType, Object Info) {
        switch (InfoType) {
            case NBTTagInformation.Name:
                this._Name = (String)Info;
                break;

            case NBTTagInformation.Tag:
                this._Tags.Add((ITag)Info);
                break;

            case NBTTagInformation.ListSize:
                Int32 I = (Int32)Info;
                if (I > 0) {
                    this._Tags.AddRange(new ITag[I - this._Tags.Count]);
                }

                break;

            case NBTTagInformation.ListSubtype:
                this._SubType = (NBTTagType)Info;
                break;

            case NBTTagInformation.Value:
                if (Info is List<ITag> NewList) {
                    this._Tags = NewList;
                }

                break;
            default:
                break;
        }
    }

    /// <inheritdoc/>
    public override Object GetInformation(NBTTagInformation InfoType) {
        switch (InfoType) {
            case NBTTagInformation.Name:
                return this._Name;

            case NBTTagInformation.Value:
            case NBTTagInformation.Tag:
                return this._Tags;

            case NBTTagInformation.ListSize:
                return this._Tags.Count;

            case NBTTagInformation.ListSubtype:
                return this._SubType;

            default:
                return null;
        }
    }

    /// <inheritdoc/>
    public override Boolean Equals(Object? Obj) {
        if (Obj is NBTTagList Tag) {
            return this.Equals(Tag);
        }

        return base.Equals(Obj);
    }

    //// <inheritdoc/>
    public Boolean Equals(NBTTagList? other) {
        return other is not null &&
               this._Name == other._Name &&
               this._SubType == other._SubType &&
               Comparison.Comparer.Equals<ITag>(this._Tags, other._Tags);
    }

    /// <inheritdoc/>
    public override Int32 GetHashCode() {
        return HashCode.Combine(this._Name, this._SubType, this._Tags);
    }

    /// <inheritdoc/>
    public override ITag Clone() {
        var Out = new NBTTagList(this.SubType, this._Tags.Count) {
            Name = this.Name
        };
        Int32 Count = this._Tags.Count;

        for (Int32 I = 0; I < Count; I++) {
            Out.Add(this._Tags[I].Clone());
        }

        return Out;
    }

    /// <inheritdoc/>
    public override String ToString() {
        return $"\"{this.Name}\": [{String.Join(", ", this._Tags)}]";
    }
}
