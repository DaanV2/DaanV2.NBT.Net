/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.IO.Compression;
using System.Runtime.CompilerServices;

namespace DaanV2.NBT; 

public static partial class StreamExtension {
    /// <summary>Reads a byte from the given Gzip stream</summary>
    /// <param name="stream">The stream to read from</param>
    /// <returns>Reads a byte from the given Gzip stream</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Int32 ReadByte(this GZipStream stream) {
        if (stream.Length < stream.Position) {
            return -1;
        }

        Byte[] Buffer = new Byte[1];
        stream.Read(Buffer, 0, 1);
        return Buffer[0];
    }
}
