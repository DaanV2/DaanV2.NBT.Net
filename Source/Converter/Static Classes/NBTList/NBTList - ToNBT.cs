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

namespace DaanV2.NBT.Converter {

    public static partial class NBTList {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Tags"></param>
        /// <returns></returns>
        public static NBTTagList ToNBT(this List<ITag> Tags) {
            Int32 Count = Tags.Count;
            var Out = new NBTTagList(NBTTagType.Compound, Count);

            for (Int32 I = 0; I < Count; I++) {
                Out.Add(Tags[I]);
            }

            return Out;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Tags"></param>
        /// <returns></returns>
        public static NBTTagList ToNBT(this List<ITag> Tags, String Name) {
            Int32 Count = Tags.Count;
            var Out = new NBTTagList(Name, NBTTagType.Compound, Count);

            for (Int32 I = 0; I < Count; I++) {
                Out.Add(Tags[I]);
            }

            return Out;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Tags"></param>
        /// <returns></returns>
        public static NBTTagList ToNBT<T>(this List<T> Tags) where T : ITag {
            Int32 Count = Tags.Count;
            var Out = new NBTTagList(NBTTagType.Compound, Count);

            for (Int32 I = 0; I < Count; I++) {
                Out.Add(Tags[I]);
            }

            return Out;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Tags"></param>
        /// <returns></returns>
        public static NBTTagList ToNBT<T>(this List<T> Tags, String Name) where T : ITag {
            Int32 Count = Tags.Count;
            var Out = new NBTTagList(Name, NBTTagType.Compound, Count);

            for (Int32 I = 0; I < Count; I++) {
                Out.Add(Tags[I]);
            }

            return Out;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Tags"></param>
        /// <returns></returns>
        public static NBTTagList ToNBT(this ITag[] Tags) {
            Int32 Count = Tags.Length;
            var Out = new NBTTagList(NBTTagType.Compound, Count);

            for (Int32 I = 0; I < Count; I++) {
                Out.Add(Tags[I]);
            }

            return Out;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Tags"></param>
        /// <returns></returns>
        public static NBTTagList ToNBT(this ITag[] Tags, String Name) {
            Int32 Count = Tags.Length;
            var Out = new NBTTagList(Name, NBTTagType.Compound, Count);

            for (Int32 I = 0; I < Count; I++) {
                Out.Add(Tags[I]);
            }

            return Out;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Tags"></param>
        /// <returns></returns>
        public static NBTTagList ToNBT<T>(this ITag[] Tags) where T : ITag {
            Int32 Count = Tags.Length;
            var Out = new NBTTagList(NBTTagType.Compound, Count);

            for (Int32 I = 0; I < Count; I++) {
                Out.Add(Tags[I]);
            }

            return Out;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Tags"></param>
        /// <returns></returns>
        public static NBTTagList ToNBT<T>(this ITag[] Tags, String Name) where T : ITag {
            Int32 Count = Tags.Length;
            var Out = new NBTTagList(Name, NBTTagType.Compound, Count);

            for (Int32 I = 0; I < Count; I++) {
                Out.Add(Tags[I]);
            }

            return Out;
        }
    }
}
