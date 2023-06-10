using System;
using System.Collections.Generic;

namespace DaanV2.NBT; 
public sealed partial class NBTTagList {
    /// <summary>Sets the specified information of this this <see cref="ITag"/> with the given value</summary>
    /// <param name="InfoType">The into type to store the information in</param>
    /// <param name="Info">The information to store</param>
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

    /// <summary>Retrieves the specified information</summary>
    /// <param name="InfoType">The info type to retrieve from this this <see cref="ITag"/></param>
    /// <returns>Retrieves the specified information</returns>
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

    /// <summary>Compare this this <see cref="ITag"/> to the given object</summary>
    /// <param name="Obj">The object to compare to</param>
    /// <returns>Compare this this <see cref="ITag"/> to the given object</returns>
    public override Boolean Equals(Object Obj) {
        if (Obj is NBTTagList Tag) {
            return this.Equals(Tag);
        }

        return base.Equals(Obj);
    }

    /// <summary>Compare this this <see cref="ITag"/> to the given object</summary>
    /// <param name="other">The object to compare to</param>
    /// <returns>Compare this this <see cref="ITag"/> to the given object</returns>
    public Boolean Equals(NBTTagList other) {
        return other is not null &&
               EqualityComparer<String>.Default.Equals(this._Name, other._Name) &&
               EqualityComparer<NBTTagType>.Default.Equals(this._SubType, other._SubType) &&
               Comparison.Comparer.Equals<ITag>(this._Tags, other._Tags);
    }

    /// <summary>Returns the hashcode of this this <see cref="ITag"/></summary>
    /// <returns>Returns the hashcode of this this <see cref="ITag"/></returns>
    public override Int32 GetHashCode() {
        Int32 hashCode = 1513385649;
        hashCode = (hashCode * -1521134295) + EqualityComparer<NBTTagType>.Default.GetHashCode(this._SubType);
        hashCode = (hashCode * -1521134295) + EqualityComparer<List<ITag>>.Default.GetHashCode(this._Tags);
        hashCode = (hashCode * -1521134295) + EqualityComparer<String>.Default.GetHashCode(this._Name);
        return hashCode;
    }

    /// <summary>Create a clone of this this <see cref="ITag"/></summary>
    /// <returns>Create a clone of this this <see cref="ITag"/></returns>
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

    /// <summary>Returns a string representation of this this <see cref="ITag"/></summary>
    /// <returns>Returns a string representation of this this <see cref="ITag"/></returns>
    public override String ToString() {
        return $"\"{this.Name}\": [{String.Join(", ", this._Tags)}]";
    }
}
