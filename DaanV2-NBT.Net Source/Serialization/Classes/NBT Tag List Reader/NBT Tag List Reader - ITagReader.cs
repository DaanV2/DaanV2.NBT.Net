using System;
using System.IO;

namespace DaanV2.NBT.Serialization {
    /// <summary>
    /// 
    /// </summary>
    public partial class NBTTagListReader : ITagReader {
        /// <summary>Gets the type for which this object can read</summary>
        private static readonly NBTTagType[] _ForType = new NBTTagType[] { NBTTagType.List };

        /// <summary>Gets the type for which this object can read</summary>
        public NBTTagType[] ForType => _ForType;

        /// <summary>Reads the nbt's content from the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to read from the <see cref="Stream"/></param>
        /// <param name="Writer">The <see cref="Stream"/> to read from</param>
        public void ReadContent(ITag tag, Stream Reader) {
            ITag SubTag;
            Object O = tag.GetInformation(NBTTagInformation.ListSubtype);
            if (O == null) {
                throw new Exception("List returned no subtype");
            }

            NBTTagType SubTagType = (NBTTagType)O;

            for (Int32 I = 0; I < tag.Count; I++) {
                SubTag = NBTTagFactory.Create(SubTagType);
                tag[I] = SubTag;
                NBTReader.ReadContent(SubTagType, Reader, SubTag);
            }
        }

        /// <summary>Reads the nbt's header from the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to read from the <see cref="Stream"/></param>
        /// <param name="Writer">The <see cref="Stream"/> to read from</param>
        public void ReadHeader(ITag tag, Stream Reader) {
            tag.Name = NBTReader.ReadString(Reader);
            tag.SetInformation(NBTTagInformation.ListSubtype, (NBTTagType)Reader.ReadByte());
            tag.SetInformation(NBTTagInformation.ListSize, Reader.ReadInt32());
        }
    }
}
