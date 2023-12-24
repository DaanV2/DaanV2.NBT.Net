using System;
using System.Runtime.Serialization;

namespace DaanV2.NBT; 
/// <summary>The enumerator that helps with specifing which </summary>
	[Serializable, DataContract]
public enum NBTTagInformation {
    /// <summary>Marks that the process should target the value of the tag</summary>
    Value,
    /// <summary>Marks that the process should target the name of the tag</summary>
    Name,
    /// <summary>Marks that the process should target the children of the tag</summary>
    Tag,
    /// <summary>Marks that the process should target the size of the list of the tag</summary>
    ListSize,
    /// <summary>Marks that the process should target the sub types of the list of the tag</summary>
    ListSubtype
}
