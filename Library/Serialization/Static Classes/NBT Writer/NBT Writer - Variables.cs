using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace DaanV2.NBT.Serialization; 
public static partial class NBTWriter {
    /// <summary>The dictionary of writers</summary>
    private static Dictionary<NBTTagType, ITagWriter> _Writers;

    /// <summary>Tries to get a writer from the given type, if nothing found null is returned</summary>
    /// <param name="Type">The type to get a writer for</param>
    /// <returns>Tries to get a writer from the given type, if nothing found null is returned</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ITagWriter GetWriter(NBTTagType Type) {
        if (_Writers.TryGetValue(Type, out ITagWriter Writer)) {
            return Writer;
        }

        return null;
    }
}
