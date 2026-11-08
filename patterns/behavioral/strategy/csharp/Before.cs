// Smell: the switch grows every time a shipping option is added,
// and ShippingCalculator must be edited (and retested) each time.

var calculator = new ShippingCalculator();
foreach (var method in new[] { "standard", "express", "overnight" })
{
    Console.WriteLine($"{method}: {calculator.Calculate(method, weightKg: 3m):C}");
}

class ShippingCalculator
{
    public decimal Calculate(string method, decimal weightKg)
    {
        switch (method)
        {
            case "standard":
                return 5m + weightKg * 0.5m;
            case "express":
                return 10m + weightKg * 1.0m;
            case "overnight":
                return 25m + weightKg * 2.0m;
            default:
                throw new ArgumentException($"Unknown method: {method}");
        }
    }
}
