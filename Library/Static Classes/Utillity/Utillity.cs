﻿using System;
using System.Collections.Generic;
using System.Reflection;

namespace DaanV2.NBT; 
/// <summary>The static class that provides utillity to the rest of the api</summary>
public static partial class Utillity {
    /// <summary>Returns a list of object that all implement a specified type</summary>
    /// <returns>Returns a list of object that all implement a specified type</returns>
    public static List<T> GetInterfaces<T>(Int32 Capacity = 50) {
        var Out = new List<T>(Capacity);
        String Name = typeof(T).Name;
        Assembly[] Assemblies = AppDomain.CurrentDomain.GetAssemblies();
        Int32 AsmLength = Assemblies.Length;

        for (Int32 I = 0; I < AsmLength; I++) {
            Assembly Asm = Assemblies[I];
            try {
                InternalTypes<T>(Name, Asm, Out);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }


        return Out;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="Name"></param>
    /// <param name="Asm"></param>
    /// <param name="Out"></param>
    internal static void InternalTypes<T>(String Name, Assembly Asm, List<T> Out) {
        Type[] Types = Asm.GetTypes();
        Int32 TypesLength = Types.Length;

        for (Int32 J = 0; J < TypesLength; J++) {
            Type Current = Types[J];

            if (Current.GetInterface(Name) is not null) {
                Out.Add((T)Activator.CreateInstance(Current));
            }
        }
    }
}
