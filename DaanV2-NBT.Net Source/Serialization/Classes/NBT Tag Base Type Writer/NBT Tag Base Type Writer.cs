using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.NBT.Serialization {
    ///DOLATER <summary> add description for class: NBTTagBaseTypeWriter</summary>
    public partial class NBTTagBaseTypeWriter : ITagWriter {
        /// <summary>Gets the type for which this object can write</summary>
        static private readonly NBTTagType[] _ForType = new NBTTagType[] {
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
        public void WriteHeader(ITag tag, Stream Writer) {
            Writer.WriteByte((Byte)tag.Type);
            NBTWriter.WriteString(Writer, tag.Name);
        }

        /// <summary>Writes the nbt's content to the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to write to the <see cref="Stream"/></param>
        /// <param name="Writer">The <see cref="Stream"/> to write to</param>
        public void WriteContent(ITag tag, Stream Writer) {
            switch (tag.Type) {
                //Arrays
                case NBTTagType.ByteArray:
                    Byte[] Bytes = tag.GetValue<Byte[]>();
                    Writer.WriteInt32(Bytes.Length);
                    Writer.WriteBytes(Bytes);

                    return;
                case NBTTagType.IntArray:
                    Int32[] Ints = tag.GetValue<Int32[]>();
                    Writer.WriteInt32(Ints.Length);
                    Writer.WriteInt32Array(Ints);

                    return;
                case NBTTagType.LongArray:
                    Int64[] Longs = tag.GetValue<Int64[]>();
                    Writer.WriteInt32(Longs.Length);
                    Writer.WriteInt64Array(Longs);

                    return;

                //Values
                case NBTTagType.Byte:
                    Writer.WriteByte(tag.GetValue<Byte>());
                    return;

                case NBTTagType.Short:
                    Writer.WriteInt16(tag.GetValue<Int16>());
                    return;

                case NBTTagType.Int:
                    Writer.WriteInt32(tag.GetValue<Int32>());
                    return;

                case NBTTagType.Long:
                    Writer.WriteInt64(tag.GetValue<Int64>());
                    return;

                case NBTTagType.Double:
                    Writer.WriteDouble(tag.GetValue<Double>());
                    return;

                case NBTTagType.Float:
                    Writer.WriteFloat(tag.GetValue<Single>());
                    return;

                case NBTTagType.String:
                    NBTWriter.WriteString(Writer, tag.GetValue<String>());

                    return;
                case NBTTagType.End:
                case NBTTagType.Unknown:
                default:
                    return;
            }
        }

        /// <summary>Gets the type for which this object can write</summary>
        public NBTTagType[] ForType => _ForType;
    }
}
