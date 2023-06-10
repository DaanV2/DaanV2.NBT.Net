/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;

namespace DaanV2.NBT; 
/// <summary>The class that is responsible for forming the contract on how Nbt Tag should behave</summary>
public interface ITag : ITagCollection {
    /// <summary>Gets or sets the name of this this <see cref="ITag"/></summary>
    String Name { get; set; }

    /// <summary>Gets the type of this this <see cref="ITag"/></summary>
    NBTTagType Type { get; }

    /// <summary>Gets the value of this this <see cref="ITag"/></summary>
    /// <returns>Gets the value of this this <see cref="ITag"/></returns>
    Object GetValue();

    /// <summary>Converts the value of this this <see cref="ITag"/> to the specified type</summary>
    /// <typeparam name="T">The type to convert to</typeparam>
    /// <returns>Converts the value of this this <see cref="ITag"/> to the specified type</returns>
    T GetValue<T>();

    /// <summary>Converts the value of this this <see cref="ITag"/> to the specified type</summary>
    /// <typeparam name="T">The type to convert to</typeparam>
    /// <returns>Converts the value of this this <see cref="ITag"/> to the specified type</returns>
    T ConvertValue<T>();

    /// <summary>Sets the value of this this <see cref="ITag"/> with the given value</summary>
    /// <param name="O">The value to set</param>
    void SetValue(Object O);

    /// <summary>Sets the specified information of this this <see cref="ITag"/> with the given value</summary>
    /// <param name="InfoType">The into type to store the information in</param>
    /// <param name="Info">The information to store</param>
    void SetInformation(NBTTagInformation InfoType, Object Info);

    /// <summary>Retrieves the specified information</summary>
    /// <param name="InfoType">The info type to retrieve from this this <see cref="ITag"/></param>
    /// <returns>Retrieves the specified information</returns>
    Object GetInformation(NBTTagInformation InfoType);

    /// <summary>Creates a copy of this this <see cref="ITag"/></summary>
    /// <returns>Creates a copy of this this <see cref="ITag"/></returns>
    ITag Clone();
}
