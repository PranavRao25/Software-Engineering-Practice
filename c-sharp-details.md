## Access Modifiers
1. public: any class can use this object
2. protected: only the child classes can use this object
3. private: only this class can use this object
4. internal: only the classes within the namespace can use this object
5. protected internal: only the classes within the same assembly or derived classes can use this object
6. private protected: only the derived classes of the same assembly can use this object

## Datatypes
1. Value Types:
- bool, byte, char, decimal, double, float, int, long
- sbyte, short, uint, ulong, ushort
- struct, enum

2. Reference Types:
- class, interface, object, string
- Arrays
- delegate

## Modifiers
- abstract
- async
- const
- event
- extern
- new
- override
- partial
- readonly
- sealed
- static
- unsafe
- virtual
- volatile

## Statement Keywords
- if, else, switch, case, do, for, foreach, in, while, break, yield, await
- continue, goto, return, throw, try, catch, finally, checked
- unchecked
- lock

## Method Parameters
- Value parameters
- Reference parameters (ref)
- Output parameters (out)
- In parameters (in) - read-only reference
- Params array (params)
- Optional parameters

## Namespace Keywords
- namespace
- using
- extern alias

## Generic Types
- Generic classes: class MyClass<T> { }
- Generic interfaces: interface IMyInterface<T> { }
- Generic methods: public T MyMethod<T>(T param) { }
Constraints: where T : class, where T : struct, where T : new(), etc.

## Access Keywords
- base: Access base class members
- this: Refer to the current instance
- typeof: Get the Type of a type

## Literal Keywords
- null: Represents a null reference
- true and false: Boolean literals
- default: Default value of a type

## Contextual Keywords
- var: Implicitly typed local variable
- dynamic: Dynamic type resolution
- value: Used in property setters
- when: Used in catch blocks and switch cases
- nameof: Get the name of a symbol as a string

## Query Keywords
- from, where, select, group, into, orderby, join, let
- in, on, equals, by, ascending, descending
