using Facade;

class Program
{
    static void Main(string[] args)
    {
        FachadaForma dibujaFiguras= new FachadaForma();
        
     


       



        

        bool continuar = true;

        while (continuar)
{
            Console.WriteLine("Seleccione una figura");
            Console.WriteLine("1. Rectangulo");
            Console.WriteLine("2. Circulo");
            Console.WriteLine("3. Triangulo");
            Console.WriteLine("4. Salir");

            string menu = Console.ReadLine();

            switch (menu)
            {
                case "1":
                    dibujaFiguras.dibujarRectangulo();
                    break;

                case "2":
                    dibujaFiguras.dibujarCirculo();
                    break;

                case "3":
                    dibujaFiguras.dibujarTriangulo();
                    break;

                case "4":
                default:
                    continuar = false;
                    break;
            }
        }
    }

}