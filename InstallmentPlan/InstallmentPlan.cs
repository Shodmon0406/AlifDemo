public class InstallmentPlan
{
    private string Product { get; set; }
    private decimal Money { get; set; }
    private int Month { get; set; }
    private string PhoneNumber { get; set; }
    private int Percent { get; set; }
    private int Interval { get; set; }

    public InstallmentPlan(int product, decimal money, int month, string phoneNumber)
    {
        Money = money;
        Month = month;
        PhoneNumber = phoneNumber;
        if (product == 1)
        {
            Product = "Phone";
            Percent = 3;
            Interval = 9;
        }
        else if (product == 2)
        {
            Product = "Laptop";
            Percent = 4;
            Interval = 12;
        }
        else if (product == 3)
        {
            Product = "Television";
            Percent = 5;
            Interval = 18;
        }
    }

    public string Calculate()
    {
        var dec = Math.Ceiling(Month / (decimal)Interval);
        var total = Money + (Money * (Math.Ceiling(Month / (decimal)Interval) * Percent) / 100);
        var perMonth = Math.Round(total / (decimal)Month, 2);
        return $"You bought a {Product} and have to pay {total} somoni within {Month} months. every month {perMonth} somoni.";
    }
}

