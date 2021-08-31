/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;

namespace DaanV2.NBT {
    /// <summary>The interface responsible for forming the contract on how Tag collection should behave</summary>
    public interface ITagCollection {
        /// <summary>Returns the amount of sub tags this this <see cref="ITag"/> has</summary>
        Int32 Count { get; }

        /// <summary>Returns the tag with the specified name</summary>
        /// <param name="Name">The name of the tag</param>
        /// <returns>Returns the tag with the specified name</returns>
        ITag this[String Name] { get; set; }

        /// <summary>Returns the tag at the specified index</summary>
        /// <param name="Index">The index to look at</param>
        /// <returns>Returns the tag at the specified index</returns>
        ITag this[Int32 Index] { get; set; }

        /// <summary>Adds the given tag to this this <see cref="ITag"/></summary>
        /// <param name="tag">The tag to add</param>
        void Add(ITag tag);

        /// <summary>Removes the tag at the specified index</summary>
        /// <param name="Index">The index of the tag to remove</param>
        void Remove(Int32 Index);

        /// <summary>Removes the tag with the specified name</summary>
        /// <param name="Name">The name of the tag to remove</param>
        void Remove(String Name);

        /// <summary>Removes all the tag inside this this <see cref="ITag"/></summary>
        void Clear();

        /// <summary>Retrieves the subtag with the specified name, this is done safetly, if nothing is found then null is returned</summary>
        ITag GetSubTag(String Name);

        /// <summary>Retrieves the subtag at the specified index, this is done safetly, if nothing is found then null is returned</summary>
        ITag GetSubTag(Int32 Index);

        /// <summary>Retrieves the value of specified subtag, this is done safetly, if nothing is found or can be converted then null is returned</summary>
        T GetSubValue<T>(String Name);

        /// <summary>Retrieves the value of specified subtag, this is done safetly, if nothing is found or can be converted then null is returned</summary>
        T GetSubValue<T>(Int32 Index);
    }
}
