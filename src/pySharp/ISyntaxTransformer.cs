using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace PySharp.Core
{
    public interface ISyntaxTransformer
    {
        SyntaxTree Transform(SyntaxTree pythonStyleSyntax);
        bool CanHandle(SyntaxNode node);
    }
    
    public interface IOptimizationPass
    {
        SyntaxTree Optimize(SyntaxTree csharpSyntax);
        string Name { get; }
    }
}
