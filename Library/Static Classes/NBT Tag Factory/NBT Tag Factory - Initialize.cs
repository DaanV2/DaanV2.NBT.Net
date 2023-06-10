/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.Collections.Generic;

namespace DaanV2.NBT; 
/// <summary>The class that stores the information for: Factory</summary>
public static partial class NBTTagFactory {
    /// <summary>Creates a new instance of <see cref="NBTTagFactory"/></summary>
    static NBTTagFactory() {
        NBTTagFactory.Types = new Dictionary<NBTTagType, Type>() {
            { NBTTagType.Byte, typeof(NBTTagByte) },
            { NBTTagType.ByteArray, typeof(NBTTagByteArray) },
            { NBTTagType.Compound, typeof(NBTTagCompound) },
            { NBTTagType.Double, typeof(NBTTagDouble) },
            { NBTTagType.Float, typeof(NBTTagFloat) },
            { NBTTagType.Int, typeof(NBTTagInt) },
            { NBTTagType.IntArray, typeof(NBTTagIntArray) },
            { NBTTagType.List, typeof(NBTTagList) },
            { NBTTagType.Long, typeof(NBTTagLong) },
            { NBTTagType.LongArray, typeof(NBTTagLongArray) },
            { NBTTagType.Short, typeof(NBTTagShort) },
            { NBTTagType.String, typeof(NBTTagString) }
        };
    }
}
