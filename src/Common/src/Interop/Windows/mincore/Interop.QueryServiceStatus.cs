﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.InteropServices;

internal partial class Interop
{
    internal partial class mincore
    {
        [DllImport(Libraries.ServiceWinSvc, CharSet = CharSet.Unicode, SetLastError = true)]
        internal static extern unsafe bool QueryServiceStatus(IntPtr serviceHandle, SERVICE_STATUS* pStatus);

    }
}
