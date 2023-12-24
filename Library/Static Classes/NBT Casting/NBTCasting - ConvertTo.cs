using System.Runtime.CompilerServices;

namespace DaanV2.NBT;
public static partial class NBTCasting {
    /// <summary>Converts the given object into the specified type</summary>
    /// <typeparam name="T">The type to conver to</typeparam>
    /// <param name="Value">The object to convert</param>
    /// <returns>Converts the given object into the specified type</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T? ConvertTo<T>(Object? Value) {
        if (Value is null) {
            return default;
        }

        if (Value is T t) {
            return t;
        }

        Type To = typeof(T);

        switch (Value) {
            case Byte B:
                return (T)NBTCasting.Convert(B, To);
            case Byte[] Barray:
                return (T)NBTCasting.Convert(Barray, To);
            case Double D:
                return (T)NBTCasting.Convert(D, To);
            case Single F:
                return (T)NBTCasting.Convert(F, To);
            case Int32 I32:
                return (T)NBTCasting.Convert(I32, To);
            case Int32[] I32array:
                return (T)NBTCasting.Convert(I32array, To);
            case Int64 I64:
                return (T)NBTCasting.Convert(I64, To);
            case Int64[] I64array:
                return (T)NBTCasting.Convert(I64array, To);
            case Int16 I16:
                return (T)NBTCasting.Convert(I16, To);
            case String S:
                return (T)NBTCasting.Convert(S, To);
        }

        return (T)Value;
    }

    /// <summary>Converts the given object into the specified type</summary>
    /// <typeparam name="T">The type to conver to</typeparam>
    /// <param name="Value">The object to convert</param>
    /// <returns>Converts the given object into the specified type</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T ConvertTo<T>(Byte Value) {
        return (T)NBTCasting.Convert(Value, typeof(T));
    }

    /// <summary>Converts the given object into the specified type</summary>
    /// <typeparam name="T">The type to conver to</typeparam>
    /// <param name="Value">The object to convert</param>
    /// <returns>Converts the given object into the specified type</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T ConvertTo<T>(Byte[] Value) {
        return (T)NBTCasting.Convert(Value, typeof(T));
    }

    /// <summary>Converts the given object into the specified type</summary>
    /// <typeparam name="T">The type to conver to</typeparam>
    /// <param name="Value">The object to convert</param>
    /// <returns>Converts the given object into the specified type</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T ConvertTo<T>(Int16 Value) {
        return (T)NBTCasting.Convert(Value, typeof(T));
    }

    /// <summary>Converts the given object into the specified type</summary>
    /// <typeparam name="T">The type to conver to</typeparam>
    /// <param name="Value">The object to convert</param>
    /// <returns>Converts the given object into the specified type</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T ConvertTo<T>(Int16[] Value) {
        return (T)NBTCasting.Convert(Value, typeof(T));
    }

    /// <summary>Converts the given object into the specified type</summary>
    /// <typeparam name="T">The type to conver to</typeparam>
    /// <param name="Value">The object to convert</param>
    /// <returns>Converts the given object into the specified type</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T ConvertTo<T>(Int32 Value) {
        return (T)NBTCasting.Convert(Value, typeof(T));
    }

    /// <summary>Converts the given object into the specified type</summary>
    /// <typeparam name="T">The type to conver to</typeparam>
    /// <param name="Value">The object to convert</param>
    /// <returns>Converts the given object into the specified type</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T ConvertTo<T>(Int32[] Value) {
        return (T)NBTCasting.Convert(Value, typeof(T));
    }

    /// <summary>Converts the given object into the specified type</summary>
    /// <typeparam name="T">The type to conver to</typeparam>
    /// <param name="Value">The object to convert</param>
    /// <returns>Converts the given object into the specified type</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T ConvertTo<T>(Int64 Value) {
        return (T)NBTCasting.Convert(Value, typeof(T));
    }

    /// <summary>Converts the given object into the specified type</summary>
    /// <typeparam name="T">The type to conver to</typeparam>
    /// <param name="Value">The object to convert</param>
    /// <returns>Converts the given object into the specified type</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T ConvertTo<T>(Int64[] Value) {
        return (T)NBTCasting.Convert(Value, typeof(T));
    }

    /// <summary>Converts the given object into the specified type</summary>
    /// <typeparam name="T">The type to conver to</typeparam>
    /// <param name="Value">The object to convert</param>
    /// <returns>Converts the given object into the specified type</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T ConvertTo<T>(Single Value) {
        return (T)NBTCasting.Convert(Value, typeof(T));
    }

    /// <summary>Converts the given object into the specified type</summary>
    /// <typeparam name="T">The type to conver to</typeparam>
    /// <param name="Value">The object to convert</param>
    /// <returns>Converts the given object into the specified type</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T ConvertTo<T>(Double Value) {
        return (T)NBTCasting.Convert(Value, typeof(T));
    }

    /// <summary>Converts the given object into the specified type</summary>
    /// <typeparam name="T">The type to conver to</typeparam>
    /// <param name="Value">The object to convert</param>
    /// <returns>Converts the given object into the specified type</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T ConvertTo<T>(String Value) {
        return (T)NBTCasting.Convert(Value, typeof(T));
    }
}
