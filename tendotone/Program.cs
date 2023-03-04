using ninedotone;
using tendotone;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите количество купюр номиналом 1: ");
        int oneBillCount = int.Parse(Console.ReadLine());
        Console.Write("Введите количество купюр номиналом 2: ");
        int twoBillCount = int.Parse(Console.ReadLine());
        Console.Write("Введите количество купюр номиналом 5: ");
        int fiveBillCount = int.Parse(Console.ReadLine());
        Console.Write("Введите количество купюр номиналом 10: ");
        int tenBillCount = int.Parse(Console.ReadLine());
        Console.Write("Введите количество купюр номиналом 50: ");
        int fiftyBillCount = int.Parse(Console.ReadLine());
        Console.Write("Введите количество купюр номиналом 100: ");
        int hundredBillCount = int.Parse(Console.ReadLine());
        Console.Write("Введите количество купюр номиналом 500: ");
        int fiveHundredBillCount = int.Parse(Console.ReadLine());
        Console.Write("Введите количество купюр номиналом 1000: ");
        int thousandBillCount = int.Parse(Console.ReadLine());
        Console.Write("Введите количество купюр номиналом 5000: ");
        int fiveThousandBillCount = int.Parse(Console.ReadLine());

        Console.WriteLine("Какую операцию вы хотите выполнить? Конвертацию из евро в рубли (введите 1) или конвертацию из рублей в евро (введите 2)?");
        int temp = int.Parse(Console.ReadLine());
        if (temp == 1)
        {
            BillCounter billCounter = new BillCounter(oneBillCount, twoBillCount, fiveBillCount, tenBillCount, fiftyBillCount, hundredBillCount, fiveHundredBillCount, thousandBillCount, fiveThousandBillCount);
            Console.WriteLine(billCounter.getSum());
        }
        else if (temp == 2)
        {
            EuroToRub euroToRub = new EuroToRub(oneBillCount, twoBillCount, fiveBillCount, tenBillCount, fiftyBillCount, hundredBillCount, fiveHundredBillCount, thousandBillCount, fiveThousandBillCount);
            Console.WriteLine(euroToRub.getRubs()); 
        }
        else Console.WriteLine("Необходимо ввести число 1 или 2");
    }
}