internal class Program
{
    private static int Main()
    {
        Console.Write("Please enter product id (phone = 1, laptop = 2, television = 3) : ");
        var product = int.Parse(Console.ReadLine());
        Console.Write("Please enter the product price : ");
        var money = decimal.Parse(Console.ReadLine());
        Console.Write("Please enter the month : ");
        var month = int.Parse(Console.ReadLine());
        Console.Write("Please enter ypur phone number : ");
        var phoneNumber = Console.ReadLine();
        var a = product < 1 && product > 3;
        var c = month < 3 && month > 24;
        var d = money < 0;
        var e = string.IsNullOrEmpty(phoneNumber);
        if (product < 1 || product > 3 || month < 3 || month > 24 || money < 0 || string.IsNullOrEmpty(phoneNumber))
        {
            Console.WriteLine("Invalid input!");
            return Main();
        }

        var totalPrice = new InstallmentPlan(product, money, month, phoneNumber);
        Console.WriteLine(totalPrice.Calculate());
        return Main();
    }
}