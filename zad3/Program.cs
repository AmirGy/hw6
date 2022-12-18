// На вход программы подаются три целых положительных числа. 
// Определить , является ли это сторонами треугольника. 
// Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах, 
// является ли он прямоугольным, равнобедренным, равносторонним.

void FindAngles (double a, double b, double c)
{
    double cosA = (Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c);
    double arccosA = Math.Acos(cosA) * 180 / Math.PI;
    double roundA = Math.Round(arccosA, 2);
    Console.WriteLine($"Угол а = {roundA}");

    double cosB = (Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) / (2 * a * b);
    double arccosB = Math.Acos(cosB) * 180 / Math.PI;
    double roundB = Math.Round(arccosB, 2);
    Console.WriteLine($"Угол b = {roundB}");

    double cosC = (Math.Pow(c, 2) + Math.Pow(b, 2) - Math.Pow(a, 2)) / (2 * c * b);
    double arccosC = Math.Acos(cosC) * 180 / Math.PI;
    double roundC = Math.Round(arccosC, 2);
    Console.WriteLine($"Угол c = {roundC}");
}

void CheckTriangle(double a, double b, double c)
{
    double S;
    double SRound;
    double P;
    string type;
    if (a < b + c && b < c + a && c < a + b)
    {
        Console.WriteLine("Треугольник с такими сторонами существует!");
        if (a == b && a == c)
        {
            type = "Равносторонним";
            S = (Math.Sqrt(3) * Math.Pow(a, 2)) / 4;
            SRound = Math.Round(S, 2);
        }
        else if (a == b || a == c || b == c)
        {
            type = "Равнобедренным";
            S = (Math.Sqrt(3) * Math.Pow(a, 2)) / 4;
            SRound = Math.Round(S, 2);
        }
        else
        {
            type = "Прямоугольным";
            if (a > b && a > c)
            {
                S = (c * b) / 2;
                SRound = Math.Round(S, 2);
            }
            else if (a < b && b > c)
            {
                S = (a * c) / 2;
                SRound = Math.Round(S, 2);
            }
            else
            {
                S = (a * b) / 2;
                SRound = Math.Round(S, 2);
            }
        }

        P = a + b + c;
        Console.WriteLine($"Треугольник является {type}");
        Console.WriteLine($"Площадь треугольника = {SRound}");
        Console.WriteLine($"Периметр треугольника = {P}");
    }
    else Console.Write("Такого треугольника не сущетсвует.");
}

Console.Write("Введите первую сторону: ");
double a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую сторону: ");
double b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью сторону: ");
double c = Convert.ToInt32(Console.ReadLine());
CheckTriangle(a, b, c);
FindAngles(a, b, c);

