using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Arreglos
{
    internal class Colas
    {
        // Creamos las variables necesarias para Colas, arreglo para el guardado de datos
        // y tope para controlar cuantos datos hay y el limite del array
        private string[] _arreglo;
        private int _tope;

        // Aqui creamos el constructor para Colas
        // lo mismo que en pilas, el arreglo se encargada de escribir cuantos datos guardaremos (y que estaran definidos por Program)
        // y tope para indicar la cantidad de datos existentes en la cola y controlar el limite de los datos.
        // Tecnicamente, nada de aqui cambio mas que el nombre del constructor, este pedazo del codigo es el mismo de Pilas
        public Colas(int elementos)
        {
            _arreglo = new string[elementos];
            _tope = 0;
        }

        // Aqui se crea la funcion de Agregar para añadir datos a la cola,
        // esto basicamente tambien es igual que Pilas, el pedazo de codigo no cambio
        // por lo que su funciomaiento y explicacion es el mismo
        public void Agregar(string elemento)
        {
            if (string.IsNullOrWhiteSpace(elemento))
            {
                throw new Exception("No se ha especificado valor a agregar.");
            }

            int max = _arreglo.Length;

            if (_tope == _arreglo.Length)
            {
                throw new Exception("Cola llena");
            }

            _arreglo[_tope] = elemento;
            _tope++;
        }

        // Aqui creamos la funcion de Eliminar datos de la cola
        // Aqui si cambia el codigo al tratarse de Pilas una estructura de tipo LIFO y Colas uno de tipo FIFO, pues lo unico que cambia es el como se eliminan
        // Si tope es igual a 0, entonces se lanzara un msg (o error o excepcion) que indique que la cola se encuentra vacia.
        // Luego creamos un ciclo for en el, si se cumple la condicion de que mientras i sea menor que el penultimo numero de tope,
        // entonces arreglo[i] absorvera el numero que sigue despues del dato que arreglo[i] ya conserva: arreglo[i, que es el dato actual] = arreglo[i + 1, el dato que sigue en la cola]
        // lo absorvera, y el dato que estaba antes sera eliminado, y asi de forma sucesiva.
        // Finalmente, tope se decrementara para indicar que se elimino un dato y que el espacio esta disponible para otro
        // y arreglo dejara el espacio en blanco
        public void Eliminar()
        {
            if (_tope == 0)
            {
                throw new Exception("Cola vacia");
            }

            for (int i = 0; i < _tope - 1; i++)
            {
                _arreglo[i] = _arreglo[i + 1];
            }

            _tope--;
            _arreglo[_tope] = "";
        }

        // Aqui creamos la funcion de ObtenerDatos 
        // Lo mismo que con Pilas, esta funcion no cambio, el codigo es el mismo
         public string ObtenerDatos()
        {
            string datos = string.Empty;

            for (int i = 0; i < _tope; i++)
            {
                datos += _arreglo[i];   // datos = datos + _arreglo[i] funciona igual
                if (i < (_tope - 1))
                {
                    datos += ",";       //mejorarlo con interpolacion de texto
                }
            }
            return datos;
        }
    }
}
  