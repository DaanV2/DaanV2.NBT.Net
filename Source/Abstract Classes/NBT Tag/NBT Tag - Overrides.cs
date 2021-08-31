/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.Collections.Generic;

namespace DaanV2.NBT {
    public abstract partial class NBTTag {
        /// <summary>Returns a string representation of this this <see cref="ITag"/></summary>
        /// <returns>Returns a string representation of this this <see cref="ITag"/></returns>
        public override String ToString() {
            return $"\"{this.Name}\": \"{this.GetValue()}\"";
        }

        /// <summary>Compare this this <see cref="ITag"/> to the given object</summary>
        /// <param name="obj">The object to compare to</param>
        /// <returns>Compare this this <see cref="ITag"/> to the given object</returns>
        public override Boolean Equals(Object obj) {
            if (obj is NBTTag Tag) {
                return this.Equals(Tag);
            }
            else if (obj is ITag Interface) {
                return this.Equals(Interface);
            }

            return base.Equals(obj);
        }

        /// <summary>Compare this this <see cref="ITag"/> to the given object</summary>
        /// <param name="other">The object to compare to</param>
        /// <returns>Compare this this <see cref="ITag"/> to the given object</returns>
        public Boolean Equals(NBTTag other) {
            return other != null &&
                EqualityComparer<String>.Default.Equals(this._Name, other._Name) &&
                Comparison.Comparer.Equals(this._Tags, other._Tags);
        }

        /// <summary>Compare this this <see cref="ITag"/> to the given object</summary>
        /// <param name="other">The object to compare to</param>
        /// <returns>Compare this this <see cref="ITag"/> to the given object</returns>
        public Boolean Equals(ITag other) {
            if (other != null &&
                EqualityComparer<String>.Default.Equals(this._Name, other.Name) &&
                Comparison.Comparer.Equals(this._Tags, other)) {

                return true;
            }

            return false;
        }

        /// <summary>Returns this this <see cref="ITag"/> hashcode</summary>
        /// <returns>Returns this this <see cref="ITag"/> hashcode</returns>
        public override Int32 GetHashCode() {
#if NETCORE
            return HashCode.Combine(this._Tags, this._Name);
#else
            Int32 hashCode = 1513385649;
            hashCode = (hashCode * -1521134295) + EqualityComparer<List<ITag>>.Default.GetHashCode(this._Tags);
            hashCode = (hashCode * -1521134295) + EqualityComparer<String>.Default.GetHashCode(this._Name);
            return hashCode;
#endif
        }
    }
}
