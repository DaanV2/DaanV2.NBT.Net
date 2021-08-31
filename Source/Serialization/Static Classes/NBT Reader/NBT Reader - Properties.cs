/*ISC License

Copyright (c) 2019, Daan Verstraten */

using System.Collections.Generic;

namespace DaanV2.NBT.Serialization {
    public static partial class NBTReader {
        /// <summary>The dictionary of readers</summary>
        public static Dictionary<NBTTagType, ITagReader> Readers { get => _Readers; set => _Readers = value; }
    }
}
