// In TypeScript, functions are first-class, so a strategy can just be a function type.
// No interface + class hierarchy needed - compare with the C# version.

type ShippingStrategy = (weightKg: number) => number;

const strategies: Record<string, ShippingStrategy> = {
  standard: (w) => 5 + w * 0.5,
  express: (w) => 10 + w * 1.0,
  overnight: (w) => 25 + w * 2.0,
};

function calculateShipping(strategy: ShippingStrategy, weightKg: number): number {
  return strategy(weightKg);
}

for (const [method, strategy] of Object.entries(strategies)) {
  console.log(`${method}: $${calculateShipping(strategy, 3).toFixed(2)}`);
}
