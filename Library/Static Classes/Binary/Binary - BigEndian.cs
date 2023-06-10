using System.Buffers.Binary;

namespace DaanV2.NBT;

public static partial class Binary {
    /// <summary>
    /// 
    /// </summary>
    public static partial class BigEndian {
        /// <inheritdoc cref="BinaryPrimitives.WriteInt16BigEndian"/>
        public static void OntoBytes(Span<Byte> data, Int16 value) {
            BinaryPrimitives.WriteInt16BigEndian(data, value);
        }

        /// <inheritdoc cref="BinaryPrimitives.WriteInt32BigEndian"/>
        public static void OntoBytes(Span<Byte> data, Int32 value) {
            BinaryPrimitives.WriteInt32BigEndian(data, value);
        }

        /// <inheritdoc cref="BinaryPrimitives.WriteInt64BigEndian"/>
        public static void OntoBytes(Span<Byte> data, Int64 value) {
            BinaryPrimitives.WriteInt64BigEndian(data, value);
        }

        /// <inheritdoc cref="BinaryPrimitives.WriteInt16BigEndian"/>
        public static void OntoBytes(Span<Byte> data, UInt16 value) {
            BinaryPrimitives.WriteUInt16BigEndian(data, value);
        }

        /// <inheritdoc cref="BinaryPrimitives.WriteInt32BigEndian"/>
        public static void OntoBytes(Span<Byte> data, UInt32 value) {
            BinaryPrimitives.WriteUInt32BigEndian(data, value);
        }

        /// <inheritdoc cref="BinaryPrimitives.WriteInt64BigEndian"/>
        public static void OntoBytes(Span<Byte> data, UInt64 value) {
            BinaryPrimitives.WriteUInt64BigEndian(data, value);
        }

        /// <inheritdoc cref="BinaryPrimitives.WriteInt16BigEndian"/>
        public static void OntoBytes(Span<Byte> data, Single value) {
            BinaryPrimitives.WriteSingleBigEndian(data, value);
        }

        /// <inheritdoc cref="BinaryPrimitives.WriteInt16BigEndian"/>
        public static void OntoBytes(Span<Byte> data, Double value) {
            BinaryPrimitives.WriteDoubleBigEndian(data, value);
        }

        /// <inheritdoc cref="BinaryPrimitives.ReadInt16BigEndian"/>
        public static Int16 ToInt16(ReadOnlySpan<Byte> data) {
            return BinaryPrimitives.ReadInt16BigEndian(data);
        }

        /// <inheritdoc cref="BinaryPrimitives.ReadInt32BigEndian"/>
        public static Int32 ToInt32(ReadOnlySpan<Byte> data) {
            return BinaryPrimitives.ReadInt32BigEndian(data);
        }

        /// <inheritdoc cref="BinaryPrimitives.ReadInt64BigEndian"/>
        public static Int64 ToInt64(ReadOnlySpan<Byte> data) {
            return BinaryPrimitives.ReadInt64BigEndian(data);
        }

        /// <inheritdoc cref="BinaryPrimitives.ReadUInt16BigEndian"/>
        public static UInt16 ToUInt16(ReadOnlySpan<Byte> data) {
            return BinaryPrimitives.ReadUInt16BigEndian(data);
        }

        /// <inheritdoc cref="BinaryPrimitives.ReadUInt32BigEndian"/>
        public static UInt32 ToUInt32(ReadOnlySpan<Byte> data) {
            return BinaryPrimitives.ReadUInt32BigEndian(data);
        }

        /// <inheritdoc cref="BinaryPrimitives.ReadUInt64BigEndian"/>
        public static UInt64 ToUInt64(ReadOnlySpan<Byte> data) {
            return BinaryPrimitives.ReadUInt64BigEndian(data);
        }

        /// <inheritdoc cref="BinaryPrimitives.ReadSingleBigEndian"/>
        public static Single ToSingle(ReadOnlySpan<Byte> data) {
            return BinaryPrimitives.ReadSingleBigEndian(data);
        }

        /// <inheritdoc cref="BinaryPrimitives.ReadDoubleBigEndian"/>
        public static Double ToDouble(ReadOnlySpan<Byte> data) {
            return BinaryPrimitives.ReadDoubleBigEndian(data);
        }
    }
}
