/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.Collections.Generic;

namespace DaanV2.NBT {
    public sealed partial class NBTTagCompound {
        /// <summary>Compares this this <see cref="ITag"/> to the given object</summary>
        /// <param name="Obj">The object to compare to</param>
        /// <returns>Compares this this <see cref="ITag"/> to the given object</returns>
        public override Boolean Equals(Object Obj) {
            if (Obj is NBTTagCompound Tag) {
                return this.Equals(Tag);
            }

            return base.Equals(Obj);
        }

        /// <summary>Compare this this <see cref="ITag"/> to the given object</summary>
        /// <param name="other">The object to compare to</param>
        /// <returns>Compare this this <see cref="ITag"/> to the given object</returns>
        public Boolean Equals(NBTTagCompound other) {
            if (other != null) {
                return Comparison.Comparer.Equals(this, other);
            }

            return false;
        }

        /// <summary>Returns the hashcode of this this <see cref="ITag"/></summary>
        /// <returns>Returns the hashcode of this this <see cref="ITag"/></returns>
        public override Int32 GetHashCode() {
            Int32 hashCode = 1513385649;
            hashCode = (hashCode * -1521134295) + EqualityComparer<List<ITag>>.Default.GetHashCode(this._Tags);
            hashCode = (hashCode * -1521134295) + EqualityComparer<String>.Default.GetHashCode(this._Name);
            return hashCode;
        }

        /// <summary>Clones this this <see cref="ITag"/> into a new one</summary>
        /// <returns>Clones this this <see cref="ITag"/> into a new one</returns>
        public override ITag Clone() {
            return new NBTTagCompound() {
                Name = (String)this.Name.Clone(),
                Tags = this.Tags.Clone()
            };
        }

        /// <summary>Returns a string representation of this this <see cref="ITag"/></summary>
        /// <returns>Returns a string representation of this this <see cref="ITag"/></returns>
        public override String ToString() {
            return $"\"{this.Name}\": {{{String.Join(", ", this._Tags)}}}]";
        }
    }
}
