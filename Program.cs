Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
Console.WriteLine("Введите систему счисления(от 2 до 9): ");
int sys = Convert.ToInt32(Console.ReadLine());

while (sys < 2 || sys > 9)
{
    Console.WriteLine("Система счисления должна быть от 2 до 9");
    Console.WriteLine("Введите систему заново: ");
    sys = Convert.ToInt32(Console.ReadLine());
}
int vivod = 0;
int length = num.Length;

for (int i = 0; i < length; i++)
{
    char c = num[i];
    int C = c - '0';

    if (C < 0 || C >= sys)
    {
        Console.WriteLine($"Цифра '{c}' недопустима для системы с основанием {sys}!");
        return;
    }
    
    int cifra = length - i - 1;
    vivod += C * (int)Math.Pow(sys, cifra);
}

Console.WriteLine($"Число в десятичной системе: {vivod}");
