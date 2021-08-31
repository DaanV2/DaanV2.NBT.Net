/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.IO;
using System.Runtime.CompilerServices;
using DaanV2.Binary;

namespace DaanV2.NBT {
    /// <summary>The static class that extends upon the default streams</summary>
    public static partial class StreamExtension {
        /// <summary>Writes an <see cref="Int16"/> into the <see cref="Stream"/></summary>
        /// <param name="Stream">The stream to write to</param>
        /// <param name="Value">The value to convert and write to <see cref="Stream"/></param>
        /// <param name="Endianness">The endiannness of the data</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteInt16(this Stream Stream, Int16 Value, Endianness Endianness) {
            Byte[] Buffer = DaanV2.Binary.BitConverter.Endian.ToBytes(Value, Endianness);
            Stream.Write(Buffer, 0, Buffer.Length);
        }
    }
}
