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
using System.Collections.Generic;
using System.Reflection;

namespace DaanV2.NBT {
    /// <summary>The static class that provides utillity to the rest of the api</summary>
    public static partial class Utillity {
        /// <summary>Returns a list of object that all implement a specified type</summary>
        /// <returns>Returns a list of object that all implement a specified type</returns>
        public static List<T> GetInterfaces<T>(Int32 Capacity = 50) {
            List<T> Out = new List<T>(Capacity);
            String Name = typeof(T).Name;
            Assembly[] Assemblies = AppDomain.CurrentDomain.GetAssemblies();
            Int32 AsmLength = Assemblies.Length;

            for (Int32 I = 0; I < AsmLength; I++) {
                Assembly Asm = Assemblies[I];
                try {
                    Type[] Types = Asm.GetTypes();
                    Int32 TypesLength = Types.Length;

                    for (Int32 J = 0; J < TypesLength; J++) {
                        Type Current = Types[J];

                        if (Current.GetInterface(Name) != null) {
                            Out.Add((T)Activator.CreateInstance(Current));
                        }
                    }
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
            }


            return Out;
        }
    }
}
