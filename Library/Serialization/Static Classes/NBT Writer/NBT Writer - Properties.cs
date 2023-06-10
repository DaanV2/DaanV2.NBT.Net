using System.Collections.Generic;

namespace DaanV2.NBT.Serialization; 
public static partial class NBTWriter {
    /// <summary>Gets or sets the dictionary of writers</summary>
    public static Dictionary<NBTTagType, ITagWriter> Writers { get => NBTWriter._Writers; set => NBTWriter._Writers = value; }
}
