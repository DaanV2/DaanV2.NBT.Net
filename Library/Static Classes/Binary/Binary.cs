using System.Buffers.Binary;

namespace DaanV2.NBT;

///DOLATER <summary>add description for class: Binary</summary>
public static partial class Binary {
    /// <inheritdoc cref="LittleEndian.ToInt16"/>
    public static Int16 ToInt16(ReadOnlySpan<Byte> data, Endian endian) {
        if (endian == Endian.Little) {
            return LittleEndian.ToInt16(data);
        }

        return BigEndian.ToInt16(data);
    }

    /// <inheritdoc cref="LittleEndian.ToInt32"/>
    public static Int32 ToInt32(ReadOnlySpan<Byte> data, Endian endian) {
        if (endian == Endian.Little) {
            return LittleEndian.ToInt32(data);
        }

        return BigEndian.ToInt32(data);
    }

    /// <inheritdoc cref="LittleEndian.ToInt64"/>
    public static Int64 ToInt64(ReadOnlySpan<Byte> data, Endian endian) {
        if (endian == Endian.Little) {
            return LittleEndian.ToInt64(data);
        }

        return BigEndian.ToInt64(data);
    }

    /// <inheritdoc cref="LittleEndian.ToUInt16"/>
    public static UInt16 ToUInt16(ReadOnlySpan<Byte> data, Endian endian) {
        if (endian == Endian.Little) {
            return LittleEndian.ToUInt16(data);
        }

        return BigEndian.ToUInt16(data);
    }

    /// <inheritdoc cref="LittleEndian.ToUInt32"/>
    public static UInt32 ToUInt32(ReadOnlySpan<Byte> data, Endian endian) {
        if (endian == Endian.Little) {
            return LittleEndian.ToUInt32(data);
        }

        return BigEndian.ToUInt32(data);
    }

    /// <inheritdoc cref="LittleEndian.ToUInt64"/>
    public static UInt64 ToUInt64(ReadOnlySpan<Byte> data, Endian endian) {
        if (endian == Endian.Little) {
            return LittleEndian.ToUInt64(data);
        }

        return BigEndian.ToUInt64(data);
    }

    /// <inheritdoc cref="BinaryPrimitives.ReadSingleBigEndian"/>
    public static Single ToSingle(ReadOnlySpan<Byte> data, Endian endian) {
        if (endian == Endian.Little) {
            return LittleEndian.ToSingle(data);
        }

        return BigEndian.ToSingle(data);
    }

    /// <inheritdoc cref="BinaryPrimitives.ReadDoubleBigEndian"/>
    public static Double ToDouble(ReadOnlySpan<Byte> data, Endian endian) {
        if (endian == Endian.Little) {
            return LittleEndian.ToDouble(data);
        }

        return BigEndian.ToDouble(data);
    }


    /// <inheritdoc cref="LittleEndian.OntoBytes(Span{Byte}, Int16)"/>
    public static void OntoBytes(Span<Byte> data, Int16 value, Endian endian) {
        if (endian == Endian.Little) {
            LittleEndian.OntoBytes(data, value);
        }
        else {
            BigEndian.OntoBytes(data, value);
        }
    }

    /// <inheritdoc cref="LittleEndian.OntoBytes(Span{Byte}, Int32)"/>
    public static void OntoBytes(Span<Byte> data, Int32 value, Endian endian) {
        if (endian == Endian.Little) {
            LittleEndian.OntoBytes(data, value);
        }
        else {
            BigEndian.OntoBytes(data, value);
        }
    }

    /// <inheritdoc cref="LittleEndian.OntoBytes(Span{Byte}, Int64)"/>
    public static void OntoBytes(Span<Byte> data, Int64 value, Endian endian) {
        if (endian == Endian.Little) {
            LittleEndian.OntoBytes(data, value);
        }
        else {
            BigEndian.OntoBytes(data, value);
        }
    }

    /// <inheritdoc cref="LittleEndian.OntoBytes(Span{Byte}, UInt16)"/>
    public static void OntoBytes(Span<Byte> data, UInt16 value, Endian endian) {
        if (endian == Endian.Little) {
            LittleEndian.OntoBytes(data, value);
        }
        else {
            BigEndian.OntoBytes(data, value);
        }
    }

    /// <inheritdoc cref="LittleEndian.OntoBytes(Span{Byte}, UInt32)"/>
    public static void OntoBytes(Span<Byte> data, UInt32 value, Endian endian) {
        if (endian == Endian.Little) {
            LittleEndian.OntoBytes(data, value);
        }
        else {
            BigEndian.OntoBytes(data, value);
        }
    }

    /// <inheritdoc cref="LittleEndian.OntoBytes(Span{Byte}, UInt64)"/>
    public static void OntoBytes(Span<Byte> data, UInt64 value, Endian endian) {
        if (endian == Endian.Little) {
            LittleEndian.OntoBytes(data, value);
        }
        else {
            BigEndian.OntoBytes(data, value);
        }
    }

    /// <inheritdoc cref="LittleEndian.OntoBytes(Span{Byte}, Int32)"/>
    public static void OntoBytes(Span<Byte> data, Single value, Endian endian) {
        if (endian == Endian.Little) {
            LittleEndian.OntoBytes(data, value);
        }
        else {
            BigEndian.OntoBytes(data, value);
        }
    }

    /// <inheritdoc cref="LittleEndian.OntoBytes(Span{Byte}, Int32)"/>
    public static void OntoBytes(Span<Byte> data, Double value, Endian endian) {
        if (endian == Endian.Little) {
            LittleEndian.OntoBytes(data, value);
        }
        else {
            BigEndian.OntoBytes(data, value);
        }
    }
}
