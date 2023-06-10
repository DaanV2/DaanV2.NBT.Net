/*ISC License

Copyright (c) 2019, Daan Verstraten */

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace DaanV2.NBT.Serialization; 
public static partial class NBTReader {
    /// <summary>The dictionary of readers</summary>
    private static Dictionary<NBTTagType, ITagReader> _Readers;

    /// <summary>Tries to get a writer from the given type, if nothing found null is returned</summary>
    /// <param name="Type">The type to get a writer for</param>
    /// <returns>Tries to get a writer from the given type, if nothing found null is returned</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ITagReader GetReader(NBTTagType Type) {
        if (_Readers.TryGetValue(Type, out ITagReader Reader)) {
            return Reader;
        }

        return null;
    }
}
