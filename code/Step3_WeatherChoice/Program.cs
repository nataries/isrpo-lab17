// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Выбор одежды по погоде");
// Console.Write("Введите текущую температуру (°С):");
// int temperature = Convert.ToInt32(Console.ReadLine());
// if (temperature >= 20)
// {
//     Console.WriteLine("Наденьте лёгкую одежду");
// }
// else
// {
//     Console.WriteLine("Наденьте тёплую одежду");
// }
// Console.WriteLine("Хорошего дня!");


//Практическое задание
Console.WriteLine("Выбор одежды");
Console.Write("Сегодня дождливая погода?");
string? answer = Console.ReadLine();
if (answer == "Yes")
{
    Console.WriteLine("Стоит надеть сапоги и не забыть взять зонтик!");
}
else
{
    Console.WriteLine("Одевайте любую удобную одежду!");
}
Console.WriteLine("Удачной прогулки!");