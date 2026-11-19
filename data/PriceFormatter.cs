using System.Globalization;

namespace BlazingPizza;

public static class PriceFormatter
{
    public static string Format(decimal amount) => "GH₵" + amount.ToString("0.00", CultureInfo.InvariantCulture);
}