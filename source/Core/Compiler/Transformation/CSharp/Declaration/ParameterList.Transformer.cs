﻿using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitParameterList(ParameterListSyntax node)
        {
            return Transform(node.Parameters);
        }
    }
}
