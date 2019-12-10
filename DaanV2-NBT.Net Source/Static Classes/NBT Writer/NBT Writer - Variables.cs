using System;
using System.Collections.Generic;
using System.IO;
using DaanV2.NBT.Serialization;

namespace DaanV2.NBT {
    public static partial class NBTWriter {
        /// <summary>The dictionary of writers</summary>
        private static Dictionary<NBTTagType, ITagWriter> _Writers;
    }
}
