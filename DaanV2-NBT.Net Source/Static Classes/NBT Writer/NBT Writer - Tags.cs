using System;
using System.IO;
using DaanV2.NBT.Serialization;

namespace DaanV2.NBT {
    public static partial class NBTWriter {
        ///DOLATER <summary>Add Description</summary>
        /// <param name=""></param>
        /// <param name="stream"></param>
        public static void Write(ITag tag, Stream stream) {
            ITagWriter Writer;
            NBTWriter._Writers.TryGetValue(tag.Type, out Writer);

            if (Writer == null) {
                throw new Exception($"No ITagWriter found for: {tag.Type}");
            }

            Writer.WriteHeader(tag, stream);
            Writer.WriteContent(tag, stream);
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="tag"></param>
        /// <param name="stream"></param>
        public static void WriteHeader(ITag tag, Stream stream) {
            ITagWriter Writer;
            NBTWriter._Writers.TryGetValue(tag.Type, out Writer);

            if (Writer == null) {
                throw new Exception($"No ITagWriter found for: {tag.Type}");
            }

            Writer.WriteHeader(tag, stream);
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="tag"></param>
        /// <param name="stream"></param>
        public static void WriteContent(ITag tag, Stream stream) {
            ITagWriter Writer;
            NBTWriter._Writers.TryGetValue(tag.Type, out Writer);

            if (Writer == null) {
                throw new Exception($"No ITagWriter found for: {tag.Type}");
            }

            Writer.WriteContent(tag, stream);
        }
    }
}
