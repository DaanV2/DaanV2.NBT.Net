/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.Runtime.CompilerServices;

namespace DaanV2.NBT; 
public abstract partial class NBTTagValue<TypeValue> {

    /// <summary>Compare two <see cref="NBTTagValue{TypeValue}"/> to see if they are equal</summary>
    /// <param name="A">The first object to compare to</param>
    /// <param name="B">The second object to compare</param>
    /// <returns>Compare two <see cref="NBTTagValue{TypeValue}"/> to see if they are equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Boolean operator ==(NBTTagValue<TypeValue> A, NBTTagValue<TypeValue> B) {
        Boolean NA = A as Object is null;
        Boolean NB = B as Object is null;

        if (NA && NB) { return true; }
        if (NA || NB) { return false; }

        return A.Equals(B);
    }

    /// <summary>Compare two <see cref="NBTTagValue{TypeValue}"/> to see if they are not equal</summary>
    /// <param name="A">The first object to compare to</param>
    /// <param name="B">The second object to compare</param>
    /// <returns>Compare two <see cref="NBTTagValue{TypeValue}"/> to see if they are not equal</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Boolean operator !=(NBTTagValue<TypeValue> A, NBTTagValue<TypeValue> B) {
        return !(A == B);
    }

    /// <summary>Compare one <see cref="NBTTagValue{TypeValue}"/> equals a given object</summary>
    /// <param name="A">The first object to compare to</param>
    /// <param name="B">The second object to compare</param>
    /// <returns>Compare one <see cref="NBTTagValue{TypeValue}"/> equals a given object</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Boolean operator ==(NBTTagValue<TypeValue> A, Object B) {
        Boolean NA = A as Object is null;
        Boolean NB = B as Object is null;

        if (NA && NB) { return true; }
        if (NA || NB) { return false; }

        return A.Equals(B);
    }

    /// <summary>Compare one <see cref="NBTTagValue{TypeValue}"/> not equals a given object</summary>
    /// <param name="A">The first object to compare to</param>
    /// <param name="B">The second object to compare</param>
    /// <returns>Compare one <see cref="NBTTagValue{TypeValue}"/> not equals a given object</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Boolean operator !=(NBTTagValue<TypeValue> A, Object B) {
        return !(A == B);
    }

    /// <summary>Compare one <see cref="NBTTagValue{TypeValue}"/> equals a given object</summary>
    /// <param name="A">The first object to compare to</param>
    /// <param name="B">The second object to compare</param>
    /// <returns>Compare one <see cref="NBTTagValue{TypeValue}"/> equals a given object</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Boolean operator ==(NBTTagValue<TypeValue> A, TypeValue B) {
        Boolean NA = A as Object is null;
        Boolean NB = B as Object is null;

        if (NA && NB) { return true; }
        if (NA || NB) { return false; }

        return A.Equals(B);
    }

    /// <summary>Compare one <see cref="NBTTagValue{TypeValue}"/> not equals a given object</summary>
    /// <param name="A">The first object to compare to</param>
    /// <param name="B">The second object to compare</param>
    /// <returns>Compare one <see cref="NBTTagValue{TypeValue}"/> not equals a given object</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Boolean operator !=(NBTTagValue<TypeValue> A, TypeValue B) {
        return !(A == B);
    }
}
