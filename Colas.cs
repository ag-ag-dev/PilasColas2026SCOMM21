using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Arreglos
{
    internal class Colas
    {
        // Se implementan el arreglo y el tope para controlar la cantidad de datos que se van a agregar
        private string[] _arreglo;
        private int _tope;

        // Aqui creamos y damos los valores iniciales al arreglo y tope
        public Colas(int elementos)
        {
            _arreglo = new string[elementos];
            _tope = 0;
        }

        // Funciones de agregar valores a la cola (Nada cambio)
        public void Agregar(string elemento)
        {
            if (string.IsNullOrWhiteSpace(elemento))
            {
                throw new Exception("No se ha especificado valor a agregar.");
            }

            if (_tope == _arreglo.Length)
            {
                throw new Exception("Cola llena");
            }

            _arreglo[_tope] = elemento;
            _tope++;
        }

        // Funciones de eliminar valores de la cola (Al ser Pilas un sistema LIFO y al ser Colas un sistema FIFO, lo unico que cambia en todo el codigo es el como se eliminan los datos)
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

        // Funciones para obtener y mostrar los valores de la cola en consola (Nada cambio)
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
  