namespace Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Usamos el try para mostrar algun error que pueda pasar al ejecutar Pilas
            try
            {
                // Creamos el objeto de Pilas, para posteriormente asignarle 5 objetos, es decir, podemos agregar hasta 5 datos en el array de Pilas.
                // Posteriormente ponemos a prueba el funcionamiento de Pilas, se agregan datos, se eliminan, y se obtienen los datos y se muestran en consola
                Pilas pila = new Pilas(5);

                Console.WriteLine("Metodo Pilas");
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
            // Aqui terminamos con el uso de try y usamos catch para que el programa agarre cualquier error que nos
            // pueda presentar en la ejecucion del codigo, y posteriormente nos muestre el error general no especificado
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                // -------------------------------- COLAS ---------------------------------

                // Se repite el uso de try y catch para capturar algun error del programa
                try
                {
                    // Mas impresiones en consola pero ahora sobre el metodo Colas:
                    // Se crea el array cola, se le asignan los 5 datos, se agregan, se eliminan, y se obtienen los datos y se muestran en consola
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

                    cola.Agregar("A");
                    Console.WriteLine("Agregando A");
                    Console.WriteLine(cola.ObtenerDatos());
                }

                // Se usa Catch para mostrar algun error que se pueda presentar en el metodo Colas
                catch (Exception ex2)
                {
                    Console.WriteLine(ex2.Message);
                }

                // -------------------------------- COLAS CIRCULARES ---------------------------------

                // Mas de lo mismo, usamos try, catch y ex para capturar errores y enseñarlos en la ejecucion
                {
                    try
                    {
                        // El mismo proceso, se crea el array de colas circulares [esta vez no se especifica el tamaño del array aqui, si no en el archivo class de ColasCirc, que es 4]
                        // Se agregan datos, se restan, se desplanzan los datos y finalmente se enseñan en consola
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------------------------------------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("Metodo Colas circulares");

                        ColasCirc cola2 = new ColasCirc();
                        cola2.Agregar("A");
                        cola2.Agregar("B");
                        cola2.Agregar("C");
                        cola2.Agregar("D");
                        cola2.MostrarDatos();

                        cola2.Agregar("E");
                        cola2.Agregar("F");
                        cola2.Agregar("G");
                        cola2.MostrarDatos();

                        cola2.Eliminar();
                        cola2.MostrarDatos();
                    }
                    catch (Exception ex3)
                    {
                        Console.WriteLine(ex3.Message);
                    }
                }
            }
        }
    }
}
