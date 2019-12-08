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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.NBT {
    public partial class NBTTagList {
        /// <summary>
        /// 
        /// </summary>
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
                    if (I > 0)
                        this._Tags.AddRange(new ITag[I - this._Tags.Count]);
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="InfoType"></param>
        /// <returns></returns>
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
    }
}
