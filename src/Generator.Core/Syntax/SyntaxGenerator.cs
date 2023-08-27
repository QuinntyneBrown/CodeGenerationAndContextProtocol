// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Generator.Core.Syntax;

public class SyntaxGenerator: ISyntaxGenerator
{
    private readonly ILogger<SyntaxGenerator> _logger;

    public SyntaxGenerator(ILogger<SyntaxGenerator> logger){
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task DoWorkAsync()
    {
        _logger.LogInformation("DoWorkAsync");
    }

}

