
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
        newStack.PushToStack(25);

    // Intenta obtener el último elemento de la pila sin eliminarlo
        int lastItem;
        bool success = newStack.PeekFromStack(out lastItem);
        var remainingItems = newStack.ShowAllItemsFromStack();

        Assert.True(success);
        Assert.Equal(25, lastItem);
        Assert.Equal(new[] { 25,20,10 }, remainingItems);
}



    [Fact]
    public void PopFromStack()
    {
        var newStack = new ConcurrentStackExample();
        newStack.PushToStack(30);
        newStack.PushToStack(40);
        newStack.PushToStack(50);


    // Llama al método PopFromStack para sacar el elemento de la pila

        var result = newStack.PopFromStack();
        var remainingItems = newStack.ShowAllItemsFromStack();

    
        Assert.Equal(50, result);
        Assert.Equal(new[] { 40, 30 }, remainingItems);
    }
    [Fact]
    public void PushRange()
    {
   
    var newStack = new ConcurrentStack();
  
    var elementsAdd = new[] { 60, 70, 80 };
    newStack.PushRange(elementsAdd);

    var remainingItems = newStack.ShowAllItems();

    Assert.Equal(new[] { 80, 70, 60 }, remainingItems); 
    }

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
