/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System.Runtime.CompilerServices;

namespace DaanV2.NBT.Serialization;
public static partial class SerializationContextExtension {
    /// <summary>Writes an array of <see cref="Byte"/> into the <see cref="Stream"/></summary>
    /// <param name="Context">The Context that holds the stream, buffer, and Endian</param>
    /// <param name="Buffer">The buffer to write to stream</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void WriteBytes(this SerializationContext Context, ReadOnlySpan<Byte> Buffer) {
        Context.Stream.Write(Buffer);
    }

    /// <summary>Writes an <see cref="Int16"/> into the <see cref="Stream"/></summary>
    /// <param name="Context">The Context that holds the stream, buffer, and Endian</param>
    /// <param name="Value">The value to convert and write to <see cref="Stream"/></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void WriteInt16(this SerializationContext Context, Int16 Value) {
        Span<Byte> buffer = stackalloc Byte[SerializationContextExtension.Int16Size];

        Binary.OntoBytes(buffer, Value, Context.Endian);
        Context.Stream.Write(buffer);
    }

    /// <summary>Writes an <see cref="Int32"/> into the <see cref="Stream"/></summary>
    /// <param name="Context">The Context that holds the stream, buffer, and Endian</param>
    /// <param name="Value">The value to convert and write to <see cref="Stream"/></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void WriteInt32(this SerializationContext Context, Int32 Value) {
        Span<Byte> buffer = stackalloc Byte[SerializationContextExtension.Int32Size];

        Binary.OntoBytes(buffer, Value, Context.Endian);
        Context.Stream.Write(buffer);
    }

    /// <summary>Writes an <see cref="Int64"/> into the <see cref="Stream"/></summary>
    /// <param name="Context">The Context that holds the stream, buffer, and Endian</param>
    /// <param name="Value">The value to convert and write to <see cref="Stream"/></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void WriteInt64(this SerializationContext Context, Int64 Value) {
        Span<Byte> buffer = stackalloc Byte[SerializationContextExtension.Int64Size];

        Binary.OntoBytes(buffer, Value, Context.Endian);
        Context.Stream.Write(buffer);
    }

    /// <summary>Writes an <see cref="Single"/> into the <see cref="Stream"/></summary>
    /// <param name="Context">The Context that holds the stream, buffer, and Endian</param>
    /// <param name="Value">The value to convert and write to <see cref="Stream"/></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void WriteFloat(this SerializationContext Context, Single Value) {
        Span<Byte> buffer = stackalloc Byte[SerializationContextExtension.SingleSize];

        Binary.OntoBytes(buffer, Value, Context.Endian);
        Context.Stream.Write(buffer);
    }

    /// <summary>Writes an <see cref="Double"/> into the <see cref="Stream"/></summary>
    /// <param name="Context">The Context that holds the stream, buffer, and Endian</param>
    /// <param name="Value">The value to convert and write to <see cref="Stream"/></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void WriteDouble(this SerializationContext Context, Double Value) {
        Span<Byte> buffer = stackalloc Byte[SerializationContextExtension.DoubleSize];

        Binary.OntoBytes(buffer, Value, Context.Endian);
        Context.Stream.Write(buffer);
    }

    /// <summary>Writes an array of <see cref="Int32"/> into the <see cref="Stream"/></summary>
    /// <param name="Context">The Context that holds the stream, buffer, and Endian</param>
    /// <param name="Value">The value to convert and write to <see cref="Stream"/></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void WriteInt32Array(this SerializationContext Context, Int32[] Value) {
        Span<Byte> buffer = stackalloc Byte[SerializationContextExtension.Int32Size];

        if (Context.Endian == Endian.Big) {
            for (Int32 I = 0; I < Value.Length; I++) {
                Binary.BigEndian.OntoBytes(buffer, Value[I]);
                Context.Stream.Write(buffer);
            }
        }
        else {
            for (Int32 I = 0; I < Value.Length; I++) {
                Binary.LittleEndian.OntoBytes(buffer, Value[I]);
                Context.Stream.Write(buffer);
            }
        }
    }

    /// <summary>Writes an array of <see cref="Int64"/> into the <see cref="Stream"/></summary>
    /// <param name="Context">The Context that holds the stream, buffer, and Endian</param>
    /// <param name="Value">The value to convert and write to <see cref="Stream"/></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void WriteInt64Array(this SerializationContext Context, Int64[] Value) {
        Span<Byte> buffer = stackalloc Byte[SerializationContextExtension.Int64Size];

        if (Context.Endian == Endian.Big) {
            for (Int32 I = 0; I < Value.Length; I++) {
                Binary.BigEndian.OntoBytes(buffer, Value[I]);
                Context.Stream.Write(buffer);
            }
        }
        else {
            for (Int32 I = 0; I < Value.Length; I++) {
                Binary.LittleEndian.OntoBytes(buffer, Value[I]);
                Context.Stream.Write(buffer);
            }
        }
    }
}
