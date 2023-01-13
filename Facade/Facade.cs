using System;
namespace Facade;
public class FachadaForma
{
	private Figura circulo;
	private Figura rectangulo;
	private Figura triangulo;
	public FachadaForma()
	{
		circulo= new Circulo();
		rectangulo= new Rectangulo();
		triangulo= new Triangulo();
	}

	public void dibujarCirculo()
	{
		circulo.dibujar();
	}

	public void dibujarRectangulo()
	{
		rectangulo.dibujar();
	}

	public void dibujarTriangulo()
	{
		triangulo.dibujar();
	}
}
