# Interprocess Communication

TO communicate between applications either in the same devices or different devices
Applications are classified as servers or clients. A client is the application which initiates the communication and the server is the application which accepts the communication. Each application is not exclusively client or server and can be either/both of them

IPC is classified in how objects communicate cross-process
<ol>
    <li>Inter Object Communication</li>
    <li>Serialization</li>
</ol>

For IPC, we must first prepare the structure of the communicated object. The Communicated Class has to be decorated as Serializable.

### Serialization

Here we convert the data into bytes/json/xml type object and send it to the process (this is called serialization)
The type of serialization is the one from which we can easily convert and extract data from
We can also choose to persist the data
JSON can serialise all data, XML will serialize only public members, Binary will serialize complete state of the object and is useful when you want to share the object on disk, memory, or elsewhere
The server will convert the received object and deserialize it (de-serialization)
Named Pipes, Sockets, UDP/TCP clients use this method

```
static void RunServer() {
    const int port = 0;
    IPAddress localAddr = IPAddress.Parse("");
    TcpListener server = new TcpListener(localAddr, port);

    server.Start();

    byte[] bytes = new byte[256];

    int running = True;
    const string quit = "quit";
    while(running) {
        using(TcpClient client = new TcpClient()) {
            using(NetworkStream stream = client.GetStream()) {
                int i;         
                do {
                    i = stream.Read(bytes, 0, bytes.length);
                    string input = Encoding.ASCII.GetString(bytes, 0, i);
                    processing = !input.Equals(quit);

                    if(!string.IsNullOrEmpty(input) && processing) {
                        string reply = GetSerializedReply();
                        byte[] output = Encoding.ASCII.GetBytes(reply);
                        stream.Write(output, 0, output.Length);
                    }
    `           } while(i!=0);
            }
        }
    }

    server.Stop();
}
```

### Inter Object Communication

Allows clients to communicate directly with each other by sharing the objects
This is through <b>Marshalling</b> process which is a mechanism by which an object that is accessible to one process can be made accessible to another process by underlying IPC method
This is to add more abstractions or ease of work to the communication process
.NET Remoting, COM (Component Object Model), RPC (Remote Procedure Call)

Benefits:
Isolation - the code runs on a different process, so the security of the current process is maintained

Challenges:
1. Security, Elevation of privilege: A high privilege process passing data to low privilege process can compromise the security of the data
2. Snooping: Data being passed can be read or modified by 3rd party
3. Performance: more expensive than in process work
