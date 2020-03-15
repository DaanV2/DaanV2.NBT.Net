/*ISC License

Copyright (c) 2019, Daan Verstraten, daanverstraten@hotmail.com

Permission to use, copy, modify, and/or distribute this software for any
purpose with or without fee is hereby granted, provided that the above
copyright notice and this permission notice appear in all copies.

THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF
OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.*/

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DaanV2.NBT.Serialization;

namespace DaanV2.NBT.Serialization {
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
}
