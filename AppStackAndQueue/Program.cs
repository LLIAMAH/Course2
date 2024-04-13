using AppStackAndQueue.Classes;

//var q = new Queue<int>();
//q.Enqueue(56); // push
//var a = q.Dequeue(); // pop
//var aa = q.Peek();

//var s = new Stack<int>();
//s.Push(564);
//s.Push(345);
//s.Push(345); 
//s.Push(345);

var queue = new MyQueue<int>() as IMyQueue<int>;

queue.Push(5);
queue.Push(17);
queue.Push(23);

object? p = null;
var list = new List<int>();
while (queue.Count() > 0)
{
    p = queue.Pop();
    list.Add((int)p); //type cast 'p' from object to int type.
}

OutputString("Queue values: ", list);
//=============================================
list.Clear();

var stack = new MyStack() as IMyStack;

stack.Push(5);
stack.Push(17);
stack.Push(23);
while ((p = stack.Pop()) != null)
{
    list.Add((int)p); //type cast 'p' from object to int type.
}

OutputString("Stack values: ", list);
return;

void OutputString<T>(string prefix, IEnumerable<T> list)
{
    var output = string.Join(", ", list);
    Console.WriteLine($"{prefix} {output}.");
}
