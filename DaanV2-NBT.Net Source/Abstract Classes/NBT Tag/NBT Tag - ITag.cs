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
using System.Runtime.Serialization;

namespace DaanV2.NBT {
    public abstract partial class NBTTag : ITag {

        /// <summary>Gets or sets the name of this tag</summary>
        [DataMember]
        public String Name {
            get => this._Name;
            set => this._Name = value;
        }

        /// <summary>Gets the type of this tag</summary>
        [IgnoreDataMember]
        public abstract NBTTagType Type { get; }

        /// <summary>Gets the value of this tag</summary>
        /// <returns>Gets the value of this tag</returns>
        public abstract Object GetValue();

        /// <summary>Converts the value of this tag to the specified type</summary>
        /// <typeparam name="T">The type to convert to</typeparam>
        /// <returns>Converts the value of this tag to the specified type</returns>
        public abstract T GetValue<T>();

        /// <summary>Sets the value of this tag with the given value</summary>
        /// <param name="O">The value to set</param>
        public abstract void SetValue(Object O);

        /// <summary>Sets the specified information of this tag with the given value</summary>
        /// <param name="InfoType">The into type to store the information in</param>
        /// <param name="Info">The information to store</param>
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

        /// <summary>Retrieves the specified information</summary>
        /// <param name="InfoType">The info type to retrieve from this <see cref="ITag"/></param>
        /// <returns>Retrieves the specified information</returns>
        public virtual Object GetInformation(NBTTagInformation InfoType) {
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

        /// <summary>Converts the value of this tag to the specified type</summary>
        /// <typeparam name="T">The type to convert to</typeparam>
        /// <returns>Converts the value of this tag to the specified type</returns>
        public abstract T ConvertValue<T>();

        /// <summary>Creates a copy of this instance</summary>
        /// <returns>Creates a copy of this instance</returns>
        public abstract ITag Clone();
    }
}
