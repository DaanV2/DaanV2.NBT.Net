using System.Runtime.Serialization;

namespace DaanV2.NBT;
public abstract partial class NBTTag : ITagCollection {
    /// <inheritdoc/>
    [IgnoreDataMember]
    public Int32 Count => this._Tags.Count;

    /// <inheritdoc/>
    [DataMember]
    public List<ITag> Tags { get => this._Tags; set => this._Tags = value; }

    /// <inheritdoc/>
    [IgnoreDataMember]
    public ITag? this[String Name] {
        get {
            Int32 Max = this._Tags.Count;

            for (Int32 I = 0; I < Max; I++) {
                if (this._Tags[I].Name == Name) {
                    return this._Tags[I];
                }
            }

            return null;
        }
        set {
            Int32 Max = this._Tags.Count;

            for (Int32 I = 0; I < Max; I++) {
                if (this._Tags[I].Name == value.Name) {
                    this._Tags[I] = value;
                    return;
                }
            }

            this._Tags.Add(value);
        }
    }

    /// <inheritdoc/>
    [IgnoreDataMember]
    public ITag this[Int32 Index] {
        get => this._Tags[Index];
        set => this._Tags[Index] = value;
    }

    /// <inheritdoc/>
    public virtual void Add(ITag tag) {
        Int32 Max = this._Tags.Count;

        for (Int32 I = 0; I < Max; I++) {
            if (this._Tags[I].Name == tag.Name) {
                this._Tags[I] = tag;
                return;
            }
        }

        this._Tags.Add(tag);
    }

    /// <inheritdoc/>
    public virtual void Add(ITag[] tags) {
        Int32 MaxTag = tags.Length;
        ITag tag;

        for (Int32 J = 0; J < MaxTag; J++) {
            tag = tags[J];

            Int32 Max = this._Tags.Count;
            for (Int32 I = 0; I < Max; I++) {
                if (this._Tags[I].Name == tag.Name) {
                    this._Tags[I] = tag;
                    continue;
                }
            }

            this._Tags.Add(tag);
        }
    }

    /// <inheritdoc/>
    public virtual void Clear() {
        this._Tags.Clear();
    }

    /// <inheritdoc/>
    public virtual void Remove(Int32 Index) {
        this._Tags.RemoveAt(Index);
    }

    /// <inheritdoc/>
    public virtual void Remove(String Name) {
        Int32 Max = this._Tags.Count;

        for (Int32 I = 0; I < Max; I++) {
            if (this._Tags[I].Name == Name) {
                this._Tags.RemoveAt(I--);
            }
        }
    }

    /// <inheritdoc/>
    public ITag? GetChild(String Name) {
        Int32 Max = this._Tags.Count;

        for (Int32 I = 0; I < Max; I++) {
            if (this._Tags[I].Name == Name) {
                return this._Tags[I];
            }
        }

        return null;
    }

    /// <inheritdoc/>
    public ITag? GetChild(Int32 Index) {
        if (Index >= this._Tags.Count || Index < 0) {
            return null;
        }

        return this._Tags[Index];
    }

    /// <inheritdoc/>
    public Boolean HasChild(String Name) {
        Int32 Max = this._Tags.Count;

        for (Int32 I = 0; I < Max; I++) {
            if (this._Tags[I].Name == Name) {
                return true;
            }
        }

        return false;
    }

    /// <inheritdoc/>
    public T GetChildValue<T>(String Name) {
        Int32 Max = this._Tags.Count;

        for (Int32 I = 0; I < Max; I++) {
            if (this._Tags[I].Name == Name) {
                return this._Tags[I].ConvertValue<T>();
            }
        }

        return default;
    }

    /// <inheritdoc/>
    public T GetChildValue<T>(Int32 Index) {
        return this._Tags[Index].GetValue<T>();
    }
}
