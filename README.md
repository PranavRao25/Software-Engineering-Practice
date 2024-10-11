# Software Development Lifecycle (SDLC):

## Common SDLC Models:
1. Waterfall
2. Agile
3. Hybrid

### Waterfall
1. Gathering requirements
2. Writing specification document
3. Architecture and Design
4. Development
5. Integration
6. Testing and Validation
7. Deployment
8. Maintainance

### Agile
Continous feedback from customer
The project is divided into iterations; each iterations yield a software build
Flexible to changes

## Fundamentals of Good Software:
1. Good design document
2. Well Designed Components
3. Safe, clean and well structured code
4. Fitting data structures and algorithms
5. Good test matrix

# Programming Models:
1. Structured Programming (SP) -
    Decomposes large monolithic programs into modules using functional decomposition
2. Object Oriented Design (OOD) -
    Associates data with functions allowed to act on that data via objects
3. Component Object Model (COM) -
    Reduces interdependency between objects, using interfaces and object factories for isolation
4. Aspect Oriented Programming (AOP) -
    Seperates program's primary functionality from needed support infrastructure to simply the program's logic

# Object Oriented Design Principles:
1. Abstraction - Providing only the essential (required) details about the data to be used. This 
2. Encapsulation - Hiding the data of a class from any other class, and allowing their access only through certain methods
3. Inheritance - A class will inherit the properties and data of another class (allows reusability & modification)
4. Polymorphism - Ability to let data and methods to exist in multiple forms

## SOLID
1. Single-responsibility principle - Every class should only have one responsibility
2. Open-closed principle - Open for extension, closed for modification (extend a class rather than modifying it)
3. Liskov substitution principle - Clients that use pointers to base classes must be able to use objects of derived classes without knowing it (Every subclass/derived class should be substitutable for their base/parent class without any errors)
4. Interface segregation principle - Clients should not need to depend upon interfaces that they do not use (do not force any client to implement any interfaces which is irrelevant to them)
5. Dependency inversion principle - Use abstractions, promote loose coupling (Classes should depend on interfaces and/or abstract classes instead of concrete class)

## Class Relationships:
1. Inheritance -
```
class A : B {

}
```
2. Composition - A has an attribute of type B which is created in constructor
```
class A {
    private B b;

    public A() {
        B b = new B();
    }
}
```
3. Aggregation - B object is restricted to the scope of a function of A which is created and destroyed within it
```
class A {
    public void SomeMethod() {
        B b = new B();
    }
}
```
4. Using -
```
class A {
    public void SomeMethod(B b) {
        b.function();
    }
}
```

Interfaces are used to enforce a contract between softwares

# Unified Modelling Diagram
1. Module Diagram -
    show dependencies between modules in a project
    no cyclic dependency
    lower level modules should not depend on upper dependencies
2. Class Diagram -
    Diagrams of classes in a module
3. Activity Diagram -
    Sequence of activities between various components in the software project

# GUI Programming

XML - Extensible Markup Language
XAML - Extensible Application Markup Language

## GUI Principles
1. Keep UI Thread responsive. Deleagate to worker threads to unblock the UI Thread
2. Access UI elements only on the UI thread

## UX Design Patterns
1. Model-View-Controller (MVC) 
2. Model-View-Presenter (MVP)
3. Model-View-ViewModel (MVVM)

| MVC | MVP | MVVM |
|:-----|:-----|:------|
|   UI and Model are tightly coupled | UI and Model are loosely coupled | data bindings so easy seperation|
| Controller and View have one-to-many relationship | Presenter and View have one-to-one relationship | ViewModel and View have one-to-many relationship |
View has no knowledge about Controller | View has references to the Presenter | View has references to ViewModel |

### Model View Controller
Controller gives input to Model (user queries) and View (which view to display)
View gives input to the Model (user actions)
User requests are routed to Controller which is reponsible for working with Model for handling queries. The Controller instructs the View to display to the user and provide Model any data it needs

Model has proper business logic
View presenting content
Controller connects View and Model

<img src="mvc.png"
     alt="MVC"
     style="float: left; margin-right: 10px;" />

### Model View Presenter
Derivative of MVC
Presenter is alias to Controller
Instead of having view directly interacting with model, it interacts only with the presenter


<img src="mvp.png"
     alt="MVP"
     style="float: left; margin-right: 10px;" />

#### Data Binding
Binds and synchronises data source from provider and consumer together

### Model View ViewModel
ViewModel is a mediator which automates the communication between View and Model through Data Binding

# Multi-Threading and Inter Process Communication

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

## Interprocess Communication

TO communicate between applications either in the same devices or different devices
Applications are classified as servers or clients. A client is the application which initiates the communication and the server is the application which accepts the communication. Each application is not exclusively client or server and can be either/both of them

IPC is classified in how objects communicate cross-process
<ol>
    <li>Inter Object Communication</li>
    <li>Serialization</li>
</ol>

### Serialization

Here we convert the data into bytes/json/xml type object and send it to the process (this is called serialization)
The type of serialization is the one from which we can easily convert and extract data from
We can also choose to persist the data
JSON can serialise all data, XML will serialize only public members, Binary will serialize complete state of the object and is useful when you want to share the object on disk, memory, or elsewhere
The server will convert the received object and deserialize it (de-serialization)
Named Pipes, Sockets, UDP/TCP clients use this method

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
