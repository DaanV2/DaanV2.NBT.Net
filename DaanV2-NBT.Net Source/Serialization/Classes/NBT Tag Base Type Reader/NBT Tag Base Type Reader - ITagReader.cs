using System;
using System.IO;
using DaanV2.Binary;
using DaanV2.IO;

namespace DaanV2.NBT.Serialization.Serialization {
    ///DOLATER <summary> add description for class: NBTTagBaseTypeReader</summary>
    internal partial class NBTTagBaseTypeReader : ITagReader {
        /// <summary>Gets the type for which this object can read</summary>
        private static readonly NBTTagType[] _ForType = new NBTTagType[] {
            NBTTagType.ByteArray,
            NBTTagType.IntArray,
            NBTTagType.LongArray,
            NBTTagType.Byte,
            NBTTagType.Short,
            NBTTagType.Int,
            NBTTagType.Long,
            NBTTagType.Double,
            NBTTagType.Float,
            NBTTagType.String,
            NBTTagType.End
        };

        /// <summary>Gets the type for which this object can read</summary>
        internal NBTTagType[] ForType => _ForType;

        /// <summary>Reads the nbt's content from the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to read from the <see cref="Stream"/></param>
        /// <param name="Writer">The <see cref="Stream"/> to read from</param>
        internal void ReadContent(ITag tag, Stream Reader, Endianness endianness) {
            Int32 Length;

            switch (tag.Type) {
                //Arrays
                case NBTTagType.ByteArray:
                    Length = Reader.ReadInt32(endianness);
                    tag.SetValue(Reader.ReadBytes(Length));
                    return;

                case NBTTagType.IntArray:
                    Length = Reader.ReadInt32(endianness);
                    tag.SetValue(Reader.ReadInt32Array(Length, endianness));
                    return;

                case NBTTagType.LongArray:
                    Length = Reader.ReadInt32(endianness);
                    tag.SetValue(Reader.ReadInt64Array(Length, endianness));
                    return;

                //Values
                case NBTTagType.Byte:
                    tag.SetValue((Byte)Reader.ReadByte());
                    return;

                case NBTTagType.Short:
                    tag.SetValue(Reader.ReadInt16(endianness));
                    return;

                case NBTTagType.Int:
                    tag.SetValue(Reader.ReadInt32(endianness));
                    return;

                case NBTTagType.Long:
                    tag.SetValue(Reader.ReadInt64(endianness));
                    return;

                case NBTTagType.Double:
                    tag.SetValue(Reader.ReadDouble(endianness));
                    return;

                case NBTTagType.Float:
                    tag.SetValue(Reader.ReadFloat(endianness));
                    return;

                case NBTTagType.String:
                    tag.SetValue(NBTReader.ReadString(Reader, endianness));
                    return;
                case NBTTagType.Unknown:
                case NBTTagType.End:
                default:
                    return;
            }
        }

        /// <summary>Reads the nbt's header from the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to read from the <see cref="Stream"/></param>
        /// <param name="Reader">The <see cref="Stream"/> to read from</param>
        internal void ReadHeader(ITag tag, Stream Reader, Endianness endianness) {
            tag.Name = NBTReader.ReadString(Reader, endianness);
        }
    }
}
