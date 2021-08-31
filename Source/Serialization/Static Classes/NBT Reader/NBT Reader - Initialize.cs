/*ISC License

Copyright (c) 2019, Daan Verstraten */

using System;
using System.Collections.Generic;

namespace DaanV2.NBT.Serialization {
    /// <summary>The class that deserializers the given stream into Tags</summary>
    public static partial class NBTReader {
        /// <summary>Creates a new instance of <see cref="NBTReader"/></summary>
        static NBTReader() {
            NBTReader.Readers = new Dictionary<NBTTagType, ITagReader>();

            List<ITagReader> Readers = Utillity.GetInterfaces<ITagReader>();
            Int32 Length = Readers.Count;

            for (Int32 I = 0; I < Length; I++) {
                for (Int32 J = 0; J < Readers[I].ForType.Length; J++) {
                    NBTReader.Readers[Readers[I].ForType[J]] = Readers[I];
                }
            }
        }
    }
}
