﻿namespace DaanV2.NBT;
public static partial class NBTTagFactory {
    /// <summary>Creates a tag with the specified tag type</summary>
    /// <param name="type">The tag type</param>
    /// <returns>Creates a tag with the specified tag type</returns>
    public static ITag? Create(NBTTagType type) {
        Type? t = NBTTagFactory.Typeof(type);
        if (t is null) {
            return null;
        }

        return Activator.CreateInstance(t) as ITag;
    }
    /// <summary>Creates a tag with the specified information</summary>
    /// <param name="type">The tag type</param>
    /// <param name="Name">The name of the tag</param>
    /// <param name="Value">The value of the type</param>
    /// <returns>Creates a tag with the specified tag type</returns>
    public static ITag? Create(NBTTagType type, String Name, Object Value) {
        ITag? Tag = NBTTagFactory.Create(type);

        if (Tag is null) {
            return Tag;
        }

        if (Name is not null) {
            Tag.Name = Name;
        }

        if (Value is not null) {
            Tag.SetValue(Value);
        }

        return Tag;
    }

    /// <summary>Creates an this <see cref="ITag"/> that suits the given information</summary>
    /// <param name="Name">The name of the Tag</param>
    /// <param name="Value">The value of the receiving tag</param>
    /// <returns>Creates an this <see cref="ITag"/> that suits the given information</returns>
    public static ITag? Create(String Name, Boolean Value) {
        ITag? Out = NBTTagFactory.Create(NBTTagType.Byte);
        if (Out is null) {
            return Out;
        }

        Out.Name = Name;
        Out.SetInformation(NBTTagInformation.Value, (Byte)(Value ? 1 : 0));

        return Out;
    }

    /// <summary>Creates an this <see cref="ITag"/> that suits the given information</summary>
    /// <param name="Name">The name of the Tag</param>
    /// <param name="Value">The value of the receiving tag</param>
    /// <returns>Creates an this <see cref="ITag"/> that suits the given information</returns>
    public static ITag? Create(String Name, Byte Value) {
        ITag? Out = NBTTagFactory.Create(NBTTagType.Byte);
        if (Out is null) {
            return Out;
        }

        Out.Name = Name;
        Out.SetInformation(NBTTagInformation.Value, Value);

        return Out;
    }

    /// <summary>Creates an this <see cref="ITag"/> that suits the given information</summary>
    /// <param name="Name">The name of the Tag</param>
    /// <param name="Value">The value of the receiving tag</param>
    /// <returns>Creates an this <see cref="ITag"/> that suits the given information</returns>
    public static ITag? Create(String Name, Double Value) {
        ITag? Out = NBTTagFactory.Create(NBTTagType.Double);
        if (Out is null) {
            return Out;
        }

        Out.Name = Name;
        Out.SetInformation(NBTTagInformation.Value, Value);

        return Out;
    }

    /// <summary>Creates an this <see cref="ITag"/> that suits the given information</summary>
    /// <param name="Name">The name of the Tag</param>
    /// <param name="Value">The value of the receiving tag</param>
    /// <returns>Creates an this <see cref="ITag"/> that suits the given information</returns>
    public static ITag? Create(String Name, Single Value) {
        ITag? Out = NBTTagFactory.Create(NBTTagType.Float);
        if (Out is null) {
            return Out;
        }

        Out.Name = Name;
        Out.SetInformation(NBTTagInformation.Value, Value);

        return Out;
    }

    /// <summary>Creates an this <see cref="ITag"/> that suits the given information</summary>
    /// <param name="Name">The name of the Tag</param>
    /// <param name="Value">The value of the receiving tag</param>
    /// <returns>Creates an this <see cref="ITag"/> that suits the given information</returns>
    public static ITag? Create(String Name, Int32 Value) {
        ITag? Out = NBTTagFactory.Create(NBTTagType.Int);
        if (Out is null) {
            return Out;
        }

        Out.Name = Name;
        Out.SetInformation(NBTTagInformation.Value, Value);

        return Out;
    }

    /// <summary>Creates an this <see cref="ITag"/> that suits the given information</summary>
    /// <param name="Name">The name of the Tag</param>
    /// <param name="Value">The value of the receiving tag</param>
    /// <returns>Creates an this <see cref="ITag"/> that suits the given information</returns>
    public static ITag? Create(String Name, Int32[] Value) {
        ITag? Out = NBTTagFactory.Create(NBTTagType.IntArray);
        if (Out is null) {
            return Out;
        }

        Out.Name = Name;
        Out.SetInformation(NBTTagInformation.Value, Value);

        return Out;
    }

    /// <summary>Creates an this <see cref="ITag"/> that suits the given information</summary>
    /// <param name="Name">The name of the Tag</param>
    /// <param name="Value">The value of the receiving tag</param>
    /// <returns>Creates an this <see cref="ITag"/> that suits the given information</returns>
    public static ITag? Create(String Name, Int64 Value) {
        ITag? Out = NBTTagFactory.Create(NBTTagType.Long);
        if (Out is null) {
            return Out;
        }

        Out.Name = Name;
        Out.SetInformation(NBTTagInformation.Value, Value);

        return Out;
    }

    /// <summary>Creates an this <see cref="ITag"/> that suits the given information</summary>
    /// <param name="Name">The name of the Tag</param>
    /// <param name="Value">The value of the receiving tag</param>
    /// <returns>Creates an this <see cref="ITag"/> that suits the given information</returns>
    public static ITag? Create(String Name, Int64[] Value) {
        ITag? Out = NBTTagFactory.Create(NBTTagType.LongArray);
        if (Out is null) {
            return Out;
        }

        Out.Name = Name;
        Out.SetInformation(NBTTagInformation.Value, Value);

        return Out;
    }

    /// <summary>Creates an this <see cref="ITag"/> that suits the given information</summary>
    /// <param name="Name">The name of the Tag</param>
    /// <param name="Value">The value of the receiving tag</param>
    /// <returns>Creates an this <see cref="ITag"/> that suits the given information</returns>
    public static ITag? Create(String Name, Int16 Value) {
        ITag? Out = NBTTagFactory.Create(NBTTagType.Short);
        if (Out is null) {
            return Out;
        }

        Out.Name = Name;
        Out.SetInformation(NBTTagInformation.Value, Value);

        return Out;
    }

    /// <summary>Creates an this <see cref="ITag"/> that suits the given information</summary>
    /// <param name="Name">The name of the Tag</param>
    /// <param name="Value">The value of the receiving tag</param>
    /// <returns>Creates an this <see cref="ITag"/> that suits the given information</returns>
    public static ITag? Create(String Name, String Value) {
        ITag? Out = NBTTagFactory.Create(NBTTagType.String);
        if (Out is null) {
            return Out;
        }

        Out.Name = Name;
        Out.SetInformation(NBTTagInformation.Value, Value);

        return Out;
    }
}
