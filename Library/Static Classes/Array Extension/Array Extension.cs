﻿using System;
using System.Collections.Generic;

namespace DaanV2.NBT; 
/// <summary>The static class that extends upon existing array/collections</summary>
public static partial class ArrayExtension {
    /// <summary>Extends the clone mechanics of all the tags to collections</summary>
    /// <param name="Values">The values of sub tags to convert</param>
    /// <returns>Extends the clone mechanics of all the tags to collections</returns>
    public static List<ITag> Clone(this List<ITag> Values) {
        Int32 Count = Values.Count;
        var Out = new List<ITag>(Count);

        for (Int32 I = 0; I < Count; I++) {
            Out.Add(Values[I].Clone());
        }

        return Out;
    }

    /// <summary>Extends the clone mechanics of all the tags to collections</summary>
    /// <param name="Values">The values of sub tags to convert</param>
    /// <returns>Extends the clone mechanics of all the tags to collections</returns>
    public static List<ITag> Clone(this ITagCollection Values) {
        Int32 Count = Values.Count;
        var Out = new List<ITag>(Count);

        for (Int32 I = 0; I < Count; I++) {
            Out.Add(Values[I].Clone());
        }

        return Out;
    }
}
