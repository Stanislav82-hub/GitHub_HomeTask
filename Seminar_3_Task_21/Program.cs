// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.
double DistaneBWCoordinates()
{
    Console.Write("Hello, Please fill in coordinate X1 \t ");
    double X1 = double.Parse(Console.ReadLine());
    Console.Write("Hello, Please fill in coordinate X2 \t ");
    double X2 = double.Parse(Console.ReadLine());
    Console.WriteLine("");
    Console.Write("Hello, Please fill in coordinate Y1 \t ");
    double Y1 = double.Parse(Console.ReadLine());
    Console.Write("Hello, Please fill in coordinate Y2 \t ");
    double Y2 = double.Parse(Console.ReadLine());
    Console.WriteLine("");
    Console.Write("Hello, Please fill in coordinate Z1 \t ");
    double Z1 = double.Parse(Console.ReadLine());
    Console.Write("Hello, Please fill in coordinate Z2 \t ");
    double Z2 = double.Parse(Console.ReadLine());
    Console.WriteLine("");
    
    double distance = Math.Sqrt(Math.Pow((X1 - X2), 2) + Math.Pow((Y1 - Y2), 2) + Math.Pow((Z1 - Z2), 2));
    return distance;
}

Console.WriteLine($"Well, distance b/w these coordinates is {DistaneBWCoordinates()}");

