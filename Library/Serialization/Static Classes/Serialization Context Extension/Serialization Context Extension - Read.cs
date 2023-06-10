/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System.Runtime.CompilerServices;


namespace DaanV2.NBT.Serialization;
public static partial class SerializationContextExtension {
    /// <summary>Reads the amount of specified bytes from stream and stores them in an array</summary>
    /// <param name="Context">The context to use to read</param>
    /// <param name="Length">The amount of bytes to read from</param>
    /// <returns>Reads the amount of specified bytes from stream and stores them in an array</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Byte[] ReadBytes(this SerializationContext Context, Int32 Length) {
        Byte[] Buffer = new Byte[Length];
        Context.Stream.Read(Buffer);

        return Buffer;
    }

    /// <summary>Reads an <see cref="Int16"/> from the given information</summary>
    /// <param name="Context">The context to use to read</param>
    /// <returns>Reads an <see cref="Int16"/> from the given information</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Int16 ReadInt16(this SerializationContext Context) {
        Span<Byte> buffer = stackalloc Byte[SerializationContextExtension.Int16Size];

        Context.Stream.Read(buffer);
        return Binary.ToInt16(buffer, Context.Endian);
    }

    /// <summary>Reads an <see cref="Int32"/> from the given information</summary>
    /// <param name="Context">The context to use to read</param>
    /// <returns>Reads an <see cref="Int32"/> from the given information</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Int32 ReadInt32(this SerializationContext Context) {
        Span<Byte> buffer = stackalloc Byte[SerializationContextExtension.Int32Size];

        Context.Stream.Read(buffer);
        return Binary.ToInt32(buffer, Context.Endian);
    }

    /// <summary>Reads an <see cref="Int64"/> from the given information</summary>
    /// <param name="Context">The context to use to read</param>
    /// <returns>Reads an <see cref="Int64"/> from the given information</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Int64 ReadInt64(this SerializationContext Context) {
        Span<Byte> buffer = stackalloc Byte[SerializationContextExtension.Int64Size];

        Context.Stream.Read(buffer);
        return Binary.ToInt64(buffer, Context.Endian);
    }

    /// <summary>Reads an <see cref="UInt16"/> from the given information</summary>
    /// <param name="Context">The context to use to read</param>
    /// <returns>Reads an <see cref="UInt16"/> from the given information</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static UInt16 ReadUInt16(this SerializationContext Context) {
        Span<Byte> buffer = stackalloc Byte[SerializationContextExtension.UInt16Size];

        Context.Stream.Read(buffer);
        return Binary.ToUInt16(buffer, Context.Endian);
    }

    /// <summary>Reads an <see cref="UInt32"/> from the given information</summary>
    /// <param name="Context">The context to use to read</param>
    /// <returns>Reads an <see cref="UInt32"/> from the given information</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static UInt32 ReadUInt32(this SerializationContext Context) {
        Span<Byte> buffer = stackalloc Byte[SerializationContextExtension.UInt32Size];

        Context.Stream.Read(buffer);
        return Binary.ToUInt32(buffer, Context.Endian);
    }

    /// <summary>Reads an <see cref="UInt64"/> from the given information</summary>
    /// <param name="Context">The context to use to read</param>
    /// <returns>Reads an <see cref="UInt64"/> from the given information</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static UInt64 ReadUInt64(this SerializationContext Context) {
        Span<Byte> buffer = stackalloc Byte[SerializationContextExtension.UInt64Size];

        Context.Stream.Read(buffer);
        return Binary.ToUInt64(buffer, Context.Endian);
    }

    /// <summary>Reads an <see cref="Single"/> from the given information</summary>
    /// <param name="Context">The context to use to read</param>
    /// <returns>Reads an <see cref="Single"/> from the given information</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Single ReadFloat(this SerializationContext Context) {
        Span<Byte> buffer = stackalloc Byte[SerializationContextExtension.SingleSize];

        Context.Stream.Read(buffer);
        return Binary.ToUInt64(buffer, Context.Endian);
    }

    /// <summary>Reads an <see cref="Double"/> from the given information</summary>
    /// <param name="Context">The context to use to read</param>
    /// <returns>Reads an <see cref="Double"/> from the given information</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Double ReadDouble(this SerializationContext Context) {
        Span<Byte> buffer = stackalloc Byte[SerializationContextExtension.DoubleSize];

        Context.Stream.Read(buffer);
        return Binary.ToUInt64(buffer, Context.Endian);
    }

    /// <summary>Reads an <see cref="Int32"/>[] from the given information</summary>
    /// <param name="Context">The context to use to read</param>
    /// <param name="Length">The amount to read</param>
    /// <returns>Reads an <see cref="Int32"/>[] from the given information</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Int32[] ReadInt32Array(this SerializationContext Context, Int32 Length) {
        Int32[] Out = new Int32[Length];
        Span<Byte> buffer = stackalloc Byte[SerializationContextExtension.Int32Size];

        if (Context.Endian == Endian.Big) {
            for (Int32 I = 0; I < Length; I++) {
                Context.Stream.Read(buffer);
                Out[I] = Binary.BigEndian.ToInt32(buffer);
            }
        }
        else {
            for (Int32 I = 0; I < Length; I++) {
                Context.Stream.Read(buffer);
                Out[I] = Binary.LittleEndian.ToInt32(buffer);
            }
        }

        return Out;
    }

    /// <summary>Reads an <see cref="Int64"/>[] from the given information</summary>
    /// <param name="Context">The context to use to read</param>
    /// <param name="Length">The amount to read</param>
    /// <returns>Reads an <see cref="Int64"/>[] from the given information</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Int64[] ReadInt64Array(this SerializationContext Context, Int32 Length) {
        Span<Byte> buffer = stackalloc Byte[SerializationContextExtension.Int64Size];
        Int64[] Out = new Int64[Length];

        if (Context.Endian == Endian.Big) {
            for (Int32 I = 0; I < Length; I++) {
                Context.Stream.Read(buffer);
                Out[I] = Binary.BigEndian.ToInt64(buffer);
            }
        }
        else {
            for (Int32 I = 0; I < Length; I++) {
                Context.Stream.Read(buffer);
                Out[I] = Binary.LittleEndian.ToInt64(buffer);
            }
        }

        return Out;
    }
}
