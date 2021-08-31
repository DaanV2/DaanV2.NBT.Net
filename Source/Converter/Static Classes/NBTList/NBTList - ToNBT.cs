/*ISC License

Copyright (c) 2019, Daan Verstraten */
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
        /// <param name="Name"></param>
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
        /// <typeparam name="T"></typeparam>
        /// <param name="Tags"></param>
        /// <param name="Name"></param>
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
        /// <param name="Name"></param>
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
        /// <typeparam name="T"></typeparam>
        /// <param name="Tags"></param>
        /// <param name="Name"></param>
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
