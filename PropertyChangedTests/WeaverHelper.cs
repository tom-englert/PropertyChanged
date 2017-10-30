﻿using System.IO;
using System.Reflection;
using Mono.Cecil;
using NUnit.Framework;

public class WeaverHelper
{
    public string BeforeAssemblyPath;
    public string AfterAssemblyPath;
    public Assembly Assembly;

    public WeaverHelper(string assemblyName)
    {
        BeforeAssemblyPath = Path.GetFullPath(Path.Combine(TestContext.CurrentContext.TestDirectory, @"..\..\..\..\TestAssemblyBin\net452", assemblyName+".dll"));

#if (RELEASE)
        BeforeAssemblyPath = BeforeAssemblyPath.Replace("Debug", "Release");
#endif
        AfterAssemblyPath = BeforeAssemblyPath.Replace(".dll", "2.dll");
        File.Copy(BeforeAssemblyPath, AfterAssemblyPath, true);

        var assemblyResolver = new TestAssemblyResolver();
        var readerParameters = new ReaderParameters
        {
            AssemblyResolver = assemblyResolver
        };
        using (var moduleDefinition = ModuleDefinition.ReadModule(BeforeAssemblyPath,readerParameters))
        {
            var weavingTask = new ModuleWeaver
            {
                ModuleDefinition = moduleDefinition,
                AssemblyResolver = assemblyResolver
            };

            weavingTask.Execute();

            moduleDefinition.Write(AfterAssemblyPath);
        }

        Assembly = Assembly.LoadFrom(AfterAssemblyPath);
    }

}