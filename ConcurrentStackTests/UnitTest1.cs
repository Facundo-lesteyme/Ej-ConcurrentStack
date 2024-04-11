
using Xunit;


namespace Ej_ConcurrentStack
{
    public class ConcurrentStack_Test
    {

        //Comprueba que se insertan tres elemento y comprueba que inserto
        [Fact]
        public void PushToStack()
        {
            var newStack = new ConcurrentStack();
            
            newStack.PushToStack(10);
            newStack.PushToStack(20);
            newStack.PushToStack(25);

            var ItemsStack = newStack.ShowAllItems();

            Assert.Equal(new[] { 25,20,10 }, ItemsStack);
        }


        //Comprueba que se insertan 3 elementos y intenta extraer y devolver el ultimo elemento 
        [Fact]
        public void TryPopStack()
        {
            var newStack = new ConcurrentStack();

            newStack.PushToStack(30);
            newStack.PushToStack(40);
            newStack.PushToStack(50);


            // Llama al método PopFromStack para sacar el elemento de la pila

            var result = newStack.PopFromStack();
            var remainingItems = newStack.ShowAllItems();


            Assert.Equal(50, result);

            //Se comprueba que se elimino el elemento
            Assert.Equal(new[] { 40, 30 }, remainingItems);
        }

        //Comprueba que se insertan 3 elementos y intenta devolver el ultimo elemento sin extraerlo 
        [Fact]
        public void TryPeakStack()
        {
            var newStack = new ConcurrentStack();

            newStack.PushToStack(30);
            newStack.PushToStack(40);
            newStack.PushToStack(50);
            

            // Llama al método PeekFromStack para devolver el elemento de la pila

            int lastItem;
            bool success = newStack.PeekFromStack(out lastItem);
            var remainingItems = newStack.ShowAllItems();


            Assert.Equal(50, lastItem);

            //Se comprueba que no se elimino el elemento
            Assert.Equal(new[] { 50,40, 30 }, remainingItems);
        }

        //Comprueba que se insertan varios elementos a la vez
        [Fact]
        public void PushRange()
        {
           
            var newStack = new ConcurrentStack();
  
            var elementsAdd = new[] { 60, 70, 80 };
            newStack.PushRange(elementsAdd);

            var remainingItems = newStack.ShowAllItems();

            Assert.Equal(new[] { 80, 70, 60 }, remainingItems); 
        }


        //Comprueba que se borran todos loe elementos
        [Fact]
        public void Clear()
        {
            var newStack = new ConcurrentStack();

            newStack.PushToStack(10);
            newStack.PushToStack(20);
            newStack.PushToStack(30);

            newStack.Clear();

            bool isEmpty = newStack.IsEmpty();

            Assert.True(isEmpty);
        }
    }
}
