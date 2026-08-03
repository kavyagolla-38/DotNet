using System;
class Stock
{
    string stockName;
    string stockSymbol;
    double previousPrice;
    double currentPrice;

    public Stock(string name, string symbol, double prevPrice, double currPrice)
    {
        stockName = name;
        stockSymbol = symbol;
        previousPrice = prevPrice;
        currentPrice = currPrice;
    }
    public double GetChangePercentage()
    {
        return ((currentPrice - previousPrice) / previousPrice) * 100;
    }
    public void Display()
    {
        Console.WriteLine("Stock Name: " + stockName);
        Console.WriteLine("Stock Symbol: " + stockSymbol);
        Console.WriteLine("Previous Price: " + previousPrice);
        Console.WriteLine("Current Price: " + currentPrice);
        Console.WriteLine("Change Percent: " + GetChangePercentage());
    }
}
class StockProgram
{
    static void Main(String[] args)
    {
        Console.Write("Enter Stock Name: ");
        string name = Console.ReadLine() ?? "";
        Console.Write("Enter Stock Symbol: ");
        string symbol = Console.ReadLine() ?? "";
        Console.Write("Enter Previous Price: ");
        double prevPrice = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Current Price: ");
        double currPrice = Convert.ToDouble(Console.ReadLine());
        Stock s = new Stock(name, symbol, prevPrice, currPrice);
        s.Display();
    }
}