
using Xunit;


namespace Ej_ConcurrentStack
{
    public class UnitTest1
    {
        
        [Fact]
        public void PushToStack()
        {
            var newStack = new ConcurrentStackExample();
            
            newStack.PushToStack(10);
            newStack.PushToStack(20);

            //En esta linea no sabria como comprobar que lo que se agrego sea igual.
            Assert.Equal(2, newStack.Count());
        }

        [Fact]
        public void TryPeek()
        {
            var newStack = new ConcurrentStackExample();
            newStack.PushToStack(40);

            int peekResult;
            var peekSuccess = newStack.TryPeek(out peekResult);

            Assert.True(peekSuccess);
            Assert.Equal(40, peekResult);
            Assert.Equal(1, newStack.Count());
        }

        [Fact]
        public void PopFromStack()
        {
            var newStack = new ConcurrentStackExample();
            newStack.PushToStack(30);

            var result = newStack.PopFromStack();

            Assert.Equal(30, result);
            Assert.Equal(0, newStack.Count());
        }
    }
}