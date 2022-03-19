﻿/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.Runtime.CompilerServices;
using DaanV2.Binary;

namespace DaanV2.NBT.Serialization {
    public static partial class SerializationContextExtension {
        /// <summary>Reads the amount of specified bytes from stream and stores them in an array</summary>
        /// <param name="Context">The context to use to read</param>
        /// <param name="Length">The amount of bytes to read from</param>
        /// <returns>Reads the amount of specified bytes from stream and stores them in an array</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte[] ReadBytes(this SerializationContext Context, Int32 Length) {
            Byte[] Buffer = new Byte[Length];
            Context.Stream.Read(Buffer, 0, Length);

            return Buffer;
        }

        /// <summary>Reads an <see cref="Int16"/> from the given information</summary>
        /// <param name="Context">The context to use to read</param>
        /// <returns>Reads an <see cref="Int16"/> from the given information</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 ReadInt16(this SerializationContext Context) {
            Span<Byte> Buffer = stackalloc Byte[sizeof(Int16)];
            Context.Stream.Read(Buffer);
            return Binary.BitConverter.Endian.ToInt16(Buffer, Context.Endianness);
        }

        /// <summary>Reads an <see cref="Int32"/> from the given information</summary>
        /// <param name="Context">The context to use to read</param>
        /// <returns>Reads an <see cref="Int32"/> from the given information</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 ReadInt32(this SerializationContext Context) {
            Span<Byte> Buffer = stackalloc Byte[sizeof(Int32)];
            Context.Stream.Read(Buffer);
            return Binary.BitConverter.Endian.ToInt32(Buffer, Context.Endianness);
        }

        /// <summary>Reads an <see cref="Int64"/> from the given information</summary>
        /// <param name="Context">The context to use to read</param>
        /// <returns>Reads an <see cref="Int64"/> from the given information</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 ReadInt64(this SerializationContext Context) {
            Span<Byte> Buffer = stackalloc Byte[sizeof(Int64)];
            Context.Stream.Read(Buffer);
            return Binary.BitConverter.Endian.ToInt64(Buffer, Context.Endianness);
        }

        /// <summary>Reads an <see cref="UInt16"/> from the given information</summary>
        /// <param name="Context">The context to use to read</param>
        /// <returns>Reads an <see cref="UInt16"/> from the given information</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 ReadUInt16(this SerializationContext Context) {
            Span<Byte> Buffer = stackalloc Byte[sizeof(UInt16)];
            Context.Stream.Read(Buffer);
            return Binary.BitConverter.Endian.ToUInt16(Buffer, Context.Endianness);
        }

        /// <summary>Reads an <see cref="UInt32"/> from the given information</summary>
        /// <param name="Context">The context to use to read</param>
        /// <returns>Reads an <see cref="UInt32"/> from the given information</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 ReadUInt32(this SerializationContext Context) {
            Span<Byte> Buffer = stackalloc Byte[sizeof(UInt32)];
            Context.Stream.Read(Buffer);
            return Binary.BitConverter.Endian.ToUInt32(Buffer, Context.Endianness);
        }

        /// <summary>Reads an <see cref="UInt64"/> from the given information</summary>
        /// <param name="Context">The context to use to read</param>
        /// <returns>Reads an <see cref="UInt64"/> from the given information</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 ReadUInt64(this SerializationContext Context) {
            Span<Byte> Buffer = stackalloc Byte[sizeof(UInt64)];
            Context.Stream.Read(Buffer);
            return Binary.BitConverter.Endian.ToUInt64(Buffer, Context.Endianness);
        }

        /// <summary>Reads an <see cref="Single"/> from the given information</summary>
        /// <param name="Context">The context to use to read</param>
        /// <returns>Reads an <see cref="Single"/> from the given information</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single ReadFloat(this SerializationContext Context) {
            Span<Byte> Buffer = stackalloc Byte[sizeof(Single)];
            Context.Stream.Read(Buffer);

            if (System.BitConverter.IsLittleEndian != (Context.Endianness == Endianness.LittleEndian)) {
                MemoryExtensions.Reverse(Buffer);
            }

            return System.BitConverter.ToSingle(Buffer);
        }

        /// <summary>Reads an <see cref="Double"/> from the given information</summary>
        /// <param name="Context">The context to use to read</param>
        /// <returns>Reads an <see cref="Double"/> from the given information</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double ReadDouble(this SerializationContext Context) {
            Span<Byte> Buffer = stackalloc Byte[sizeof(Double)];
            Context.Stream.Read(Buffer);

            if (System.BitConverter.IsLittleEndian != (Context.Endianness == Endianness.LittleEndian)) {
                MemoryExtensions.Reverse(Buffer);
            }

            return System.BitConverter.ToDouble(Buffer);
        }

        /// <summary>Reads an <see cref="Int32"/>[] from the given information</summary>
        /// <param name="Context">The context to use to read</param>
        /// <param name="Length">The amount to read</param>
        /// <returns>Reads an <see cref="Int32"/>[] from the given information</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32[] ReadInt32Array(this SerializationContext Context, Int32 Length) {
            Endianness endianness = Context.Endianness;
            Span<Byte> Buffer = stackalloc Byte[sizeof(Int32)];
            Int32[] Out = new Int32[Length];

            if (endianness == Endianness.BigEndian) {
                for (Int32 I = 0; I < Length; I++) {
                    Context.Stream.Read(Buffer);
                    Out[I] = Binary.BitConverter.BigEndian.ToInt32(Buffer);
                }
            }
            else {
                for (Int32 I = 0; I < Length; I++) {
                    Context.Stream.Read(Buffer);
                    Out[I] = Binary.BitConverter.LittleEndian.ToInt32(Buffer);
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
            Endianness endianness = Context.Endianness;
            Span<Byte> Buffer = stackalloc Byte[sizeof(Int32)];
            Int64[] Out = new Int64[Length];

            if (endianness == Endianness.BigEndian) {
                for (Int32 I = 0; I < Length; I++) {
                    Context.Stream.Read(Buffer);
                    Out[I] = Binary.BitConverter.BigEndian.ToInt64(Buffer);
                }
            }
            else {
                for (Int32 I = 0; I < Length; I++) {
                    Context.Stream.Read(Buffer);
                    Out[I] = Binary.BitConverter.LittleEndian.ToInt64(Buffer);
                }
            }

            return Out;
        }
    }
}
