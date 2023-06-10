/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.Collections.Generic;

namespace DaanV2.NBT {
    public sealed partial class NBTTagFloat {
        /// <summary>Compare this this <see cref="ITag"/> to the given object</summary>
        /// <param name="Obj">The object to compare to</param>
        /// <returns>Compare this this <see cref="ITag"/> to the given object</returns>
        public override Boolean Equals(Object Obj) {
            if (Obj is NBTTagFloat Tag) {
                return this.Equals(Tag);
            }

            return base.Equals(Obj);
        }

        /// <summary>Compare this this <see cref="ITag"/> to the given object</summary>
        /// <param name="other">The object to compare to</param>
        /// <returns>Compare this this <see cref="ITag"/> to the given object</returns>
        public Boolean Equals(NBTTagFloat other) {
            return other != null &&
                   EqualityComparer<Single>.Default.Equals(this._Value, other._Value) &&
                   EqualityComparer<String>.Default.Equals(this._Name, other._Name);
        }

        /// <summary>Returns the hashcode of this this <see cref="ITag"/></summary>
        /// <returns>Returns the hashcode of this this <see cref="ITag"/></returns>
        public override Int32 GetHashCode() {
            Int32 hashCode = 1513385649;
            hashCode = (hashCode * -1521134295) + EqualityComparer<Single>.Default.GetHashCode(this._Value);
            hashCode = (hashCode * -1521134295) + EqualityComparer<String>.Default.GetHashCode(this._Name);
            return hashCode;
        }

        /// <summary>Clones this this <see cref="ITag"/> into a new one</summary>
        /// <returns>Clones this this <see cref="ITag"/> into a new one</returns>
        public override ITag Clone() {
            return new NBTTagFloat() {
                Name = (String)this.Name.Clone(),
                Tags = this.Tags.Clone(),
                Value = this.Value
            };
        }

        /// <summary>Returns a string representation of this this <see cref="ITag"/></summary>
        /// <returns>Returns a string representation of this this <see cref="ITag"/></returns>
        public override String ToString() {
            if (String.IsNullOrEmpty(this.Name)) {
                return $"{this._Value}";
            }
            else {
                return $"\"{this.Name}\": {this._Value}";
            }
        }
    }
}
