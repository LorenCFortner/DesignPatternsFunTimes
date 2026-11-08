---
name: new-pattern
description: Scaffold a new design pattern folder (notes + C# and TypeScript before/after stubs). Use when the user starts learning a new pattern or says "add pattern X".
---

# New Pattern

1. Determine the category (`creational`, `structural`, `behavioral`) and kebab-case name.
2. Create `patterns/<category>/<name>/`:
   - `README.md` - copy of `templates/pattern-template.md` with the title and category filled in. **Leave the content sections empty** for the user to write.
   - `csharp/Before.cs`, `csharp/After.cs`
   - `typescript/before.ts`, `typescript/after.ts`
3. Stubs contain only a header comment describing the scenario and a `TODO`. Suggest a small realistic domain for the scenario, but **do not implement the code** unless the user asks.
4. Check the README progress list box only when the user says they're done.
5. See `patterns/behavioral/strategy/` as the reference example.
