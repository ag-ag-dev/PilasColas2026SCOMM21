namespace Arreglos
{
    internal class Pilas
    {
        private string[] _arreglo;
        private int _tope;
        public Pilas(int elementos)
        {
            _arreglo = new string[elementos];
            _tope = 0;
        }

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


        public void Eliminar()
        {
            if (_tope == 0)
            {
                throw new Exception("Pila vacia");
            }

            _tope--;
            _arreglo[_tope] = "";

        }

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
