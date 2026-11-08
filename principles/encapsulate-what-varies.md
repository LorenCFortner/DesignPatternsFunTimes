# Encapsulate What Varies

## In one sentence
Identify the aspects of your application that vary and separate them from what stays the same

## Why it matters
By encapsulating the parts of your code that change often the next change that comes will only affect that area of code and leave the rest unchanged

## How to spot a violation
- An ever growing case statement
- The same `if`/`switch` repeated in several places
- Editing the same file for every new feature or variant

## How to fix it
The parts that will change get their own interface and a class for each change or type of thing.  The classes that use the interface will not need to change when a class that implements that interface changes or when new classes are created that implement it.

An interface with classes isn't the only option - a function or delegate works too (see the TypeScript Strategy example).

## When it's OK to bend it
- **It hasn't actually varied yet.** Guessing at future change leads to over-engineering (YAGNI). Wait until the same spot has changed two or three times, then encapsulate it.
- **There are only two stable options.** An `if`/`else` that won't grow is easier to read than an interface with two classes.
- **It's throwaway code** - a prototype, spike, or one-off script.
- **The variation is already handled elsewhere** - config, a lookup table, or a framework hook. A `Dictionary<string, decimal>` of rates can be enough without a class per option.
- **The extra indirection costs more than it saves.** Each interface is one more place to jump to when reading the code.

## Tension with other principles
- **YAGNI / KISS:** this principle says plan for change; YAGNI says don't build for change that hasn't happened. Resolve it by encapsulating *proven* variation, not imagined variation.
- **DRY:** usually allies - pulling out what varies often removes duplicated branching. But forcing two things that only *look* alike behind one abstraction couples them so they change together when they shouldn't.
- **Single Responsibility:** a close ally. "Things that change for different reasons" is nearly the same idea as "things that vary".
- **Readability:** behavior gets spread across many small classes, so the full flow is harder to follow in one place.
