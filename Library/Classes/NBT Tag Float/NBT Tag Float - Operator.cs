using System;
using System.Runtime.CompilerServices;

namespace DaanV2.NBT; 
public sealed partial class NBTTagFloat {
    /// <summary>Compare two objects to one another to see if they are equal</summary>
    /// <param name="A">The first object to compare</param>
    /// <param name="B">The second object to compare</param>
    /// <returns>Compare two objects to one another to see if they are equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Boolean operator ==(NBTTagFloat A, NBTTagFloat B) {
        Boolean NA = A as Object is null;
        Boolean NB = B as Object is null;

        if (NA && NB) { return true; }
        if (NA || NB) { return false; }

        return A.Equals(B);
    }

    /// <summary>Compare two objects to one another to see if they are not equal</summary>
    /// <param name="A">The first object to compare</param>
    /// <param name="B">The second object to compare</param>
    /// <returns>Compare two objects to one another to see if they are not equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Boolean operator !=(NBTTagFloat A, NBTTagFloat B) {
        return !(A == B);
    }

    /// <summary>Compare two objects to one another to see if they are equal</summary>
    /// <param name="A">The first object to compare</param>
    /// <param name="B">The second object to compare</param>
    /// <returns>Compare two objects to one another to see if they are equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Boolean operator ==(NBTTagFloat A, Object B) {
        Boolean NA = A as Object is null;
        Boolean NB = B as Object is null;

        if (NA && NB) { return true; }
        if (NA || NB) { return false; }

        return A.Equals(B);
    }

    /// <summary>Compare two objects to one another to see if they are not equal</summary>
    /// <param name="A">The first object to compare</param>
    /// <param name="B">The second object to compare</param>
    /// <returns>Compare two objects to one another to see if they are not equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Boolean operator !=(NBTTagFloat A, Object B) {
        return !(A == B);
    }
}
