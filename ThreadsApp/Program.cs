/*
var list = new List<int>();
for (var i = 0; i < 10_000; i++)
{
    list.Add(i);
}

var chunked = list.AsEnumerable().Chunk(1000);

var threads = new List<ThreadOld>();
for (var i = 0; i < chunked.Count(); i++)
{
    threads.Add(new ThreadOld(i, chunked.ToArray()[i]));
}

foreach (var threadOld in threads)
{
    threadOld.Start(null);
}
*/

var cts = new CancellationTokenSource();
var token = cts.Token;

var tasks = new List<Task>();
for (var i = 0; i < 20; i++)
{
    tasks.Add(new Task(action: () =>
    {
        var guid = Guid.NewGuid();
        const int counterMax = 100;
        var counter = 0;
        while (counter < counterMax)
        {
            if (token.IsCancellationRequested)
                break;

            Console.WriteLine($"Thread#{guid}: {counter}");
            counter++;
        }
    }, token));
}

foreach (var task in tasks)
{
    task.Start();
}

Task.WaitAll(tasks.ToArray());

Console.WriteLine("All Threads are started.");

return;

public class ThreadOld
{
    const int _counterMax = 100;
    private Thread _thread;
    private readonly int _threadNumber;
    private readonly int[] _items;
    private bool _isWorking = false;
    private static object _mutexObject = new object();

    //private static Mutex _mutex = new Mutex(false, "Name");
    //private static Semaphore _semaphore = new Semaphore(0, 10, "Semaphore");

    public ThreadOld(int threadNumber, int[] items)
    {
        this._threadNumber = threadNumber;
        this._items = items;
    }

    public void Start(object obj = null)
    {
        this._thread = new Thread(Work);

        //_semaphore.WaitOne();
        //_semaphore.Release();

        //_mutex.WaitOne();
        //
        //
        //
        //_mutex.ReleaseMutex();

        lock (_mutexObject)
        {
            this._isWorking = true;
        }
        this._thread.Start(obj);
    }

    public void Stop()
    {
        //_mutex.WaitOne();
        //
        //
        //
        //_mutex.ReleaseMutex();

        /*lock (_mutexObject)
        {
            this._isWorking = false;    
        }*/

        try
        {
            Monitor.Enter(_mutexObject);
            //..
            //...
            this._isWorking = false;
        }
        finally
        {
            Monitor.Exit(_mutexObject);
        }
    }

    private void Work(object? obj)
    {
        var counter = 0;
        //while(true) - is legitime, but use CAREFULLY
        for (var i = 0; i < this._items.Length; i++)
        {
            var logicIsWorking = false;
            lock (_mutexObject)
            {
                logicIsWorking = this._isWorking;
            }
            if (!logicIsWorking)
                break;

            this._items[i] = this._items[i] * this._items[i];
            Console.WriteLine($"Thread#{this._threadNumber}: {this._items[i]}");
            Thread.Sleep(10);
        }

        /*while (counter < _counterMax && _isWorking)
        {
            Console.WriteLine($"Thread#{this._threadNumber}: {counter}");
            //<====
            counter++;
            
            Thread.Sleep(1);
        }*/
    }
}