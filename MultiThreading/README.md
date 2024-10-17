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
