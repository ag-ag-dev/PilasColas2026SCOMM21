using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Arreglos
{
    internal class ColasCirc
    {
        // Creamos las variables necesarias para el funcionamiento de la cola: el arreglo (array) para crear un espacio de 4 y guardar ahi los datos,
        // inicio para controlar el inicio de la cola, fin para controlar el final, y contador para manejar cuantos datos tenemos en ese momento
        private string[] arreglo = new string[4];
        private int inicio = 0;
        private int fin = 0;
        private int contador = 0;

        // Creamos el metodo Agregar para poder insertar datos en la cola 
        public void Agregar(string dato)
        {
            // Si el contador marca y dice que tenemos los 4 datos (si la cola esta llena)
            // Entonces desplazara al dato una posicion (inicio + 1) y el %4 se encargara que el numero no pase del ultimo dato, y vuelva a empezar desde el inicio.
            // Se baja el contador para que marque que un dato se elimino y asi se pueda agregar otro dato
            if (contador == 4)
            {
                inicio = (inicio + 1) % 4; // La funcion del simbolo % es que actuar como limitador, su funcionamiento se explica de que va a dvidir el numero y se quedara con las sobras
                                           // Osease, si 0/4, 1/4, 2/4 y 3/4 dan 0 como resultado, pero la sobra va cambiando (en 0/4 la sobra daba 0, en 1/4 sobraba un numero, en 2/4 son 2, y 3/4 son 3)
                                           // pues cuando llegase a 4/4, el resultado seria 1 y la sobra para que llegue a 4 seria 0, entonces ahora inicio regresara al principio
                contador--;                 
            }

            // Guarda el dato donde se encuentra fin (arreglo[fin] = dato) y luego fin se mueve al siguiente dato (fin = (fin + 1)). %4 permanece para que no pase el ultimo dato
            // Sumamos al contador para mencionar que un dato se agrego a la cola.
            // Finalmente, se manda a impresion acerca de que un dato fue agregado a la cola
            arreglo[fin] = dato;
            fin = (fin + 1) % 4;
            contador++;
            Console.WriteLine("- - - - - -");
            Console.WriteLine("Se agrego: " + dato);
            Console.WriteLine("- - - - - -");
        }

        // Creamos el metodo Eliminar para poder eliminar datos de la cola 
        // Si el contador marca y enseña que no hay un solo dato en la cola, mencionara que no hay datos que eliminar
        // Pero si hay algun dato que eliminar, se imprimira en consola el dato a eliminar, que sera el que se encuentra al inicio de la cola
        public void Eliminar()
        {
            if (contador == 0)
            {
                Console.WriteLine("No hay dato que eliminar");
                return;
            }

            Console.WriteLine("- - - - - -");
            Console.WriteLine("Eliminando a: " + arreglo[inicio]);
            Console.WriteLine("- - - - - -");

            // Una vez que se eliminara un dato, el inicio queda marcado como vacio,
            // luego se mueve el inicio al siguiente dato, y
            // finalmente se baja el contador para marcar que un dato fue eliminado de la cola
            arreglo[inicio] = "";
            inicio = (inicio + 1) % 4;
            contador--;
        }
        // Creamos el metodo MostrarDatos para permitirnos mostrar los datos que se encuentran dentro de la cola
        // Si el contador marca y dice que no hay un solo dato en la cola, mencionara que la cola esta vacia 
        public void MostrarDatos()
        {
            if (contador == 0)
            {
                Console.WriteLine("La cola esta vacia");
                return;
            }

            // Creamos la funcion de soporte, que servira como una especie de copia del inicio para
            // que no perdamos de donde empieza realmente la fila y asi podemos mover los datos sin perder orden
            int soporte = inicio;

            // Creamos un bucle for para repetir cuantos datos tenemos guardados, hasta que i iguale el valor de contador
            // En este bucle se imprimira la posicion del dato y en donde se encuentra
            // Y finalmente el soporte se salta a la siguiente casilla
            for (int i = 0; i < contador; i++)
            { 
                Console.WriteLine("Posicion " + soporte + ": " + arreglo[soporte]);

                soporte = (soporte + 1) % 4;
            }
        }
        }
    }
