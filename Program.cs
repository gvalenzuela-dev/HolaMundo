Console.WriteLine("=== Ejemplo de Programacion Orientada a Objetos ===\n");

Console.WriteLine("1. Creamos objetos a partir de clases:");
Animal perro = new Perro("Luna");
Animal gato = new Gato("Michi");
Console.WriteLine($"   {perro.Nombre} es un objeto de la clase Perro.");
Console.WriteLine($"   {gato.Nombre} es un objeto de la clase Gato.\n");

Console.WriteLine("2. Encapsulacion: la energia se modifica mediante metodos, no directamente:");
perro.Comer();
Console.WriteLine($"   Energia de {perro.Nombre}: {perro.Energia}\n");

Console.WriteLine("3. Polimorfismo: llamamos al mismo metodo y cada objeto responde a su manera:");
List<Animal> animales = [perro, gato];
foreach (Animal animal in animales)
{
	Console.Write($"   {animal.Nombre}: ");
	animal.HacerSonido();
}

abstract class Animal
{
	private int energia = 50;

	public string Nombre { get; }
	public int Energia => energia;

	protected Animal(string nombre)
	{
		Nombre = nombre;
	}

	public void Comer()
	{
		energia += 10;
	}

	public abstract void HacerSonido();
}

class Perro(string nombre) : Animal(nombre)
{
	public override void HacerSonido() => Console.WriteLine("Guau");
}

class Gato(string nombre) : Animal(nombre)
{
	public override void HacerSonido() => Console.WriteLine("Miau");
}
