# Decision Guide: Symptom → Candidate

Start from the **pain**, not the pattern. If there's no pain, you probably don't need a pattern.

| Symptom / smell | Consider | Principle | Watch out for |
|---|---|---|---|
| `switch`/`if` chain on a "type" or "mode" that keeps growing | Strategy, polymorphism | Open/Closed | Only 2 stable branches? Keep the `if`. |
| Behavior changes based on an object's internal status | State | Single Responsibility, Open/Closed | Looks like Strategy - but the object switches itself |
| Constructor with many optional parameters | Builder | KISS (for callers) | Records/named args may be enough |
| Need to add responsibilities without subclass explosion | Decorator | Open/Closed, Composition over Inheritance | Deep wrapper stacks are hard to debug |
| Incompatible interface from a 3rd-party library | Adapter | Dependency Inversion | |
| Many objects need to react when something changes | Observer | Loose coupling | Hidden control flow, memory leaks from un-unsubscribed handlers |
| Complex subsystem that callers misuse | Facade | Law of Demeter | Facade becoming a god object |
| `new ConcreteThing()` scattered everywhere | Factory Method / DI | Dependency Inversion | A DI container may already solve this |

<!-- Add a row every time you learn a pattern. -->
