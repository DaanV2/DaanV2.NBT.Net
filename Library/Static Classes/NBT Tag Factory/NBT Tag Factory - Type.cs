namespace DaanV2.NBT;
public static partial class NBTTagFactory {
    /// <summary>Returns the type of the specified tag</summary>
    /// <param name="type">The tag type</param>
    /// <returns>A type or null if nothing found</returns>
    public static Type? Typeof(NBTTagType type) {
        switch (type) {
            case NBTTagType.Byte:
                return typeof (NBTTagByte);

            case NBTTagType.ByteArray:
                return typeof (NBTTagByteArray);

            case NBTTagType.Compound:
                return typeof (NBTTagCompound);

            case NBTTagType.Double:
                return typeof (NBTTagDouble);

            case NBTTagType.Float:
                return typeof (NBTTagFloat);

            case NBTTagType.Int:
                return typeof (NBTTagInt);

            case NBTTagType.IntArray:
                return typeof (NBTTagIntArray);

            case NBTTagType.List:
                return typeof (NBTTagList);

            case NBTTagType.Long:
                return typeof (NBTTagLong);

            case NBTTagType.LongArray:
                return typeof (NBTTagLongArray);

            case NBTTagType.Short:
                return typeof (NBTTagShort);

            case NBTTagType.String:
                return typeof (NBTTagString);

            default:
                return null;
        }
    }
}
