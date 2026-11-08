# Design Patterns Fun Times

A place to practice design patterns and principles - and, more importantly, to learn **when** to apply them.

## Layout

| Path | Purpose |
|---|---|
| `principles/` | Design principles (SOLID, DRY, KISS, YAGNI, ...) in my own words |
| `patterns/<category>/<pattern>/` | Notes + before/after examples in C# and TypeScript |
| `katas/` | Practice problems with no stated pattern - figure out which (if any) fits |
| `decision-guide.md` | Symptom → pattern/principle cheat sheet |
| `templates/` | Templates for new patterns, principles, and katas |
| `AGENTS.md` | Rules for the AI assistant |
| `.opencode/` | AI skills and slash commands |

## Running examples

```sh
# C# (.NET 10+)
dotnet run patterns/behavioral/strategy/csharp/After.cs

# TypeScript
npx tsx patterns/behavioral/strategy/typescript/after.ts
```

## Workflow

1. Learn a principle → write `principles/<name>.md`.
2. Learn a pattern → `/new-pattern <name>`, write the notes, write `before` first, then refactor to `after`.
3. Add the smell(s) to `decision-guide.md`.
4. Test yourself → `/kata`, then `/review` your solution.

## Progress

### Principles
- [ ] Single Responsibility
- [ ] Open/Closed
- [ ] Liskov Substitution
- [ ] Interface Segregation
- [ ] Dependency Inversion
- [ ] DRY / KISS / YAGNI
- [ ] Composition over Inheritance
- [ ] Law of Demeter

### Creational
- [ ] Factory Method
- [ ] Abstract Factory
- [ ] Builder
- [ ] Prototype
- [ ] Singleton

### Structural
- [ ] Adapter
- [ ] Bridge
- [ ] Composite
- [ ] Decorator
- [ ] Facade
- [ ] Flyweight
- [ ] Proxy

### Behavioral
- [ ] Chain of Responsibility
- [ ] Command
- [ ] Iterator
- [ ] Mediator
- [ ] Memento
- [ ] Observer
- [ ] State
- [x] Strategy *(starter example)*
- [ ] Template Method
- [ ] Visitor
