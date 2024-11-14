void Imprime(int[] lis)
{
	foreach (int x in lis)
	{
		Console.WriteLine(x);
	}
}

int[] lista = { 5, 6, 8, 9 };

Imprime(lista);

Console.WriteLine("Ingrese número a eliminar");
int n = Convert.ToInt32(Console.ReadLine());


int index = Array.IndexOf(lista, n);

if (index != -1)
{
	
	for (int x = index; x < lista.Length - 1; x++)
	{
		lista[x] = lista[x + 1];
	}

	
	Array.Resize(ref lista, lista.Length - 1);

	Console.WriteLine("Número eliminado correctamente.");
}
else
{
	Console.WriteLine("El número no se encuentra en el arreglo.");
}


Imprime(lista);