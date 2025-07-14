using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace PySharp.Core
{
    public class PySharpCompiler
    {
        private readonly List<ISyntaxTransformer> _transformers = new();
        private readonly List<IOptimizationPass> _optimizations = new();
        
        public void RegisterTransformer(ISyntaxTransformer transformer)
        {
            _transformers.Add(transformer);
        }
        
        public void RegisterOptimization(IOptimizationPass optimization)
        {
            _optimizations.Add(optimization);
        }
        
        public string CompileToOptimizedCSharp(string pythonStyleCode)
        {
            // Phase 1: Parse input
            var syntaxTree = CSharpSyntaxTree.ParseText(pythonStyleCode);
            
            // Phase 2: Apply transformations
            foreach (var transformer in _transformers)
            {
                syntaxTree = transformer.Transform(syntaxTree);
            }
            
            // Phase 3: Apply optimizations
            foreach (var optimization in _optimizations)
            {
                syntaxTree = optimization.Optimize(syntaxTree);
            }
            
            return syntaxTree.ToString();
        }
    }
}
