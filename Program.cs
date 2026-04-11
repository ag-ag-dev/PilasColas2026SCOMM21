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

                try
                {
                    // Impresiones en consola del metodo Colas
                    Console.WriteLine("");
                    Console.WriteLine("-------------------------------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("Metodo Colas");

                    Colas cola = new Colas(5);
                    cola.Agregar("A");
                    cola.Agregar("B");
                    cola.Agregar("C");
                    cola.Agregar("D");
                    Console.WriteLine(cola.ObtenerDatos());

                    cola.Agregar("E");
                    Console.WriteLine("Agregando E");
                    Console.WriteLine(cola.ObtenerDatos());

                    Console.WriteLine("Eliminando A");
                    cola.Eliminar();
                    Console.WriteLine(cola.ObtenerDatos());

                    Console.WriteLine("Eliminando B");
                    cola.Eliminar();
                    Console.WriteLine(cola.ObtenerDatos());

                    Console.WriteLine("Eliminando C");
                    cola.Eliminar();
                    Console.WriteLine(cola.ObtenerDatos());
                }

                // Se usa Catch para mostrar algun error que se pueda presentar en el metodo Colas
                catch (Exception ex2)
                {
                    Console.WriteLine(ex2.Message);
                }
            }
        }
    }
}
