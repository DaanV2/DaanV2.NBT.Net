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
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.NBT {
    public partial class NBTTagList : ITagCollection {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        [IgnoreDataMember]
        public new ITag this[String Name] {
            get {
                Int32 Max = this._Tags.Count;

                for (Int32 I = 0; I < Max; I++) {
                    if (this._Tags[I].Name == Name)
                        return this._Tags[I];
                }

                return null;
            }
            set {
                if (value.Type == this.SubType)
                    throw new ArgumentException($"value type must be same as the lists subtype");

                Int32 Max = this._Tags.Count;

                for (Int32 I = 0; I < Max; I++) {
                    if (this._Tags[I].Name == value.Name) {
                        this._Tags[I] = value;
                        return;
                    }
                }

                this._Tags.Add(value);
            }
        }

        /// <summary></summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        [IgnoreDataMember]
        public new ITag this[Int32 Index] {
            get => this._Tags[Index];
            set {
                if (value.Type == this.SubType)
                    throw new ArgumentException($"value type must be same as the lists subtype");

                this._Tags[Index] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name=""></param>
        public override void Add(ITag tag) {
            if (tag.Type == this.SubType)
                throw new ArgumentException($"value type must be same as the lists subtype");

            Int32 Max = this._Tags.Count;            

            for (Int32 I = 0; I < Max; I++) {
                if (this._Tags[I].Name == tag.Name) {
                    this._Tags[I] = tag;
                    return;
                }
            }
        }
    }
}
