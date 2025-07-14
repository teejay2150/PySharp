# PySharp - Python Syntax for C#

 PySharp brings Python's expressive syntax to C# with minimal (often faster than LINQ) performance overhead.
 Write Python-style code that compiles to optimized C# for maximum performance and developer productivity.

 ## Features

 - **List Comprehensions**: `[x * 2 for x in numbers if x > 0]`
 - **String Operations**: `text -= {"old", "bad"}` and `parts[] /= ","`
 - **Enhanced Loops**: `for i, item in enumerate(collection)`
 - **Pattern Matching**: Python-style match statements
 - **Auto-brace Insertions**: Python indentation based scoping

## Performance

- Compiles to optimized C# loops (no LINQ overhead) - often O(n) or better
- Leverages Span<T> for zero-copy operations
- SIMD optimization for numeric operations
- Thread-safe by design

## Quick Start

```csharp
using PySharp.Syntax.ListComprehensions;
using PySharp.Syntax.StringOperations;

// Python-style list comprehension
var evens = [x for x in range(100) if x % 2 == 0];

// String Operations
var cleaned = text -= {"unwanted", "words"};
var parts[] /= ",";
```


## Installation

```
dotnet add package PySharp.Core
```

## Contributing

See [CONTRIBUTING.md](CONTRIBUTING.md) for details on how to contribute to this project and a complete list of contributors.
