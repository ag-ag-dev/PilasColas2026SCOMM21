namespace Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Pilas pila = new Pilas(5);

                pila.Agregar("A");
                pila.Agregar("B");
                pila.Agregar("C");

                Console.WriteLine(pila.ObtenerDatos());

                pila.Agregar("D");
                Console.WriteLine("Agregando D");
                Console.WriteLine(pila.ObtenerDatos());
                Console.WriteLine("Eliminando D");
                pila.Eliminar();
                Console.WriteLine(pila.ObtenerDatos());
                Console.WriteLine("Eliminando C");
                pila.Eliminar();

                //Agregando problemas
                //pila.Agregar("");
                pila.Eliminar();
                pila.Eliminar();
                pila.Eliminar();
                Console.WriteLine(pila.ObtenerDatos());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
