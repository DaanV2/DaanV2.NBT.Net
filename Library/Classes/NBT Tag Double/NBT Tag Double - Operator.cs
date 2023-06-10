/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.Runtime.CompilerServices;

namespace DaanV2.NBT; 
public sealed partial class NBTTagDouble {
    /// <summary>Compare the two given tag with each other</summary>
    /// <param name="A">The first object to compare</param>
    /// <param name="B">The second object to compare</param>
    /// <returns>Compare the two given tag with each other</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Boolean operator ==(NBTTagDouble A, NBTTagDouble B) {
        Boolean NA = A as Object is null;
        Boolean NB = B as Object is null;

        if (NA && NB) { return true; }
        if (NA || NB) { return false; }

        return A.Equals(B);
    }

    /// <summary>Compare the two given tag with each other</summary>
    /// <param name="A">The first object to compare</param>
    /// <param name="B">The second object to compare</param>
    /// <returns>Compare the two given tag with each other</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Boolean operator !=(NBTTagDouble A, NBTTagDouble B) {
        return !(A == B);
    }

    /// <summary>Compare the two given tag with each other</summary>
    /// <param name="A">The first object to compare</param>
    /// <param name="B">The second object to compare</param>
    /// <returns>Compare the two given tag with each other</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Boolean operator ==(NBTTagDouble A, Object B) {
        Boolean NA = A as Object is null;
        Boolean NB = B as Object is null;

        if (NA && NB) { return true; }
        if (NA || NB) { return false; }

        return A.Equals(B);
    }

    /// <summary>Compare the two given tag with each other</summary>
    /// <param name="A">The first object to compare</param>
    /// <param name="B">The second object to compare</param>
    /// <returns>Compare the two given tag with each other</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Boolean operator !=(NBTTagDouble A, Object B) {
        return !(A == B);
    }
}
