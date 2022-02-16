/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;

namespace DaanV2.NBT {
    public static partial class NBTTagFactory {
        /// <summary>Creates a tag with the specified tag type</summary>
        /// <param name="type">The tag type</param>
        /// <returns>Creates a tag with the specified tag type</returns>
        public static ITag Create(NBTTagType type) {
            return NBTTagFactory.Types.ContainsKey(type) ?
                (ITag)Activator.CreateInstance(Types[type]) :
                null;
        }
        /// <summary>Creates a tag with the specified information</summary>
        /// <param name="type">The tag type</param>
        /// <param name="Name">The name of the tag</param>
        /// <param name="Value">The value of the type</param>
        /// <returns>Creates a tag with the specified tag type</returns>
        public static ITag Create(NBTTagType type, String Name, Object Value) {
            ITag Tag = NBTTagFactory.Create(type);

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
        public static ITag Create(String Name, Boolean Value) {
            ITag Out = NBTTagFactory.Create(NBTTagType.Byte);

            Out.Name = Name;
            Out.SetInformation(NBTTagInformation.Value, (Byte)(Value ? 1 : 0));

            return Out;
        }

        /// <summary>Creates an this <see cref="ITag"/> that suits the given information</summary>
        /// <param name="Name">The name of the Tag</param>
        /// <param name="Value">The value of the receiving tag</param>
        /// <returns>Creates an this <see cref="ITag"/> that suits the given information</returns>
        public static ITag Create(String Name, Byte Value) {
            ITag Out = NBTTagFactory.Create(NBTTagType.Byte);

            Out.Name = Name;
            Out.SetInformation(NBTTagInformation.Value, Value);

            return Out;
        }

        /// <summary>Creates an this <see cref="ITag"/> that suits the given information</summary>
        /// <param name="Name">The name of the Tag</param>
        /// <param name="Value">The value of the receiving tag</param>
        /// <returns>Creates an this <see cref="ITag"/> that suits the given information</returns>
        public static ITag Create(String Name, Double Value) {
            ITag Out = NBTTagFactory.Create(NBTTagType.Double);

            Out.Name = Name;
            Out.SetInformation(NBTTagInformation.Value, Value);

            return Out;
        }

        /// <summary>Creates an this <see cref="ITag"/> that suits the given information</summary>
        /// <param name="Name">The name of the Tag</param>
        /// <param name="Value">The value of the receiving tag</param>
        /// <returns>Creates an this <see cref="ITag"/> that suits the given information</returns>
        public static ITag Create(String Name, Single Value) {
            ITag Out = NBTTagFactory.Create(NBTTagType.Float);

            Out.Name = Name;
            Out.SetInformation(NBTTagInformation.Value, Value);

            return Out;
        }

        /// <summary>Creates an this <see cref="ITag"/> that suits the given information</summary>
        /// <param name="Name">The name of the Tag</param>
        /// <param name="Value">The value of the receiving tag</param>
        /// <returns>Creates an this <see cref="ITag"/> that suits the given information</returns>
        public static ITag Create(String Name, Int32 Value) {
            ITag Out = NBTTagFactory.Create(NBTTagType.Int);

            Out.Name = Name;
            Out.SetInformation(NBTTagInformation.Value, Value);

            return Out;
        }

        /// <summary>Creates an this <see cref="ITag"/> that suits the given information</summary>
        /// <param name="Name">The name of the Tag</param>
        /// <param name="Value">The value of the receiving tag</param>
        /// <returns>Creates an this <see cref="ITag"/> that suits the given information</returns>
        public static ITag Create(String Name, Int32[] Value) {
            ITag Out = NBTTagFactory.Create(NBTTagType.IntArray);

            Out.Name = Name;
            Out.SetInformation(NBTTagInformation.Value, Value);

            return Out;
        }

        /// <summary>Creates an this <see cref="ITag"/> that suits the given information</summary>
        /// <param name="Name">The name of the Tag</param>
        /// <param name="Value">The value of the receiving tag</param>
        /// <returns>Creates an this <see cref="ITag"/> that suits the given information</returns>
        public static ITag Create(String Name, Int64 Value) {
            ITag Out = NBTTagFactory.Create(NBTTagType.Long);

            Out.Name = Name;
            Out.SetInformation(NBTTagInformation.Value, Value);

            return Out;
        }

        /// <summary>Creates an this <see cref="ITag"/> that suits the given information</summary>
        /// <param name="Name">The name of the Tag</param>
        /// <param name="Value">The value of the receiving tag</param>
        /// <returns>Creates an this <see cref="ITag"/> that suits the given information</returns>
        public static ITag Create(String Name, Int64[] Value) {
            ITag Out = NBTTagFactory.Create(NBTTagType.LongArray);

            Out.Name = Name;
            Out.SetInformation(NBTTagInformation.Value, Value);

            return Out;
        }

        /// <summary>Creates an this <see cref="ITag"/> that suits the given information</summary>
        /// <param name="Name">The name of the Tag</param>
        /// <param name="Value">The value of the receiving tag</param>
        /// <returns>Creates an this <see cref="ITag"/> that suits the given information</returns>
        public static ITag Create(String Name, Int16 Value) {
            ITag Out = NBTTagFactory.Create(NBTTagType.Short);

            Out.Name = Name;
            Out.SetInformation(NBTTagInformation.Value, Value);

            return Out;
        }

        /// <summary>Creates an this <see cref="ITag"/> that suits the given information</summary>
        /// <param name="Name">The name of the Tag</param>
        /// <param name="Value">The value of the receiving tag</param>
        /// <returns>Creates an this <see cref="ITag"/> that suits the given information</returns>
        public static ITag Create(String Name, String Value) {
            ITag Out = NBTTagFactory.Create(NBTTagType.String);

            Out.Name = Name;
            Out.SetInformation(NBTTagInformation.Value, Value);

            return Out;
        }
    }
}
