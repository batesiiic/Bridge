﻿using System;

namespace Bridge.Plugin
{
    public enum TypesSplit
    {
        None = 0,
        ByFullName = 1,
        ByName = 2,
        ByModule = 3,
        ByNamespace = 4
    }

    public interface IAssemblyInfo
    {
        System.Collections.Generic.List<IModuleDependency> Dependencies { get; set; }
        string FileName { get; set; }
        TypesSplit FilesHierrarchy { get; set; }
        string Module { get; set; }
        string OutputDir { get; set; }
        int StartIndexInName { get; set; }
        string BeforeEvent { get; set; }
        string AfterEvent { get; set; }
    }
}