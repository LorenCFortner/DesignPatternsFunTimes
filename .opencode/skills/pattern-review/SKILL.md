---
name: pattern-review
description: Review C# or TypeScript code for design smells and principle violations, and suggest (or argue against) design patterns. Use when the user asks for a design review, asks "should I use a pattern here?", or submits a kata solution.
---

# Pattern Review

## Process

1. Read `decision-guide.md` and any relevant `principles/` notes first.
2. Review the code and produce:

### Smells found
For each: location, the smell, and the **concrete future pain** it causes. If none, say so.

### Principles at stake
Which principle(s) are violated or well-applied.

### Options
For each smell, list 1-3 options, **always including the simplest one** (often "leave it" or "extract a method"):

| Option | Benefit | Cost | Use when |
|---|---|---|---|

### Recommendation
Pick one and justify it. Explicitly flag **over-engineering** if a pattern is applied without a driving force.

## Rules
- Don't rewrite the code unless asked - describe the change, or show a minimal sketch.
- Praise what's done well; the user is learning.
- For a kata, compare against the kata's intended answer only after giving independent feedback.
- If you find a new smell → pattern mapping, suggest adding a row to `decision-guide.md`.
