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

namespace DaanV2.NBT {
    ///DOLATER <summary> add description for interface: ITagCollection</summary>
    public interface ITagCollection {
        ///DOLATER <summary>Add Description</summary>
        Int32 Count { get; }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="Name">The name of the tag</param>
        ///DOLATER <returns>Fill return</returns>
        ITag this[String Name] { get; set; }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="IIndex"></param>
        ///DOLATER <returns>Fill return</returns>
        ITag this[Int32 Index] { get; set; }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="tag"></param>
        void Add(ITag tag);

        ///DOLATER <summary>Add Description</summary>
        /// <param name="Index"></param>
        void Remove(Int32 Index);

        ///DOLATER <summary>Add Description</summary>
        /// <param name="Name">The name of the tag</param>
        void Remove(String Name);

        ///DOLATER <summary>Add Description</summary>
        void Clear();

        ///DOLATER <summary>Add Description</summary>
        ITag GetSubTag(String Name);

        ///DOLATER <summary>Add Description</summary>
        ITag GetSubTag(Int32 Index);

        ///DOLATER <summary>Add Description</summary>
        T GetSubValue<T>(String Name);

        ///DOLATER <summary>Add Description</summary>
        T GetSubValue<T>(Int32 Index);
    }
}
