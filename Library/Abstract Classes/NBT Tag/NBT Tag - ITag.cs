using System;
using System.Runtime.Serialization;

namespace DaanV2.NBT; 
public abstract partial class NBTTag : ITag {
    /// <inheritdoc/>
    [DataMember]
    public String Name {
        get => this._Name;
        set => this._Name = value;
    }

    /// <inheritdoc/>
    [IgnoreDataMember]
    public abstract NBTTagType Type { get; }

    /// <inheritdoc/>
    public abstract Object GetValue();

    /// <inheritdoc/>
    public abstract Boolean TryGetValue<T>(out T Value);

    /// <inheritdoc/>
    public abstract T GetValue<T>();

    /// <inheritdoc/>
    public abstract void SetValue(Object O);

    /// <inheritdoc/>
    public virtual void SetInformation(NBTTagInformation InfoType, Object Info) {
        switch (InfoType) {
            case NBTTagInformation.Name:
                this._Name = (String)Info;
                break;

            case NBTTagInformation.Tag:
                this._Tags.Add((ITag)Info);
                break;
                
            case NBTTagInformation.ListSize:
            case NBTTagInformation.ListSubtype:
            case NBTTagInformation.Value:
            default:
                break;
        }
    }

    /// <inheritdoc/>
    public virtual Object? GetInformation(NBTTagInformation InfoType) {
        switch (InfoType) {
            case NBTTagInformation.Name:
                return this._Name;

            case NBTTagInformation.Tag:
                return this._Tags;

            case NBTTagInformation.ListSize:
                return this._Tags.Count;

            case NBTTagInformation.ListSubtype:
            case NBTTagInformation.Value:
            default:
                return null;
        }
    }

    /// <inheritdoc/>
    public abstract T ConvertValue<T>();

    /// <inheritdoc/>
    public abstract ITag Clone();
}
