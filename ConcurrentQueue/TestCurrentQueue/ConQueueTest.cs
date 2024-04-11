using System.Collections;
using System.Collections.Concurrent;
using ConcurrentQueue;


namespace TestConcurrentQueue
{
    public class ConQueueTest
    {
       

        [Fact]
        public void TestearEncolar()
        {
            var cc = new ConcurrentQueue<int>();
            var miConQueue = new ConQueue(cc);
            miConQueue.Encolar(10);
                       
            Assert.Equal(1,miConQueue.Count);
            
        }

        [Fact]
        public void TestearCount()
        {
            var cc = new ConcurrentQueue<int>();
            var miConQueue = new ConQueue(cc);
            miConQueue.Encolar(10);
            miConQueue.Encolar(20);
            miConQueue.Encolar(30);

            Assert.Equal(3,miConQueue.Count);
        }
        [Fact]
        public void TestearIntentarDesencolar()
        {
            var cc = new ConcurrentQueue<int>();
            var miConQueue = new ConQueue(cc);
            miConQueue.Encolar(10);
            miConQueue.Encolar(20);
            miConQueue.Encolar(30);
            miConQueue.IntentaDesencolar();
            Assert.Equal(2, miConQueue.Count);

        }
        [Fact]
        public void TestearIntentarDesencolar2()
        {
            var cc = new ConcurrentQueue<int>();
            var miConQueue = new ConQueue(cc);
            miConQueue.Encolar(10);
            miConQueue.Encolar(20);
            Assert.Equal(10,miConQueue.IntentaDesencolar());
        }
        [Fact]
        public void TestearIntentarDesencolarVacio()
        {
            var cc = new ConcurrentQueue<int>();
            var miConQueue = new ConQueue(cc);
            Assert.Equal(0, miConQueue.IntentaDesencolar());
        }
        [Fact]
        public void TestearRetornarPrimero()
        {
            var cc = new ConcurrentQueue<int>();
            cc.Enqueue(10);
            cc.Enqueue(20);
            cc.Enqueue(30);
            var miConQueue = new ConQueue(cc);
            Assert.Equal(10, miConQueue.RetornarPrimero());
            Assert.Equal(3, miConQueue.Count);
        }
    }
}