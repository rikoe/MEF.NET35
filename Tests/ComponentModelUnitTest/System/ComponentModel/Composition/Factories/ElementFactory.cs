﻿// -----------------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;

namespace System.ComponentModel.Composition.Factories
{
    internal static partial class ElementFactory
    {
        public static ICompositionElement Create()
        {
            return Create((string)null, (ICompositionElement)null);
        }

        public static ICompositionElement Create(string displayName)
        {
            return Create(displayName, (ICompositionElement)null);
        }

        public static ICompositionElement Create(ICompositionElement origin)
        {
            return Create((string)null, origin);
        }

        public static ICompositionElement Create(string displayName, ICompositionElement origin)
        {
            return new CompositionElement(displayName, origin);
        }

        public static ICompositionElement CreateChain(int count)
        {
            ICompositionElement previousElement = null;

            for (int i = 0; i < count; i++)
            {
                previousElement = Create((count - i).ToString(), previousElement);
            }

            return previousElement;
        }
    }
}