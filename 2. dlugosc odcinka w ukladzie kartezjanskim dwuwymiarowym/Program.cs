double x1 = 2.5;
double y1 = 3.8;
double x2 = 5.1;
double y2 = 7.2;

double dlugoscOdcinka = liczDlugosc(x1, y1, x2, y2);
Console.WriteLine("Długość odcinka: " + dlugoscOdcinka);

    static double liczDlugosc(double x1, double y1, double x2, double y2)
{
    double deltaX = x2 - x1;
    double deltaY = y2 - y1;
    double dlugoscOdcinka = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
    return dlugoscOdcinka;
}