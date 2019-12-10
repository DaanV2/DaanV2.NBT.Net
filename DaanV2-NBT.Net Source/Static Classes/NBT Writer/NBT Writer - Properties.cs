using System;
using System.Collections.Generic;
using System.IO;
using DaanV2.NBT.Serialization;

namespace DaanV2.NBT {
    public static partial class NBTWriter {
        /// <summary>Gets or sets the dictionary of writers</summary>
        public static Dictionary<NBTTagType, ITagWriter> Writers { get => NBTWriter._Writers; set => NBTWriter._Writers = value; }
    }
}
