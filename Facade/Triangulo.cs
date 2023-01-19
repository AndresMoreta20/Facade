using System;
namespace Facade;

public class Triangulo : Figura
{

	public void dibujar()
	{
		Console.WriteLine("   *");
		Console.WriteLine("  * *");
		Console.WriteLine(" *   *");
		Console.WriteLine("*******");
	}
	
}
