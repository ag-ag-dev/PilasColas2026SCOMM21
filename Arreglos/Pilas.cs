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
            int max = _arreglo.Length;

            if (_tope == max)
            {
                throw new Exception("Pila llena");
            }

            _arreglo[_tope] = elemento;
            _tope++;
        }
    }
}
