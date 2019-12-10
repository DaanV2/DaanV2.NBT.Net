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
using System.
/* Unmerged change from project 'EP-API-Nbt-Data.Net Core'
Before:
using System.Runtime.Serialization;
using System.Linq;
After:
using System.Linq;
using System.Runtime.Serialization;
*/
Runtime.Serialization;

namespace DaanV2.NBT {
    ///DOLATER <summary> add description for enumerator: TagType</summary>
	[Serializable, DataContract]
    public enum NBTTagType : Byte {
        ///DOLATER <summary>Add Description</summary>
        End = 0,
        ///DOLATER <summary>Add Description</summary>
        Byte = 1,
        ///DOLATER <summary>Add Description</summary>
        Short = 2,
        ///DOLATER <summary>Add Description</summary>
        Int = 3,
        ///DOLATER <summary>Add Description</summary>
        Long = 4,
        ///DOLATER <summary>Add Description</summary>
        Float = 5,
        ///DOLATER <summary>Add Description</summary>
        Double = 6,
        ///DOLATER <summary>Add Description</summary>
        ByteArray = 7,
        ///DOLATER <summary>Add Description</summary>
        String = 8,
        ///DOLATER <summary>Add Description</summary>
        List = 9,
        ///DOLATER <summary>Add Description</summary>
        Compound = 10,
        ///DOLATER <summary>Add Description</summary>
        IntArray = 11,
        ///DOLATER <summary>Add Description</summary>
        LongArray = 12,
        ///DOLATER <summary>Add Description</summary>
        Unknown = 255
    }
}
