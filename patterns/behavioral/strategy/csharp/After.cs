// Each shipping option is its own strategy. Adding one means adding a class,
// not editing ShippingCalculator (Open/Closed).

var strategies = new Dictionary<string, IShippingStrategy>
{
    ["standard"] = new StandardShipping(),
    ["express"] = new ExpressShipping(),
    ["overnight"] = new OvernightShipping(),
};

foreach (var (method, strategy) in strategies)
{
    var calculator = new ShippingCalculator(strategy);
    Console.WriteLine($"{method}: {calculator.Calculate(weightKg: 3m):C}");
}

interface IShippingStrategy
{
    decimal Cost(decimal weightKg);
}

class StandardShipping : IShippingStrategy
{
    public decimal Cost(decimal weightKg) => 5m + weightKg * 0.5m;
}

class ExpressShipping : IShippingStrategy
{
    public decimal Cost(decimal weightKg) => 10m + weightKg * 1.0m;
}

class OvernightShipping : IShippingStrategy
{
    public decimal Cost(decimal weightKg) => 25m + weightKg * 2.0m;
}

class ShippingCalculator(IShippingStrategy strategy)
{
    public decimal Calculate(decimal weightKg) => strategy.Cost(weightKg);
}
