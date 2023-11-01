// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Create an empty List of type object.
List<object> lista = new List<object>();

// Add the following values to the list: 7, 28, -1, true, 'chair'.
lista.Add(7);
lista.Add(28);
lista.Add(-1);
lista.Add(true);
lista.Add("chair");

// Loop through the list and print all values.
foreach (object valor in lista)
{
    Console.WriteLine(valor);
}

// Add all values that are Int type together and output the sum.
int sumaInt = 0;
foreach (object valor in lista)
{
    if (valor is int)
    {
        sumaInt += (int)valor;
    }
}
Console.WriteLine("La suma de los valores enteros (int) es {0}.", sumaInt);