/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.Runtime.Serialization;

namespace DaanV2.NBT {
    public abstract partial class NBTTag : ITag {

        /// <summary>Gets or sets the name of this this <see cref="ITag"/></summary>
        [DataMember]
        public String Name {
            get => this._Name;
            set => this._Name = value;
        }

        /// <summary>Gets the type of this this <see cref="ITag"/></summary>
        [IgnoreDataMember]
        public abstract NBTTagType Type { get; }

        /// <summary>Gets the value of this this <see cref="ITag"/></summary>
        /// <returns>Gets the value of this this <see cref="ITag"/></returns>
        public abstract Object GetValue();

        /// <summary>Converts the value of this this <see cref="ITag"/> to the specified type</summary>
        /// <typeparam name="T">The type to convert to</typeparam>
        /// <returns>Converts the value of this this <see cref="ITag"/> to the specified type</returns>
        public abstract T GetValue<T>();

        /// <summary>Sets the value of this this <see cref="ITag"/> with the given value</summary>
        /// <param name="O">The value to set</param>
        public abstract void SetValue(Object O);

        /// <summary>Sets the specified information of this this <see cref="ITag"/> with the given value</summary>
        /// <param name="InfoType">The into type to store the information in</param>
        /// <param name="Info">The information to store</param>
        public virtual void SetInformation(NBTTagInformation InfoType, Object Info) {
            switch (InfoType) {
                case NBTTagInformation.Name:
                    this._Name = (String)Info;
                    break;

                case NBTTagInformation.Tag:
                    this._Tags.Add((ITag)Info);
                    break;
                    
                case NBTTagInformation.ListSize:
                case NBTTagInformation.ListSubtype:
                case NBTTagInformation.Value:
                default:
                    break;
            }
        }

        /// <summary>Retrieves the specified information</summary>
        /// <param name="InfoType">The info type to retrieve from this this <see cref="ITag"/></param>
        /// <returns>Retrieves the specified information</returns>
        public virtual Object GetInformation(NBTTagInformation InfoType) {
            switch (InfoType) {
                case NBTTagInformation.Name:
                    return this._Name;

                case NBTTagInformation.Tag:
                    return this._Tags;

                case NBTTagInformation.ListSize:
                    return this._Tags.Count;

                case NBTTagInformation.ListSubtype:
                case NBTTagInformation.Value:
                default:
                    return null;
            }
        }

        /// <summary>Converts the value of this this <see cref="ITag"/> to the specified type</summary>
        /// <typeparam name="T">The type to convert to</typeparam>
        /// <returns>Converts the value of this this <see cref="ITag"/> to the specified type</returns>
        public abstract T ConvertValue<T>();

        /// <summary>Creates a copy of this this <see cref="ITag"/></summary>
        /// <returns>Creates a copy of this this <see cref="ITag"/></returns>
        public abstract ITag Clone();
    }
}
