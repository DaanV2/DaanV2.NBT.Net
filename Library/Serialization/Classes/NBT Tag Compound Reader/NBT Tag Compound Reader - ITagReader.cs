namespace DaanV2.NBT.Serialization.Serialization;
/// <summary>The nbt tag compound reader</summary>
internal partial class NBTTagCompoundReader : ITagReader {
    /// <summary>Gets the type for which this object can read</summary>
    private static readonly NBTTagType[] _ForType = new NBTTagType[] { NBTTagType.Compound };

    /// <summary>Gets the type for which this object can read</summary>
    public NBTTagType[] ForType => _ForType;

    /// <summary>Reads the nbt's content from the <see cref="Stream"/></summary>
    /// <param name="tag">The tag to read from the <see cref="Stream"/></param>
    /// <param name="Context">The context that provides a buffer, the stream and Endian of the NBT</param>
    public void ReadContent(ITag tag, SerializationContext Context) {
        try {
            ITag SubTag = NBTReader.Read(Context);

            while (SubTag is not null) {
                tag.Add(SubTag);
                SubTag = NBTReader.Read(Context);
            }
        }
        catch (DeserializationException e) {
            throw new DeserializationException(tag.Name + $"/{e.Name}", e.Type, e.Position, e.InnerException);
        }
        catch (Exception e) {
            throw new DeserializationException(tag.Name, tag.Type, Context.Stream.Position, e);
        }
    }

    /// <summary>Reads the nbt's header from the <see cref="Stream"/></summary>
    /// <param name="tag">The tag to read from the <see cref="Stream"/></param>
    /// <param name="Context">The context that provides a buffer, the stream and Endian of the NBT</param>
    public void ReadHeader(ITag tag, SerializationContext Context) {
        tag.Name = NBTReader.ReadString(Context.Stream, Context.Endian);
    }
}
