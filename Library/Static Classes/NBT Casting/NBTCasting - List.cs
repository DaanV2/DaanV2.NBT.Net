/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace DaanV2.NBT; 
public static partial class NBTCasting {
    /// <summary>Converts the given tag into a list</summary>
    /// <typeparam name="T">The type to convert the items to</typeparam>
    /// <param name="Tag">The tag to convert to a list</param>
    /// <returns>Converts the given tag into a list</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static List<T> ConvertList<T>(ITag Tag) {
        Int32 Count = Tag.Count;
        var Out = new List<T>(Count);

        for (Int32 I = 0; I < Count; I++) {
            Out.Add(Tag.GetSubValue<T>(I));
        }

        return Out;
    }
}
