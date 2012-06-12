﻿using System.Collections.Generic;
using System.Linq;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitAccessorDeclaration(AccessorDeclarationSyntax node)
        {
            if (node.Body != null)
                yield return Visit(node.Body).Single();
        }
    }
}