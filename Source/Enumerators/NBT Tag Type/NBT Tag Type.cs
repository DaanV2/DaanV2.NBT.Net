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
    /// <summary>The enumerator that stores all the possible subtypes for nbt tags</summary>
	[Serializable, DataContract]
    public enum NBTTagType : Byte {
        /// <summary>Marks that the nbt tag is the last in a series of tags</summary>
        End = 0,
        ///<summary>Marks that the nbt tag stores a <see cref="System.Byte"/> of information</summary>
        Byte = 1,
        ///<summary>Marks that the nbt tag stores an <see cref="Int16"/> of information</summary>
        Short = 2,
        ///<summary>Marks that the nbt tag stores an <see cref="Int32"/> of information</summary>
        Int = 3,
        ///<summary>Marks that the nbt tag stores an <see cref="Int64"/> of information</summary>
        Long = 4,
        ///<summary>Marks that the nbt tag stores a <see cref="Single"/> of information</summary>
        Float = 5,
        ///<summary>Marks that the nbt tag stores a <see cref="System.Double"/> of information</summary>
        Double = 6,

#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute 'System.Byte[]'
        ///<summary>Marks that the nbt tag stores a <see cref="System.Byte[]"/> of information</summary>
        ByteArray = 7,
#pragma warning restore CS1584 // XML comment has syntactically incorrect cref attribute 'System.Byte[]'
        ///<summary>Marks that the nbt tag stores a <see cref="System.String"/> of information</summary>
        String = 8,
        ///<summary>Marks that the nbt tag stores a List of unnamed tags</summary>
        List = 9,
        ///<summary>Marks that the nbt tag stores a composite tag of named subtags</summary>
        Compound = 10,

#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute 'Int32[]'
        ///<summary>Marks that the nbt tag stores a <see cref="Int32[]"/> of information</summary>
        IntArray = 11,
#pragma warning restore CS1584 // XML comment has syntactically incorrect cref attribute 'Int32[]'

#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute 'Int64[]'
        ///<summary>Marks that the nbt tag stores a <see cref="Int64[]"/> of information</summary>
        LongArray = 12,
#pragma warning restore CS1584 // XML comment has syntactically incorrect cref attribute 'Int64[]'
        ///<summary>No idea what the tag should be</summary>
        Unknown = 255
    }
}
