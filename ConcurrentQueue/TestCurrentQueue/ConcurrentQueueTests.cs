using ConcurrentQueue;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConcurrentQueue
{
    public class ConcurrentQueueTests
    {
        //Comprueba que se insertan tres elementos con la propiedad count
        [Fact]
        public void TestearEncolar()
        {
            var miConQueue= new ConcurrentQueue<int>();
            miConQueue.Enqueue(10);
            miConQueue.Enqueue(20);
            miConQueue.Enqueue(30);

            Assert.Equal(3, miConQueue.Count);
        }
        //Comprueba que se desencoló un elemento con Count y que el elemento retornado con result el primero de la cola
        [Fact]
        public void TestearTryDeQueue()
        {
            var miConQueue = new ConcurrentQueue<int>();

            miConQueue.Enqueue(10);
            miConQueue.Enqueue(20);
            miConQueue.Enqueue(30);
            miConQueue.TryDequeue(out int result);
            Assert.Equal(2, miConQueue.Count);
            Assert.Equal(10, result);
        }

        //Comprueba que al intentar desencolar una cola vacía el método TryDequeue retorna false
       
        [Fact]
        public void TestearTryDeQueueAnEmptyCCQueue()
        {
            var miConQueue = new ConcurrentQueue<int>();
            miConQueue.TryDequeue(out int result);
            Assert.Equal(0, result);
        }

        //Comprueba que si no hay objeto para ser removido result tiene un valor inespecífico
        [Fact]
        public void TestearIfAnElementWasRemoved()
        {
            var miConQueue = new ConcurrentQueue<int>();
            
            Assert.False( miConQueue.TryDequeue(out int result));
        }

        //Comprueba que después de realizar el TryPeek la cola contiene la misma cantidad de objetos
        //Comprueba que el método TryPeek devuelve true si el result retornó un objeto
        [Fact]
        public void TestearTryPeek()
        {
            var miConQueue = new ConcurrentQueue<int>();
            miConQueue.Enqueue(10);
            miConQueue.Enqueue(20);
            miConQueue.Enqueue(30);
            miConQueue.TryPeek(out int result);

            Assert.Equal(3, miConQueue.Count);
            Assert.True(miConQueue.TryPeek(out int Result));
            Assert.Equal(10, Result);


        }
    }
}
