namespace DaanV2.NBT;
public static partial class NBTTagFactory {
    /// <summary>Creates the specified list as a tag</summary>
    /// <param name="Name">The name of the list</param>
    /// <param name="SubType">The subtype to fill</param>
    /// <returns>Creates the specified list as a tag</returns>
    private static (ITag List, Type SubType) CreateList(String Name, NBTTagType SubType) {
        ITag? Out = NBTTagFactory.Create(NBTTagType.List);
        Type? TagType = NBTTagFactory.Typeof(SubType);
        if (Out is null) {
            return (Out, TagType);
        }

        Out.Name = Name;
        Out.SetInformation(NBTTagInformation.ListSubtype, SubType);

        return (Out, TagType);
    }

    /// <summary>Transfers a list of items into a tag as sub tag intems</summary>
    /// <typeparam name="T">The type of items to transfer</typeparam>
    /// <param name="List">The tag to receive the new sub tags</param>
    /// <param name="SubType">The sub tag type, must implement this <see cref="ITag"/></param>
    /// <param name="Source">The source of items to transfer</param>
    private static void Transfer<T>(ITag List, Type SubType, List<T> Source) {
        Int32 Count = Source.Count;
        ITag child;

        for (Int32 I = 0; I < Count; I++) {
            child = (ITag)Activator.CreateInstance(SubType);
            child.SetValue(Source[I]);
            List.Add(child);
        }
    }

    /// <summary>Creates an this <see cref="ITag"/> that suits the given information</summary>
    /// <param name="Name">The name of the Tag</param>
    /// <param name="Value">The value of the receiving tag</param>
    /// <returns>Creates an this <see cref="ITag"/> that suits the given information</returns>
    public static ITag Create(String Name, List<Boolean> Value) {
        (ITag Out, Type TagType) = NBTTagFactory.CreateList(Name, NBTTagType.Byte);
        Int32 Count = Value.Count;
        ITag child;

        for (Int32 I = 0; I < Count; I++) {
            child = (ITag)Activator.CreateInstance(TagType);
            child.SetValue((Byte)(Value[I] ? 1 : 0));
            Out.Add(child);
        }
        return Out;
    }

    /// <summary>Creates an this <see cref="ITag"/> that suits the given information</summary>
    /// <param name="Name">The name of the Tag</param>
    /// <param name="Value">The value of the receiving tag</param>
    /// <returns>Creates an this <see cref="ITag"/> that suits the given information</returns>
    public static ITag Create(String Name, List<Byte> Value) {
        (ITag Out, Type TagType) = NBTTagFactory.CreateList(Name, NBTTagType.Byte);
        NBTTagFactory.Transfer(Out, TagType, Value);
        return Out;
    }

    /// <summary>Creates an this <see cref="ITag"/> that suits the given information</summary>
    /// <param name="Name">The name of the Tag</param>
    /// <param name="Value">The value of the receiving tag</param>
    /// <returns>Creates an this <see cref="ITag"/> that suits the given information</returns>
    public static ITag Create(String Name, List<Double> Value) {
        (ITag Out, Type TagType) = NBTTagFactory.CreateList(Name, NBTTagType.Double);
        NBTTagFactory.Transfer(Out, TagType, Value);
        return Out;
    }

    /// <summary>Creates an this <see cref="ITag"/> that suits the given information</summary>
    /// <param name="Name">The name of the Tag</param>
    /// <param name="Value">The value of the receiving tag</param>
    /// <returns>Creates an this <see cref="ITag"/> that suits the given information</returns>
    public static ITag Create(String Name, List<Single> Value) {
        (ITag Out, Type TagType) = NBTTagFactory.CreateList(Name, NBTTagType.Float);
        NBTTagFactory.Transfer(Out, TagType, Value);
        return Out;
    }

    /// <summary>Creates an this <see cref="ITag"/> that suits the given information</summary>
    /// <param name="Name">The name of the Tag</param>
    /// <param name="Value">The value of the receiving tag</param>
    /// <returns>Creates an this <see cref="ITag"/> that suits the given information</returns>
    public static ITag Create(String Name, List<Int32> Value) {
        (ITag Out, Type TagType) = NBTTagFactory.CreateList(Name, NBTTagType.Int);
        NBTTagFactory.Transfer(Out, TagType, Value);
        return Out;
    }

    /// <summary>Creates an this <see cref="ITag"/> that suits the given information</summary>
    /// <param name="Name">The name of the Tag</param>
    /// <param name="Value">The value of the receiving tag</param>
    /// <returns>Creates an this <see cref="ITag"/> that suits the given information</returns>
    public static ITag Create(String Name, List<Int64> Value) {
        (ITag Out, Type TagType) = NBTTagFactory.CreateList(Name, NBTTagType.Long);
        NBTTagFactory.Transfer(Out, TagType, Value);
        return Out;
    }

    /// <summary>Creates an this <see cref="ITag"/> that suits the given information</summary>
    /// <param name="Name">The name of the Tag</param>
    /// <param name="Value">The value of the receiving tag</param>
    /// <returns>Creates an this <see cref="ITag"/> that suits the given information</returns>
    public static ITag Create(String Name, List<Int16> Value) {
        (ITag Out, Type TagType) = NBTTagFactory.CreateList(Name, NBTTagType.Short);
        NBTTagFactory.Transfer(Out, TagType, Value);
        return Out;
    }

    /// <summary>Creates an this <see cref="ITag"/> that suits the given information</summary>
    /// <param name="Name">The name of the Tag</param>
    /// <param name="Value">The value of the receiving tag</param>
    /// <returns>Creates an this <see cref="ITag"/> that suits the given information</returns>
    public static ITag Create(String Name, List<String> Value) {
        (ITag Out, Type TagType) = NBTTagFactory.CreateList(Name, NBTTagType.String);
        NBTTagFactory.Transfer(Out, TagType, Value);
        return Out;
    }
}
