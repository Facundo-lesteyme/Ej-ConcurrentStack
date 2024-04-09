using System;
using System.Collections.Concurrent;

namespace Ej_ConcurrentStack
{
    public class ConcurrentStackExample
    {
        private ConcurrentStack<int> cs = new ConcurrentStack<int>();

        //Inserta un objeto al principio
        public void PushToStack(int value)
        {
            cs.Push(value);
        }

        //Intenta extraer y devolver el objeto situado al principio
        public int PopFromStack()
        {
            int result;
            cs.TryPop(out result);
            return result;
        }

        // Intenta devolver un objeto situado al principio
        public bool TryPeek(out int result)
        {
            return cs.TryPeek(out result);
        }

        //Cuenta el número de elementos actualmente almacenados
        public int Count()
        {
            return cs.Count;
        }
    }
}
