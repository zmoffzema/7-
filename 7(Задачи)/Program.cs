using System;

class Program
{
    static void Main()
    {
        // Запрос суммы вклада
        Console.Write("Введите сумму вклада: ");
        double deposit = Convert.ToDouble(Console.ReadLine());

        double interestRate;

        // Определение процентной ставки в зависимости от суммы вклада
        if (deposit < 100)
        {
            interestRate = 0.05; // 5%
        }
        else if (deposit >= 100 && deposit <= 200)
        {
            interestRate = 0.07; // 7%
        }
        else
        {
            interestRate = 0.10; // 10%
        }

        // Расчет суммы с начисленными процентами
        double finalAmount = deposit + (deposit * interestRate);

        // Вывод результата
        Console.WriteLine($"Сумма вклада с начисленными процентами: {finalAmount:F2}");
    }
}
