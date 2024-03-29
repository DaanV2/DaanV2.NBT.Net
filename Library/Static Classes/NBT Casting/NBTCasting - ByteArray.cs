﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace DaanV2.NBT; 
public static partial class NBTCasting {
    /// <summary>Converts the given value into the specified type</summary>
    /// <param name="Value">The value to convert</param>
    /// <param name="To">The type to convert to</param>
    /// <returns>Converts the given value into the specified type</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static Object Convert(Byte[] Value, Type To) {
        if (To == typeof(List<Byte>)) {
            return new List<Byte>(Value);
        }

        return Value;
    }
}
