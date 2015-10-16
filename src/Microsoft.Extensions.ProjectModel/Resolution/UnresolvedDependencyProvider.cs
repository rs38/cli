// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Linq;
using Microsoft.Extensions.ProjectModel.Graph;
using NuGet.Frameworks;

namespace Microsoft.Extensions.ProjectModel.Resolution
{
    public class UnresolvedDependencyProvider
    {
        public LibraryDescription GetDescription(LibraryRange libraryRange, NuGetFramework targetFramework)
        {
            return new LibraryDescription(
                libraryRange,
                new LibraryIdentity(libraryRange.Name, libraryRange.VersionRange?.MinVersion, libraryRange.Target),
                path: null,
                dependencies: Enumerable.Empty<LibraryRange>(),
                framework: targetFramework,
                resolved: false,
                compatible: false);
        }
    }
}