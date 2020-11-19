﻿using System.Runtime.CompilerServices;

namespace GObject
{
    internal partial class Module
    {
        [ModuleInitializer]
        internal static void Initialize()
        {
            RegisterTypes();
        }

        static void RegisterTypes()
        {
            RegisterClasses();
        }

        static partial void RegisterClasses();
    }
}