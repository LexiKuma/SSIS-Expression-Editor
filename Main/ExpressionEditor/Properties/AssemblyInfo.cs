﻿// ======================================================================================
// <copyright file="AssemblyInfo.cs" company="Konesans Limited">
// Copyright (C) 2017 Konesans Limited
// </copyright>
// ======================================================================================

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("Expression Editor")]
[assembly: AssemblyProduct("Expression Editor Control")]

#if SQL2016
[assembly: AssemblyDescription("SQL Server 2016 Integration Services expression editor control library.")]
[assembly: AssemblyVersion("5.0.0.0")]
[assembly: AssemblyFileVersion("5.0.10.0")]
#elif SQL2014
[assembly: AssemblyDescription("SQL Server 2014 Integration Services expression editor control library.")]
[assembly: AssemblyVersion("4.0.0.0")]
[assembly: AssemblyFileVersion("4.0.10.0")]
#elif DENALI
[assembly: AssemblyDescription("SQL Server 2012 Integration Services expression editor control library.")]
[assembly: AssemblyVersion("3.0.0.0")]
[assembly: AssemblyFileVersion("3.0.10.0")]
#elif KATMAI
[assembly: AssemblyDescription("SQL Server 2008 Integration Services expression editor control library.")]
[assembly: AssemblyVersion("2.0.0.0")]
[assembly: AssemblyFileVersion("2.0.10.0")]
#elif YUKON
[assembly: AssemblyDescription("SQL Server 2005 Integration Services expression editor control library.")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.10.0")]
#endif

[assembly: AssemblyCompany("Konesans Limited")]
[assembly: AssemblyCopyright("Copyright © 2017 Konesans Limited")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: NeutralResourcesLanguage("en-GB")]
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]

#if KATMAI
[assembly: System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.RequestMinimum, UnmanagedCode = false)]
#elif YUKON
[assembly: System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.RequestMinimum, UnmanagedCode = false)]
#endif

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif