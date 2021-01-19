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
using System.Runtime.CompilerServices;

namespace DaanV2.NBT {
    public static partial class NBTCasting {
        /// <summary>Converts the given object into the specified type</summary>
        /// <typeparam name="T">The type to conver to</typeparam>
        /// <param name="Value">The object to convert</param>
        /// <returns>Converts the given object into the specified type</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ConvertTo<T>(Object Value) {
            if (Value == null) {
                return default;
            }

            Type To = typeof(T);

            if (To == Value.GetType()) {
                return (T)Value;
            }

            if (Value is Byte B) {
                return (T)NBTCasting.Convert(B, To);
            }
            else if (Value is Byte[] Barray) {
                return (T)NBTCasting.Convert(Barray, To);
            }
            else if (Value is Double D) {
                return (T)NBTCasting.Convert(D, To);
            }
            else if (Value is Single F) {
                return (T)NBTCasting.Convert(F, To);
            }
            else if (Value is Int32 I32) {
                return (T)NBTCasting.Convert(I32, To);
            }
            else if (Value is Int32[] I32array) {
                return (T)NBTCasting.Convert(I32array, To);
            }
            else if (Value is Int64 I64) {
                return (T)NBTCasting.Convert(I64, To);
            }
            else if (Value is Int64[] I64array) {
                return (T)NBTCasting.Convert(I64array, To);
            }
            else if (Value is Int16 I16) {
                return (T)NBTCasting.Convert(I16, To);
            }
            else if (Value is String S) {
                return (T)NBTCasting.Convert(S, To);
            }

            return (T)Value;
        }

        /// <summary>Converts the given object into the specified type</summary>
        /// <typeparam name="T">The type to conver to</typeparam>
        /// <param name="Value">The object to convert</param>
        /// <returns>Converts the given object into the specified type</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ConvertTo<T>(Byte Value) {
            return (T)NBTCasting.Convert(Value, typeof(T));
        }

        /// <summary>Converts the given object into the specified type</summary>
        /// <typeparam name="T">The type to conver to</typeparam>
        /// <param name="Value">The object to convert</param>
        /// <returns>Converts the given object into the specified type</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ConvertTo<T>(Byte[] Value) {
            return (T)NBTCasting.Convert(Value, typeof(T));
        }

        /// <summary>Converts the given object into the specified type</summary>
        /// <typeparam name="T">The type to conver to</typeparam>
        /// <param name="Value">The object to convert</param>
        /// <returns>Converts the given object into the specified type</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ConvertTo<T>(Int16 Value) {
            return (T)NBTCasting.Convert(Value, typeof(T));
        }

        /// <summary>Converts the given object into the specified type</summary>
        /// <typeparam name="T">The type to conver to</typeparam>
        /// <param name="Value">The object to convert</param>
        /// <returns>Converts the given object into the specified type</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ConvertTo<T>(Int16[] Value) {
            return (T)NBTCasting.Convert(Value, typeof(T));
        }

        /// <summary>Converts the given object into the specified type</summary>
        /// <typeparam name="T">The type to conver to</typeparam>
        /// <param name="Value">The object to convert</param>
        /// <returns>Converts the given object into the specified type</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ConvertTo<T>(Int32 Value) {
            return (T)NBTCasting.Convert(Value, typeof(T));
        }

        /// <summary>Converts the given object into the specified type</summary>
        /// <typeparam name="T">The type to conver to</typeparam>
        /// <param name="Value">The object to convert</param>
        /// <returns>Converts the given object into the specified type</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ConvertTo<T>(Int32[] Value) {
            return (T)NBTCasting.Convert(Value, typeof(T));
        }

        /// <summary>Converts the given object into the specified type</summary>
        /// <typeparam name="T">The type to conver to</typeparam>
        /// <param name="Value">The object to convert</param>
        /// <returns>Converts the given object into the specified type</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ConvertTo<T>(Int64 Value) {
            return (T)NBTCasting.Convert(Value, typeof(T));
        }

        /// <summary>Converts the given object into the specified type</summary>
        /// <typeparam name="T">The type to conver to</typeparam>
        /// <param name="Value">The object to convert</param>
        /// <returns>Converts the given object into the specified type</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ConvertTo<T>(Int64[] Value) {
            return (T)NBTCasting.Convert(Value, typeof(T));
        }

        /// <summary>Converts the given object into the specified type</summary>
        /// <typeparam name="T">The type to conver to</typeparam>
        /// <param name="Value">The object to convert</param>
        /// <returns>Converts the given object into the specified type</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ConvertTo<T>(Single Value) {
            return (T)NBTCasting.Convert(Value, typeof(T));
        }

        /// <summary>Converts the given object into the specified type</summary>
        /// <typeparam name="T">The type to conver to</typeparam>
        /// <param name="Value">The object to convert</param>
        /// <returns>Converts the given object into the specified type</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ConvertTo<T>(Double Value) {
            return (T)NBTCasting.Convert(Value, typeof(T));
        }

        /// <summary>Converts the given object into the specified type</summary>
        /// <typeparam name="T">The type to conver to</typeparam>
        /// <param name="Value">The object to convert</param>
        /// <returns>Converts the given object into the specified type</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ConvertTo<T>(String Value) {
            return (T)NBTCasting.Convert(Value, typeof(T));
        }
    }
}
