﻿/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.Runtime.CompilerServices;

namespace DaanV2.NBT {
    public sealed partial class NBTTagByte {
        /// <summary>Compare the two given tag with each other</summary>
        /// <param name="A">The first object to compare</param>
        /// <param name="B">The second object to compare</param>
        /// <returns>Compare the two given tag with each other</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean operator ==(NBTTagByte A, NBTTagByte B) {
            Boolean NA = ((Object)A) == null;
            Boolean NB = ((Object)B) == null;

            if (NA && NB) {
                return true;
            }
            else if (NA || NB) {
                return false;
            }

            return A._Value.Equals(B._Value) && A._Name.Equals(B._Name);
        }

        /// <summary>Compare the two given tag with each other</summary>
        /// <param name="A">The first object to compare</param>
        /// <param name="B">The second object to compare</param>
        /// <returns>Compare the two given tag with each other</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean operator !=(NBTTagByte A, NBTTagByte B) {
            Boolean NA = ((Object)A) == null;
            Boolean NB = ((Object)B) == null;

            if (NA && NB) {
                return false;
            }
            else if (NA || NB) {
                return true;
            }

            return !(A._Value.Equals(B._Value) || A._Name.Equals(B._Name));
        }

        /// <summary>Compare the two given tag with each other</summary>
        /// <param name="A">The first object to compare</param>
        /// <param name="B">The second object to compare</param>
        /// <returns>Compare the two given tag with each other</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean operator ==(NBTTagByte A, Object B) {
            Boolean NA = ((Object)A) == null;
            Boolean NB = B == null;

            if (NA && NB) {
                return true;
            }
            else if (NA || NB) {
                return false;
            }

            return A.Equals(B);
        }

        /// <summary>Compare the two given tag with each other</summary>
        /// <param name="A">The first object to compare</param>
        /// <param name="B">The second object to compare</param>
        /// <returns>Compare the two given tag with each other</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean operator !=(NBTTagByte A, Object B) {
            Boolean NA = ((Object)A) == null;
            Boolean NB = B == null;

            if (NA && NB) {
                return false;
            }
            else if (NA || NB) {
                return true;
            }

            return !A.Equals(B);
        }
    }
}