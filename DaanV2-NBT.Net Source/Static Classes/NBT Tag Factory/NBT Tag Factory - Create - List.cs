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
    public static partial class NBTTagFactory {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="SubType"></param>
        /// <returns></returns>
        private static (ITag List, Type SubType) CreateList(String Name, NBTTagType SubType) {
            ITag Out = NBTTagFactory.Create(NBTTagType.List);
            Type TagType = NBTTagFactory.Types.ContainsKey(NBTTagType.Byte) ? Types[NBTTagType.Byte] : null;

            return (Out, TagType);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="List"></param>
        /// <param name="SubType"></param>
        /// <param name="SubType"></param>
        private static void Transfer<T>(ITag List, Type SubType, List<T> Source) {
            Int32 Count = Source.Count;
            ITag SubTag;

            for (Int32 I = 0; I < Count; I++) {
                SubTag = (ITag)Activator.CreateInstance(SubType);
                SubTag.SetValue(Source[I]);
                List.Add(SubTag);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <param name=""></param>
        /// <returns></returns>
        public static ITag Create(String Name, List<Boolean> Value) {
            (ITag Out, Type TagType) = NBTTagFactory.CreateList(Name, NBTTagType.Byte);
            Int32 Count = Value.Count;
            ITag SubTag;

            for (Int32 I = 0; I < Count; I++) {
                SubTag = (ITag)Activator.CreateInstance(TagType);
                SubTag.SetValue((Byte)(Value[I] ? 1 : 0));
                Out.Add(SubTag);
            }
            return Out;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <param name=""></param>
        /// <returns></returns>
        public static ITag Create(String Name, List<Byte> Value) {
            (ITag Out, Type TagType) = NBTTagFactory.CreateList(Name, NBTTagType.Byte);
            NBTTagFactory.Transfer(Out, TagType, Value);
            return Out;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <param name=""></param>
        /// <returns></returns>
        public static ITag Create(String Name, List<Double> Value) {
            (ITag Out, Type TagType) = NBTTagFactory.CreateList(Name, NBTTagType.Double);
            NBTTagFactory.Transfer(Out, TagType, Value);
            return Out;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <param name=""></param>
        /// <returns></returns>
        public static ITag Create(String Name, List<Single> Value) {
            (ITag Out, Type TagType) = NBTTagFactory.CreateList(Name, NBTTagType.Float);
            NBTTagFactory.Transfer(Out, TagType, Value);
            return Out;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <param name=""></param>
        /// <returns></returns>
        public static ITag Create(String Name, List<Int32> Value) {
            (ITag Out, Type TagType) = NBTTagFactory.CreateList(Name, NBTTagType.Int);
            NBTTagFactory.Transfer(Out, TagType, Value);
            return Out;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <param name=""></param>
        /// <returns></returns>
        public static ITag Create(String Name, List<Int64> Value) {
            (ITag Out, Type TagType) = NBTTagFactory.CreateList(Name, NBTTagType.Long);
            NBTTagFactory.Transfer(Out, TagType, Value);
            return Out;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <param name=""></param>
        /// <returns></returns>
        public static ITag Create(String Name, List<Int16> Value) {
            (ITag Out, Type TagType) = NBTTagFactory.CreateList(Name, NBTTagType.Short);
            NBTTagFactory.Transfer(Out, TagType, Value);
            return Out;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <param name=""></param>
        /// <returns></returns>
        public static ITag Create(String Name, List<String> Value) {
            (ITag Out, Type TagType) = NBTTagFactory.CreateList(Name, NBTTagType.String);
            NBTTagFactory.Transfer(Out, TagType, Value);
            return Out;
        }
    }
}
