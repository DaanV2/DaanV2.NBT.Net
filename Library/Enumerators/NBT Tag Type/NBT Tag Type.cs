using System;
using System.Runtime.Serialization;

namespace DaanV2.NBT; 
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
    ///<summary>Marks that the nbt tag stores a <see cref="System.Byte"/>[] of information</summary>
    ByteArray = 7,
    ///<summary>Marks that the nbt tag stores a <see cref="System.String"/> of information</summary>
    String = 8,
    ///<summary>Marks that the nbt tag stores a List of unnamed tags</summary>
    List = 9,
    ///<summary>Marks that the nbt tag stores a composite tag of named children</summary>
    Compound = 10,
    ///<summary>Marks that the nbt tag stores a <see cref="Int32"/>[] of information</summary>
    IntArray = 11,
    ///<summary>Marks that the nbt tag stores a <see cref="Int64"/>[] of information</summary>
    LongArray = 12,
    ///<summary>No idea what the tag should be</summary>
    Unknown = 255
}
