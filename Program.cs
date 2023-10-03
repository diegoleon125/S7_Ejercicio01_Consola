Console.Write("Ingrese el valor de n: ");
int N = int.Parse(Console.ReadLine());
float result = 0f;
float suma = 0f;
for (int i = 1; i <= N; i++)
{
    result = (16f-i) / (3f*i);
    Console.WriteLine("resultado : " + result);
    suma += result;
}
Console.WriteLine(suma);