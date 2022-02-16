/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.Collections.Generic;

namespace DaanV2.NBT {
    public abstract partial class NBTTagValue<TypeValue> : IEquatable<NBTTagValue<TypeValue>>, IEquatable<TypeValue> {
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
            return InfoType switch {
                NBTTagInformation.Name => this._Name,
                NBTTagInformation.Tag => this._Tags,
                NBTTagInformation.ListSize => this._Tags.Count,
                NBTTagInformation.Value => this._Value,
                _ => null,
            };
        }

        /// <inheritdoc/>
        public override Boolean Equals(Object obj) {
            if (obj is NBTTagValue<TypeValue> TValue) {
                return this.Equals(TValue);
            }

            return base.Equals(obj);
        }

        /// <inheritdoc/>
        public Boolean Equals(NBTTagValue<TypeValue> other) {
            if (other is not null && 
                   EqualityComparer<String>.Default.Equals(this._Name, other._Name) &&
                   EqualityComparer<TypeValue>.Default.Equals(this._Value, other._Value))
                return true;

            return false;
        }

        /// <inheritdoc/>
        public Boolean Equals(TypeValue other) {
            if (other is not null && EqualityComparer<TypeValue>.Default.Equals(this._Value, other))
                return true;

            return false;
        }

        /// <inheritdoc/>
        public override Int32 GetHashCode() {
            return HashCode.Combine(base.GetHashCode(), this._Tags, this._Name, this._Value);
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
}
