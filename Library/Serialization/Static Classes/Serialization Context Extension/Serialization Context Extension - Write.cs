/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.IO;
using System.Runtime.CompilerServices;
using DaanV2.Binary;
using BitConverter = DaanV2.Binary.BitConverter;

namespace DaanV2.NBT.Serialization {
    public static partial class SerializationContextExtension {
        /// <summary>Writes an array of <see cref="Byte"/> into the <see cref="Stream"/></summary>
        /// <param name="Context">The Context that holds the stream, buffer, and endianness</param>
        /// <param name="Buffer">The buffer to write to stream</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBytes(this SerializationContext Context, Byte[] Buffer) {
            Context.Stream.Write(Buffer, 0, Buffer.Length);
        }

        /// <summary>Writes an <see cref="Int16"/> into the <see cref="Stream"/></summary>
        /// <param name="Context">The Context that holds the stream, buffer, and endianness</param>
        /// <param name="Value">The value to convert and write to <see cref="Stream"/></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteInt16(this SerializationContext Context, Int16 Value) {
            Byte[] Buffer = BitConverter.Endian.ToBytes(Value, Context.Endianness);
            Context.Stream.Write(Buffer, 0, Buffer.Length);
        }

        /// <summary>Writes an <see cref="Int32"/> into the <see cref="Stream"/></summary>
        /// <param name="Context">The Context that holds the stream, buffer, and endianness</param>
        /// <param name="Value">The value to convert and write to <see cref="Stream"/></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteInt32(this SerializationContext Context, Int32 Value) {
            BitConverter.Endian.OntoBytes(Context.Buffer, Value, Context.Endianness);
            Context.Stream.Write(Context.Buffer, 0, sizeof(Int32));
        }

        /// <summary>Writes an <see cref="Int64"/> into the <see cref="Stream"/></summary>
        /// <param name="Context">The Context that holds the stream, buffer, and endianness</param>
        /// <param name="Value">The value to convert and write to <see cref="Stream"/></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteInt64(this SerializationContext Context, Int64 Value) {
            BitConverter.Endian.OntoBytes(Context.Buffer, Value, Context.Endianness);
            Context.Stream.Write(Context.Buffer, 0, sizeof(Int64));
        }

        /// <summary>Writes an <see cref="Single"/> into the <see cref="Stream"/></summary>
        /// <param name="Context">The Context that holds the stream, buffer, and endianness</param>
        /// <param name="Value">The value to convert and write to <see cref="Stream"/></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteFloat(this SerializationContext Context, Single Value) {
            Byte[] Bytes = System.BitConverter.GetBytes(Value);

            if (System.BitConverter.IsLittleEndian != (Context.Endianness == Endianness.LittleEndian)) {
                Array.Reverse(Bytes);
            }

            Context.Stream.Write(Bytes, 0, Bytes.Length);
        }

        /// <summary>Writes an <see cref="Double"/> into the <see cref="Stream"/></summary>
        /// <param name="Context">The Context that holds the stream, buffer, and endianness</param>
        /// <param name="Value">The value to convert and write to <see cref="Stream"/></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteDouble(this SerializationContext Context, Double Value) {
            Byte[] Bytes = System.BitConverter.GetBytes(Value);

            if (System.BitConverter.IsLittleEndian != (Context.Endianness == Endianness.LittleEndian)) {
                Array.Reverse(Bytes);
            }

            Context.Stream.Write(Bytes, 0, Bytes.Length);
        }

        /// <summary>Writes an array of <see cref="Int32"/> into the <see cref="Stream"/></summary>
        /// <param name="Context">The Context that holds the stream, buffer, and endianness</param>
        /// <param name="Value">The value to convert and write to <see cref="Stream"/></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteInt32Array(this SerializationContext Context, Int32[] Value) {
            if (Context.Endianness == Endianness.BigEndian) {
                for (Int32 I = 0; I < Value.Length; I++) {
                    BitConverter.BigEndian.OntoBytes(Context.Buffer, Value[I]);
                    Context.Stream.Write(Context.Buffer, 0, sizeof(Int32));
                }
            }
            else {
                for (Int32 I = 0; I < Value.Length; I++) {
                    BitConverter.LittleEndian.OntoBytes(Context.Buffer, Value[I]);
                    Context.Stream.Write(Context.Buffer, 0, sizeof(Int32));
                }
            }
        }

        /// <summary>Writes an array of <see cref="Int64"/> into the <see cref="Stream"/></summary>
        /// <param name="Context">The Context that holds the stream, buffer, and endianness</param>
        /// <param name="Value">The value to convert and write to <see cref="Stream"/></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteInt64Array(this SerializationContext Context, Int64[] Value) {
            if (Context.Endianness == Endianness.BigEndian) {
                for (Int32 I = 0; I < Value.Length; I++) {
                    BitConverter.BigEndian.OntoBytes(Context.Buffer, Value[I]);
                    Context.Stream.Write(Context.Buffer, 0, sizeof(Int64));
                }
            }
            else {
                for (Int32 I = 0; I < Value.Length; I++) {
                     BitConverter.LittleEndian.OntoBytes(Context.Buffer, Value[I]);
                    Context.Stream.Write(Context.Buffer, 0, sizeof(Int64));
                }
            }
        }
    }
}
