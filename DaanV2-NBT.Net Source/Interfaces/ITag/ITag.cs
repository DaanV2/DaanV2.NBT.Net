/*ISC License

Copyright (c) 2019, Daan Verstraten, daanverstraten@hotmail.com

Permission to use, copy, modify, and/or distribute this software for any
purpose with or without fee is hereby granted, provided that the above
copyright notice and this permission notice appear in all copies.

THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF
OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.*/
using System;

namespace DaanV2.NBT {
    /// <summary>The class that is responsible for forming the contract on how Nbt Tag should behave</summary>
    public interface ITag : ITagCollection {
        /// <summary>Gets or sets the name of this <see cref="Itag"/></summary>
        String Name { get; set; }

        /// <summary>Gets the type of this <see cref="Itag"/></summary>
        NBTTagType Type { get; }

        /// <summary>Gets the value of this <see cref="Itag"/></summary>
        /// <returns>Gets the value of this <see cref="Itag"/></returns>
        Object GetValue();

        /// <summary>Converts the value of this <see cref="Itag"/> to the specified type</summary>
        /// <typeparam name="T">The type to convert to</typeparam>
        /// <returns>Converts the value of this <see cref="Itag"/> to the specified type</returns>
        T GetValue<T>();

        /// <summary>Converts the value of this <see cref="Itag"/> to the specified type</summary>
        /// <typeparam name="T">The type to convert to</typeparam>
        /// <returns>Converts the value of this <see cref="Itag"/> to the specified type</returns>
        T ConvertValue<T>();

        /// <summary>Sets the value of this <see cref="Itag"/> with the given value</summary>
        /// <param name="O">The value to set</param>
        void SetValue(Object O);

        /// <summary>Sets the specified information of this <see cref="Itag"/> with the given value</summary>
        /// <param name="InfoType">The into type to store the information in</param>
        /// <param name="Info">The information to store</param>
        void SetInformation(NBTTagInformation InfoType, Object Info);

        /// <summary>Retrieves the specified information</summary>
        /// <param name="InfoType">The info type to retrieve from this <see cref="ITag"/></param>
        /// <returns>Retrieves the specified information</returns>
        Object GetInformation(NBTTagInformation InfoType);

        /// <summary>Creates a copy of this <see cref="Itag"/></summary>
        /// <returns>Creates a copy of this <see cref="Itag"/></returns>
        ITag Clone();
    }
}
