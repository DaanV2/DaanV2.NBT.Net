/*ISC License

Copyright (c) 2019, Daan Verstraten, daanverstraten@hotmail.com

Permission to use, copy, modify, and/or distribute this software for any
purpose with or without fee is hereby granted, provided that the above
copyright notice and this permission notice appear in all copies.

THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF
OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.*/
using System;
using System.Collections.Generic;

namespace DaanV2.NBT {
    public partial class NBTTagList {
        /// <summary>Sets the specified information of this <see cref="Itag"/> with the given value</summary>
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
        /// <param name="InfoType">The info type to retrieve from this <see cref="ITag"/></param>
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

        /// <summary>Compare this <see cref="Itag"/> to the given object</summary>
        /// <param name="other">The object to compare to</param>
        /// <returns>Compare this <see cref="Itag"/> to the given object</returns>
        public override Boolean Equals(Object Obj) {
            if (Obj is NBTTagList Tag) {
                return this.Equals(Tag);
            }

            return base.Equals(Obj);
        }

        /// <summary>Compare this <see cref="Itag"/> to the given object</summary>
        /// <param name="other">The object to compare to</param>
        /// <returns>Compare this <see cref="Itag"/> to the given object</returns>
        public Boolean Equals(NBTTagList other) {
            return other != null &&
                   base.Equals(other) &&
                   EqualityComparer<NBTTagType>.Default.Equals(this._SubType, other._SubType) &&
                   EqualityComparer<List<ITag>>.Default.Equals(this._Tags, other._Tags) &&
                   EqualityComparer<String>.Default.Equals(this._Name, other._Name);
        }

        /// <summary>Returns the hashcode of this <see cref="Itag"/></summary>
        /// <returns>Returns the hashcode of this <see cref="Itag"/></returns>
        public override Int32 GetHashCode() {
            Int32 hashCode = 1513385649;
            hashCode = (hashCode * -1521134295) + EqualityComparer<NBTTagType>.Default.GetHashCode(this._SubType);
            hashCode = (hashCode * -1521134295) + EqualityComparer<List<ITag>>.Default.GetHashCode(this._Tags);
            hashCode = (hashCode * -1521134295) + EqualityComparer<String>.Default.GetHashCode(this._Name);
            return hashCode;
        }

        /// <summary>Create a clone of this <see cref="Itag"/></summary>
        /// <returns>Create a clone of this <see cref="Itag"/></returns>
        public override ITag Clone() {
            NBTTagList Out = new NBTTagList(this.SubType, this._Tags.Count) {
                Name = this.Name
            };
            Int32 Count = this._Tags.Count;

            for (Int32 I = 0; I < Count; I++) {
                Out.Add(this._Tags[I].Clone());
            }

            return Out;
        }
    }
}
