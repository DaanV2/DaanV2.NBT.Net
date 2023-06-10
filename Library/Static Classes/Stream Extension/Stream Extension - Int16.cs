/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System.Runtime.CompilerServices;


namespace DaanV2.NBT;
/// <summary>The static class that extends upon the default streams</summary>
public static partial class StreamExtension {
    /// <summary>Writes an <see cref="Int16"/> into the <see cref="Stream"/></summary>
    /// <param name="Stream">The stream to write to</param>
    /// <param name="Value">The value to convert and write to <see cref="Stream"/></param>
    /// <param name="Endian">The endiannness of the data</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void WriteInt16(this Stream Stream, Int16 Value, Endian Endian) {
        Span<Byte> buffer = stackalloc Byte[sizeof(Int16)];
        Binary.OntoBytes(buffer, Value, Endian);
        Stream.Write(buffer);
    }
}
