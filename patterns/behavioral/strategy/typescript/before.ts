// Smell: the switch grows every time a shipping option is added,
// and calculateShipping must be edited (and retested) each time.

function calculateShipping(method: string, weightKg: number): number {
  switch (method) {
    case "standard":
      return 5 + weightKg * 0.5;
    case "express":
      return 10 + weightKg * 1.0;
    case "overnight":
      return 25 + weightKg * 2.0;
    default:
      throw new Error(`Unknown method: ${method}`);
  }
}

for (const method of ["standard", "express", "overnight"]) {
  console.log(`${method}: $${calculateShipping(method, 3).toFixed(2)}`);
}
