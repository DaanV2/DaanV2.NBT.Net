﻿/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using DaanV2.Binary;

namespace DaanV2.NBT.Serialization {
    public static partial class NBTReader {
        /// <summary>Read a string from the given stream</summary>
        /// <param name="Reader">The stream to read from</param>
        /// <param name="endianness">The endianness of the NBT structure</param>
        /// <returns>Read a string from the given stream</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static String ReadString(Stream Reader, Endianness endianness) {
            Byte[] Data = new Byte[2];

            Reader.Read(Data, 0, Data.Length);
            Int32 Length = Binary.BitConverter.Endian.ToInt16(Data, endianness);

            if (Length == 0) { return String.Empty; }

            return Encoding.UTF8.GetString(Reader.ReadBytes(Length));
        }

        /// <summary>Read a string from the given context</summary>
        /// <param name="Context">The context to read from</param>
        /// <returns>Read a string from the given context</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static String ReadString(SerializationContext Context) {
            Int32 Length = Context.ReadInt16();

            if (Length == 0) { return String.Empty; }

            return Encoding.UTF8.GetString(Context.ReadBytes(Length));
        }
    }
}