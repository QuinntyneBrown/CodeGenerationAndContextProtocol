// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Generator.Core.Syntax;

public interface ISyntaxGenerator
{
    Task DoWorkAsync();

}

