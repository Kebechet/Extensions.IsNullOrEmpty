[!["Buy Me A Coffee"](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/kebechet)

# Extensions.IsNullOrEmpty
[![NuGet Version](https://img.shields.io/nuget/v/Kebechet.Extensions.IsNullOrEmpty)](https://www.nuget.org/packages/Kebechet.Extensions.IsNullOrEmpty/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Kebechet.Extensions.IsNullOrEmpty)](https://www.nuget.org/packages/Kebechet.Extensions.IsNullOrEmpty/)
[![Twitter](https://img.shields.io/twitter/url/https/twitter.com/samuel_sidor.svg?style=social&label=Follow%20samuel_sidor)](https://x.com/samuel_sidor)

Small set of C# extension methods to check for null/empty/zero across common types.

## Install

Use the .NET CLI:

```
dotnet add package Kebechet.Extensions.IsNullOrEmpty
```

## Usage

```csharp
using System;
using System.Collections.Generic;		
using IsNullOrEmpty.Extensions;

// Strings
string? s1 = null;
bool a = s1.IsNullOrEmpty();         // true

string? s2 = "   ";
bool b = s2.IsNullOrWhiteSpace();    // true

// Collections
IEnumerable<int>? numbers = null;
bool c = numbers.IsNullOrEmpty();    // true

var list = new List<string>();
bool d = list.IsNullOrEmpty();       // true when empty

// Guid
Guid? id1 = null;
bool e = id1.IsNullOrEmpty();        // true

Guid? id2 = Guid.Empty;
bool f = id2.IsNullOrEmpty();        // true

// Numerics (nullable)
int? i = 0;
long? l = null;
double? dbl = 0.0;
decimal? dec = 5m;
float? fl = 0f;

bool g = i.IsNullOrZero();           // true
bool h = l.IsNullOrZero();           // true
bool j = dbl.IsNullOrZero();         // true
bool k = dec.IsNullOrZero();         // false
bool m = fl.IsNullOrZero();          // true
```

## API

- `string?`:
  - `IsNullOrEmpty()`
  - `IsNullOrWhiteSpace()`
- `IEnumerable<T>?`:
  - `IsNullOrEmpty()`
- `Guid?`:
  - `IsNullOrEmpty()`
- Numerics (`int?`, `long?`, `double?`, `decimal?`, `float?`):
  - `IsNullOrZero()`
