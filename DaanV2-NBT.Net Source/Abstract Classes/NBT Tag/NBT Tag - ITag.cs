﻿/*ISC License

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

        ///DOLATER <summary>Add Description</summary>
        [DataMember]
        public String Name {
            get => this._Name;
            set => this._Name = value;
        }

        ///DOLATER <summary>Add Description</summary>
        [IgnoreDataMember]
        public abstract NBTTagType Type { get; }

        ///DOLATER <summary>Add Description</summary>
        /// <returns></returns>
        public abstract Object GetValue();

        ///DOLATER <summary>Add Description</summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public abstract T GetValue<T>();

        ///DOLATER <summary>Add Description</summary>
        /// <param name="O"></param>
        public abstract void SetValue(Object O);

        ///DOLATER <summary>Add Description</summary>
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

        ///DOLATER <summary>Add Description</summary>
        /// <param name="InfoType">The info type to retrieve from this <see="ITag"> </param>
        /// <returns></returns>
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

        /// <summary></summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public abstract T ConvertValue<T>();

        /// <summary></summary>
        /// <returns></returns>
        public abstract ITag Clone();
    }
}
