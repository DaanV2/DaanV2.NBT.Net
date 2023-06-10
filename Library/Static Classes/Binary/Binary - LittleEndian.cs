using System.Buffers.Binary;

namespace DaanV2.NBT;

public static partial class Binary {
    /// <summary>
    /// 
    /// </summary>
    public static partial class LittleEndian {
        /// <inheritdoc cref="BinaryPrimitives.WriteInt16LittleEndian"/>
        public static void OntoBytes(Span<Byte> data, Int16 value) {
            BinaryPrimitives.WriteInt16LittleEndian(data, value);
        }

        /// <inheritdoc cref="BinaryPrimitives.WriteInt32LittleEndian"/>
        public static void OntoBytes(Span<Byte> data, Int32 value) {
            BinaryPrimitives.WriteInt32LittleEndian(data, value);
        }

        /// <inheritdoc cref="BinaryPrimitives.WriteInt64LittleEndian"/>
        public static void OntoBytes(Span<Byte> data, Int64 value) {
            BinaryPrimitives.WriteInt64LittleEndian(data, value);
        }

        /// <inheritdoc cref="BinaryPrimitives.WriteInt16LittleEndian"/>
        public static void OntoBytes(Span<Byte> data, UInt16 value) {
            BinaryPrimitives.WriteUInt16LittleEndian(data, value);
        }

        /// <inheritdoc cref="BinaryPrimitives.WriteInt32LittleEndian"/>
        public static void OntoBytes(Span<Byte> data, UInt32 value) {
            BinaryPrimitives.WriteUInt32LittleEndian(data, value);
        }

        /// <inheritdoc cref="BinaryPrimitives.WriteInt64LittleEndian"/>
        public static void OntoBytes(Span<Byte> data, UInt64 value) {
            BinaryPrimitives.WriteUInt64LittleEndian(data, value);
        }

        /// <inheritdoc cref="BinaryPrimitives.WriteInt16LittleEndian"/>
        public static void OntoBytes(Span<Byte> data, Single value) {
            BinaryPrimitives.WriteSingleLittleEndian(data, value);
        }

        /// <inheritdoc cref="BinaryPrimitives.WriteInt16LittleEndian"/>
        public static void OntoBytes(Span<Byte> data, Double value) {
            BinaryPrimitives.WriteDoubleLittleEndian(data, value);
        }

        /// <inheritdoc cref="BinaryPrimitives.ReadInt16LittleEndian"/>
        public static Int16 ToInt16(ReadOnlySpan<Byte> data) {
            return BinaryPrimitives.ReadInt16LittleEndian(data);
        }

        /// <inheritdoc cref="BinaryPrimitives.ReadInt32LittleEndian"/>
        public static Int32 ToInt32(ReadOnlySpan<Byte> data) {
            return BinaryPrimitives.ReadInt32LittleEndian(data);
        }

        /// <inheritdoc cref="BinaryPrimitives.ReadInt64LittleEndian"/>
        public static Int64 ToInt64(ReadOnlySpan<Byte> data) {
            return BinaryPrimitives.ReadInt64LittleEndian(data);
        }

        /// <inheritdoc cref="BinaryPrimitives.ReadUInt16LittleEndian"/>
        public static UInt16 ToUInt16(ReadOnlySpan<Byte> data) {
            return BinaryPrimitives.ReadUInt16LittleEndian(data);
        }

        /// <inheritdoc cref="BinaryPrimitives.ReadUInt32LittleEndian"/>
        public static UInt32 ToUInt32(ReadOnlySpan<Byte> data) {
            return BinaryPrimitives.ReadUInt32LittleEndian(data);
        }

        /// <inheritdoc cref="BinaryPrimitives.ReadUInt64LittleEndian"/>
        public static UInt64 ToUInt64(ReadOnlySpan<Byte> data) {
            return BinaryPrimitives.ReadUInt64LittleEndian(data);
        }

        /// <inheritdoc cref="BinaryPrimitives.ReadSingleLittleEndian"/>
        public static Single ToSingle(ReadOnlySpan<Byte> data) {
            return BinaryPrimitives.ReadSingleLittleEndian(data);
        }

        /// <inheritdoc cref="BinaryPrimitives.ReadDoubleLittleEndian"/>
        public static Double ToDouble(ReadOnlySpan<Byte> data) {
            return BinaryPrimitives.ReadDoubleLittleEndian(data);
        }
    }
}
