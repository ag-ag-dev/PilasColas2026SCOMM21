namespace Arreglos
{
    internal class Pilas
    {
        // Creamos las variables necesarias: arreglo para el guardado de los datos
        // y tope para controlar cuantos datos hay  y hasta donde podemos agregar mas de ellos
        private string[] _arreglo;
        private int _tope;

        // Creamos el constructor para que luego al crear el objeto de Pilas en Program, le asignemos el numero de datos
        // donde arreglo se encargara de crear los espacios para guardar los datos y tope manejara cuantos datos tenemos en ese momento y el limite de ellos
        public Pilas(int elementos)
        {
            _arreglo = new string[elementos];
            _tope = 0;
        }
        
        // Creamos la funcion de Agregar para el inserte de los datos en el array
        // Si el dato a agregar esta vacio o es solo un espacio en blanco, este lanzara un mensaje mencionando que no se especifico ningun valor para agregar al array.
        // Posteriormente creamos la variable de max para especificar el limite de datos,
        // por lo que ahora tope se compara con max, si tope es igual a max, entonces se lanza otro mensaje diciendo que la pila ya esta llena.
        // Sin embargo, si ninguna de las anteriores condiciones se cumplen, el programa guardara el dato en el espacio que se encuentra tope y
        // finalmente tope se incrementara para marcar que el dato se agrego y pasara a la siguiente posicion para agregar otro dato
        public void Agregar(string elemento)
        {
            if (string.IsNullOrWhiteSpace(elemento))
            {
                throw new Exception("No se ha especificado valor a agregar.");
            }

            int max = _arreglo.Length;

            if (_tope == max)
            {
                throw new Exception("Pila llena");
            }

            _arreglo[_tope] = elemento;
            _tope++;
        }

        // Se crea la funcion de Eliminar
        // Si tope es igual a 0, lanzara un mensaje (o error u excepcion) diciendo que la pila esta vacia y no hay datos que eliminar,
        // pero si la condicion anterior no se cumple, entonces tope se decrementara para indicar que bajara a la posicion del dato a eliminar
        // y el espacio del dato eliminado quedara en blanco
        public void Eliminar()
        {
            if (_tope == 0)
            {
                throw new Exception("Pila vacia");
            }

            _tope--;
            _arreglo[_tope] = "";

        }

        // Se crea la funcion de ObtenerDatos
        // Aqui con la variable datos, guardaremos los datos que se encuentran en el array y ahi se mostraran en consola.
        // Luego creamos un bucle for, que se encargara de recorrer el array desde el inicio hasta donde esta tope,
        // luego, con la funcion de datos += arreglo[i] le decimos al programa que como vayan saliendo los datos del array, van a ir guardandose
        // en la variable de datos, el signo += tiene la funcion de que los datos se acumulen y no se reemplacen, si pusieramos solo =, el dato que saldria primero
        // seria reemplazado por el siguiente dato, y asi de forma sucesiva hasta que finalice el bucle for.
        // Luego con if le mencionamos al programa que si i es menor que tope - 1, entonces se le agregara una coma al dato anterior, osease, lo que estamos haciendo
        // es que la coma aparezca en el penultimo dato, si esta apareciera en el ultimo dato entonces se tomaria como que hay un dato mas en camino, aqui estaremos
        // haciendo que la coma se dirija al numero penultimo de tope (si el ultimo dato de tope es 3, entonces con tope - 1, lo mandaremos al numero 2), 
        // y finalmente, con return datos haremos que todos los cambios anteriores de ObtenerDatos, se guarden en la variable de datos y es lo que mostraremos en la consola final
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
