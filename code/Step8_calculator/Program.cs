// See https://aka.ms/new-console-template for more information

    Console.WriteLine("Добро пожаловать в калькулятор!");
    Console.Write("Введите первое число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите знак операции (+, -, *, /): ");
    string? symbol = Console.ReadLine();

    switch(symbol)
{
    case "+":
        Sum(num1, num2); break;
    case "-":
        Sub(num1, num2);break;
    case "*":
        Multi(num1, num2);break;
    case "/":
        Div(num1, num2);break;
}

static int Sum(int a, int b)
{
    int result = a + b;
    return result;
}
static int Multi(int a, int b)
{
    int result = a * b;
    return result;
}
static int Div(int a, int b)
{
    int result = a / b;
    return result;
}
static int Sub(int a, int b)
{
    int result = a - b;
    return result;
}