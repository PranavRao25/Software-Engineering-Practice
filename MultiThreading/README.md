## Multithreading

| Benefits | Challenges |
| :----    | :----      |
| Concurrency & increased throughput | Complex & Leads to conflicts |
| Improve UI Responsiveness | Race conditions, Starvation & Deadlock |
| Multicore friendly | Priority inversion |

In short, if you know what you are doing while using appropriate libraries, it is possible to mitigate some of the problems mentioned above

### GUI and Threading

There is a main GUI thread which interacts with the elements on the screen
The rest of the worker threads do not interact with it, and instead respond back to GUI thread

### Different Methods of Synchronisation
<ol>
    <li>Mutex</li>
    <li>Critical Sections</li>
    <li>Semaphores</li>
    <li>Monitor/Locks</li>
    <li>Events</li>
</ol>


```
_listenThread = new(new ThreadStart(ListenerThreadProc))
{
    IsBackground = true // Stop the thread when the main thread stops.
};
```

```lock``` keyword is used to setup a critical section in the code.

Setting up Threads with no Synchronisation:
```
private int _totalValueNoSynchronisation = 0;

public void AddOneThousandNoSynchronisation() {
    for(int i=0;i<1000;i++) {
        _totalValueNoSynchronisation++;
    }    
}

public int Run() {
    Thread thread1 = new(AddOneThousandNoSynchronisation);
    Thread thread2 = new(AddOneThousandNoSynchronisation);
    Thread thread3 = new(AddOneThousandNoSynchronisation);

    thread1.Start();
    thread2.Start();
    thread3.Start();
    thread1.Join();
    thread2.Join();
    thread3.Join();

    return _totalValueNoSynchronisation;
}
```

Setting up Threads with Synchronisation:
```
private readonly object _synclock = new ();

private int _totalValueSynchronisation = 0;

public void AddOneThousandSynchronisation() {
    for(int i=0;i<1000;i++) {
        lock(_synclock) {
            _totalValueSynchronisation++;
        }
    }
}

public int Run() {
    Thread thread1 = new(AddOneThousandNoSynchronisation);
    Thread thread2 = new(AddOneThousandNoSynchronisation);
    Thread thread3 = new(AddOneThousandNoSynchronisation);

    thread1.Start();
    thread2.Start();
    thread3.Start();
    thread1.Join();
    thread2.Join();
    thread3.Join();

    int total;
    lock(_synclock) {
        total = _totalValueSynchronisation;
    }
    return total;    
}
```
