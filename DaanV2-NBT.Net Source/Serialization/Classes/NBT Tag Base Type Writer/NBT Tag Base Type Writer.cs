using System;
using System.IO;
using DaanV2.Binary;

namespace DaanV2.NBT.Serialization.Serialization {
    ///DOLATER <summary> add description for class: NBTTagBaseTypeWriter</summary>
    internal partial class NBTTagBaseTypeWriter : ITagWriter {
        /// <summary>Gets the type for which this object can write</summary>
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

        /// <summary>Writes the nbt's header to the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to write to the <see cref="Stream"/></param>
        /// <param name="Writer">The <see cref="Stream"/> to write to</param>
        internal void WriteHeader(ITag tag, Stream Writer, Endianness endianness) {
            Writer.WriteByte((Byte)tag.Type);
            NBTWriter.WriteString(Writer, tag.Name, endianness);
        }

        /// <summary>Writes the nbt's content to the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to write to the <see cref="Stream"/></param>
        /// <param name="Writer">The <see cref="Stream"/> to write to</param>
        internal void WriteContent(ITag tag, Stream Writer, Endianness endianness) {
            switch (tag.Type) {
                //Arrays
                case NBTTagType.ByteArray:
                    Byte[] Bytes = tag.GetValue<Byte[]>();
                    Writer.WriteInt32(Bytes.Length, endianness);
                    Writer.WriteBytes(Bytes);

                    return;
                case NBTTagType.IntArray:
                    Int32[] Ints = tag.GetValue<Int32[]>();
                    Writer.WriteInt32(Ints.Length, endianness);
                    Writer.WriteInt32Array(Ints, endianness);

                    return;
                case NBTTagType.LongArray:
                    Int64[] Longs = tag.GetValue<Int64[]>();
                    Writer.WriteInt32(Longs.Length, endianness);
                    Writer.WriteInt64Array(Longs, endianness);

                    return;

                //Values
                case NBTTagType.Byte:
                    Writer.WriteByte(tag.GetValue<Byte>());
                    return;

                case NBTTagType.Short:
                    Writer.WriteInt16(tag.GetValue<Int16>(), endianness);
                    return;

                case NBTTagType.Int:
                    Writer.WriteInt32(tag.GetValue<Int32>(), endianness);
                    return;

                case NBTTagType.Long:
                    Writer.WriteInt64(tag.GetValue<Int64>(), endianness);
                    return;

                case NBTTagType.Double:
                    Writer.WriteDouble(tag.GetValue<Double>(), endianness);
                    return;

                case NBTTagType.Float:
                    Writer.WriteFloat(tag.GetValue<Single>(), endianness);
                    return;

                case NBTTagType.String:
                    NBTWriter.WriteString(Writer, tag.GetValue<String>(), endianness);

                    return;
                case NBTTagType.End:
                case NBTTagType.Unknown:
                default:
                    return;
            }
        }

        /// <summary>Gets the type for which this object can write</summary>
        internal NBTTagType[] ForType => _ForType;
    }
}
