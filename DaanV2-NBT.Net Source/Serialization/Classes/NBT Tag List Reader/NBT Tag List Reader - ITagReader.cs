using System;
using System.IO;

namespace DaanV2.NBT.Serialization.Serialization {
    /// <summary>The class that read an nbt tag list from the stream</summary>
    internal partial class NBTTagListReader : ITagReader {
        /// <summary>Gets the type for which this object can read</summary>
        private static readonly NBTTagType[] _ForType = new NBTTagType[] { NBTTagType.List };

        /// <summary>Gets the type for which this object can read</summary>
        public NBTTagType[] ForType => _ForType;

        /// <summary>Reads the nbt's content from the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to read from the <see cref="Stream"/></param>
        /// <param name="Context">The context to read from</param>
        public void ReadContent(ITag tag, SerializationContext Context) {
            ITag SubTag;
            Object O = tag.GetInformation(NBTTagInformation.ListSubtype);
            if (O == null) {
                throw new Exception("List returned no subtype");
            }

            NBTTagType SubTagType = (NBTTagType)O;
            ITagReader Reader = NBTReader.GetReader(SubTagType);

            if (Reader == null)
                throw new Exception($"No reader for type: {SubTagType}");

            for (Int32 I = 0; I < tag.Count; I++) {
                SubTag = NBTTagFactory.Create(SubTagType);
                tag[I] = SubTag;
                Reader.ReadContent(SubTag, Context);
            }
        }

        /// <summary>Reads the nbt's header from the <see cref="Stream"/></summary>
        /// <param name="tag">The tag to read from the <see cref="Stream"/></param>
        /// <param name="Context">The context to read from</param>
        public void ReadHeader(ITag tag, SerializationContext Context) {
            tag.Name = NBTReader.ReadString(Context);
            //Read subtype
            tag.SetInformation(NBTTagInformation.ListSubtype, (NBTTagType)Context.Stream.ReadByte());

            //Read size
            tag.SetInformation(NBTTagInformation.ListSize, Context.ReadInt32());
        }
    }
}
