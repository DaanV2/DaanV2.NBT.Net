/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.Collections.Generic;

namespace DaanV2.NBT; 
public abstract partial class NBTTag {
    /// <summary>Returns a string representation of this this <see cref="ITag"/></summary>
    /// <returns>Returns a string representation of this this <see cref="ITag"/></returns>
    public override String ToString() {
        return $"\"{this.Name}\": \"{this.GetValue()}\"";
    }

    /// <summary>Compare this this <see cref="ITag"/> to the given object</summary>
    /// <param name="obj">The object to compare to</param>
    /// <returns>Compare this this <see cref="ITag"/> to the given object</returns>
    public override Boolean Equals(Object? obj) {
        if (obj is null) {
            return false;
        }
        if (obj is NBTTag Tag) {
            return this.Equals(Tag);
        }
        if (obj is ITag Interface) {
            return this.Equals(Interface);
        }

        return base.Equals(obj);
    }

    /// <summary>Compare this this <see cref="ITag"/> to the given object</summary>
    /// <param name="other">The object to compare to</param>
    /// <returns>Compare this this <see cref="ITag"/> to the given object</returns>
    public Boolean Equals(NBTTag other) {
        return other is not null &&
            EqualityComparer<String>.Default.Equals(this._Name, other._Name) &&
            Comparison.Comparer.Equals(this._Tags, other._Tags);
    }

    /// <summary>Compare this this <see cref="ITag"/> to the given object</summary>
    /// <param name="other">The object to compare to</param>
    /// <returns>Compare this this <see cref="ITag"/> to the given object</returns>
    public Boolean Equals(ITag other) {
        if (other is not null &&
            EqualityComparer<String>.Default.Equals(this._Name, other.Name) &&
            Comparison.Comparer.Equals(this._Tags, other)) {

            return true;
        }

        return false;
    }

    /// <summary>Returns this this <see cref="ITag"/> hashcode</summary>
    /// <returns>Returns this this <see cref="ITag"/> hashcode</returns>
    public override Int32 GetHashCode() {
        return HashCode.Combine(this._Tags, this._Name);
    }
}
