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
using System;

namespace DaanV2.NBT.Serialization {
    /// <summary>The class that extends upon the <see cref="SerializationContext"/></summary>
    public static partial class SerializationContextExtension {
        /// <summary>Returns the amount of bytes a <see cref="Byte"/> uses</summary>
        public const Int32 ByteSize = sizeof(Byte);

        /// <summary>Returns the amount of bytes a <see cref="Int16"/> uses</summary>
        public const Int32 Int16Size = sizeof(Int16);

        /// <summary>Returns the amount of bytes a <see cref="Int32"/> uses</summary>
        public const Int32 Int32Size = sizeof(Int32);

        /// <summary>Returns the amount of bytes a <see cref="Int64"/> uses</summary>
        public const Int32 Int64Size = sizeof(Int64);

        /// <summary>Returns the amount of bytes a <see cref="SByte"/> uses</summary>
        public const Int32 sByteSize = sizeof(SByte);

        /// <summary>Returns the amount of bytes a <see cref="UInt16"/> uses</summary>
        public const Int32 UInt16Size = sizeof(UInt16);

        /// <summary>Returns the amount of bytes a <see cref="UInt32"/> uses</summary>
        public const Int32 UInt32Size = sizeof(UInt32);

        /// <summary>Returns the amount of bytes a <see cref="UInt64"/> uses</summary>
        public const Int32 UInt64Size = sizeof(UInt64);

        /// <summary>Returns the amount of bytes a <see cref="Single"/> uses</summary>
        public const Int32 SingleSize = sizeof(Single);

        /// <summary>Returns the amount of bytes a <see cref="Double"/> uses</summary>
        public const Int32 DoubleSize = sizeof(Double);
    }
}
