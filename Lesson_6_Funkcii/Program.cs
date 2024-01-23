double Calculet(int a, int b, int c, int d)
{
    double chis = a * b;
    int znam = c + d;
    double result = chis / znam;
    return result;
}
double result = Calculet(1,2,3,4);
Console.WriteLine(result);