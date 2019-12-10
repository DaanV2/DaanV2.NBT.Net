using System;
using System.Collections.Generic;
using DaanV2.NBT.Serialization;

namespace DaanV2.NBT {
    ///DOLATER <summary> add description for class: NBTWriter</summary>
    public static partial class NBTWriter {
        /// <summary>Creates a new instance of <see cref="NBTWriter"/></summary>
        static NBTWriter() {
            NBTWriter.Writers = new Dictionary<NBTTagType, ITagWriter>();

            List<ITagWriter> Writers = Utillity.GetInterfaces<ITagWriter>();
            Int32 Length = Writers.Count;

            for (Int32 I = 0; I < Length; I++) {
                for (Int32 J = 0; J < Writers[I].ForType.Length; J++) {
                    NBTWriter.Writers[Writers[I].ForType[J]] = Writers[I];
                }
            }
        }
    }
}
