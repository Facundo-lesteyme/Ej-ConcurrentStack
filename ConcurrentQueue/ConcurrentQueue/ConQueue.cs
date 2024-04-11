using System;
using System.Collections.Concurrent;
namespace ConcurrentQueue
{
    public class ConQueue
    {
        private ConcurrentQueue<int> concurrentCola { get; set; }

        public ConQueue(ConcurrentQueue<int> cc) {
            concurrentCola = cc;
        }

        public ConQueue() { }

        public int Count { get {  return concurrentCola.Count; } }
        public void Encolar(int element) {
            concurrentCola.Enqueue(element);
        }
        public void recorrer()
        {
            foreach (var item in concurrentCola)
            {
                Console.WriteLine(item);
            }
        }
        
       //el metodo TryDequeue : intenta eliminar y retornar el primer elemento de CurrentQueue
        public int IntentaDesencolar()
        {
            concurrentCola.TryDequeue(out int Resultado);
            return Resultado;
        }

     
        //El metodo TryPeek intenta retornar un objeto desde el principio de la cola sin eliminarlo
        public int RetornarPrimero()
        {
            concurrentCola.TryPeek(out int Resultado2);
            return Resultado2;

        }
    }
}
