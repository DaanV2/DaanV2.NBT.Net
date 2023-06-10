/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.Collections.Generic;

namespace DaanV2.NBT; 
public static partial class NBTTagFactory {
    /// <summary>The collection of Tag types to actuall types</summary>
    public static Dictionary<NBTTagType, Type> Types { get; set; }
}
