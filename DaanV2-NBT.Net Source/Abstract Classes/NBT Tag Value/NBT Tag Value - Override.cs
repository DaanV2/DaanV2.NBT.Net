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

namespace DaanV2.NBT {
    public abstract partial class NBTTagValue<TypeValue> {
        ///DOLATER <summary>Add Description</summary>
        /// <returns></returns>
        public override String ToString() {
            return $"'{this.Name}': {this.Type}: {this._Value}";
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override Boolean Equals(Object obj) {

            if (obj is NBTTagValue<TypeValue> TValue) {
                if (this._Value.Equals(TValue._Value) && this._Name.Equals(TValue._Name) && this._Tags.Count == TValue._Tags.Count) {
                    for (Int32 I = 0; I < this._Tags.Count; I++) {
                        if (!this._Tags[I].Equals(TValue[I])) {
                            return false;
                        }
                    }

                    return true;
                }
            }

            return base.Equals(obj);
        }

        ///DOLATER <summary>Add Description</summary>
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

        ///DOLATER <summary>Add Description</summary>
        /// <param name="InfoType"></param>
        /// <returns></returns>
        public override Object GetInformation(NBTTagInformation InfoType) {
            switch (InfoType) {
                case NBTTagInformation.Name:
                    return this._Name;

                case NBTTagInformation.Tag:
                    return this._Tags;

                case NBTTagInformation.ListSize:
                    return this._Tags.Count;

                case NBTTagInformation.Value:
                    return this._Value;

                case NBTTagInformation.ListSubtype:                
                default:
                    return null;
            }
        }
    }
}
