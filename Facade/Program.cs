using Facade;

class Program
{
    static void Main(string[] args)
    {
        FachadaForma dibujaFiguras= new FachadaForma();
        dibujaFiguras.dibujarTriangulo();
        dibujaFiguras.dibujarCirculo();
        dibujaFiguras.dibujarRectangulo();
    }

}