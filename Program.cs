using APPCALCULADORA;

Console.WriteLine("Sumar s, Restar r, Multiplicar m, Dividir d");
Console.WriteLine("Ingrese Opción");
string opcion=Console.ReadLine();
Console.WriteLine("Ingrese 2 valores separados por ENTER");
int n1=int.Parse(Console.ReadLine());
int n2=int.Parse(Console.ReadLine());
int resultado=opcion=="s"?new Calculadora().Sumar(n1,n2):0;
Console.WriteLine("RESULTADO " + resultado);


