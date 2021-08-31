/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace DaanV2.NBT {
    public static partial class StreamExtension {
        /// <summary>Reads the amount of specified bytes from the stream</summary>
        /// <param name="stream">The stream to read from</param>
        /// <param name="Amount">The amount of bytes to read</param>
        /// <returns>Reads the amount of specified bytes from the stream</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte[] ReadBytes(this Stream stream, Int32 Amount) {
            Byte[] Out = new Byte[Amount];

            stream.Read(Out, 0, Amount);
            return Out;
        }

        /// <summary>Writes the given byte array into the stream</summary>
        /// <param name="stream">The stream to write into</param>
        /// <param name="Data">The data to write</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteBytes(this Stream stream, Byte[] Data) {
            stream.Write(Data, 0, Data.Length);
        }
    }
}
