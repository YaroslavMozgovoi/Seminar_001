Console.WriteLine("Введите цеелое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ( number >= 100 && number <= 999 )
{
    int LastDigit = number % 10;
    Console.WriteLine($"последняя цифра числа => {LastDigit} ");
}
else Console.WriteLine("число не трёх значное");