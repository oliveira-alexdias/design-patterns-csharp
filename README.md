# Desing Patterns in C# .Net Core 5
This is a simple implementation of the 23 Design Patterns identified by GoF

## What is Desing Patterns?
Design patterns are solutions to software design problems that solves real-world problems in application development. 
They are about reuse designs of objects.

The 23 Gang of Four (GoF) patterns became very popular when the book *Design Patterns: Elements of Reusable Object-Oriented Software* was released back in 1995.
There are three categories or groups or families: Creational, Structural and Behavioral.

## Creational Patterns

**Abstract Factory**: Provide an interfacefor creating families ofrelated or dependent
objects without specifying their concrete classes. *(not implemented yet)*

**Builder**: Separate the construction of a complex object from its representation so
that the same construction process can create different representations. *(not implemented yet)*

**Factory Method**: Define an interface for creating an object,but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to
subclasses.

**Prototype**: Specify the kinds of objectsto create using a prototypical instance, and
create new objects by copying this prototype *(not implemented yet)*

**Singleton**: Ensure a class only has one instance, and provide a global point of
access to it.


## Structural Patterns

**Adapter**: Convert the interface of a class into another interface clients expect.
Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.

**Bridge**: Decouple an abstraction from itsimplementation so that the two canvary
independently. *(not implemented yet)*

**Composite**: Compose objectsinto tree structures to represent part-whole hierarchies. Composite lets clients treat individual objects and compositions of objects
uniformly. *(not implemented yet)*

**Decorator**: Attachadditional responsibilities to an object dynamically.Decorators
provide a flexible alternative to subclassing for extending functionality *(not implemented yet)*

**Facade**: Provide a unified interface to a set of interfacesin a subsystem. Facade
defines a higher-level interface that makesthe subsystem easier to use.

**Flyweight**: Use sharing to support large numbers of fine-grained objects efficiently. *(not implemented yet)*

**Proxy**:  Provide a surrogate or placeholder for another object to control access to
it. *(not implemented yet)*


## Behavioral Patterns

**Chain of Responsability**: Avoid coupling the sender of a request to its receiver by
giving more than one object a chance to handle the request. Chain the receiving
objects and pass the request along the chain until an object handles it

**Command**: Encapsulate a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable
operations.

**Interpreter**: Given a language, define a represention for its grammar along with
an interpreter that uses the representation to interpret sentences in the language *(not implemented yet)*

**Iterator**:  Provide a way to accessthe elements of an aggregate objectsequentially
without exposing its underlying representation. *(not implemented yet)*

**Mediator**: Define an object that encapsulates how a set of objects interact. Mediator promotes loose coupling by keeping objects from referring to each other
explicitly, and it lets you vary their interaction independently

**Memento**: Without violating encapsulation, capture and externalize an object's
internal state so that the object can be restored to this state later *(not implemented yet)*

**Observer**: Define a one-to-many dependency between objectsso that when one
object changes state, all its dependents are notified and updated automatically. *(not implemented yet)*

**State**: Allow an object to alter its behavior when its internal state changes. The
object will appear to change its class. *(not implemented yet)*

**Strategy**: Define a family of algorithms, encapsulate each one, and make them
interchangeable. Strategy lets the algorithm vary independently from clients that
use it. *(not implemented yet)*

**Template Method**: Define the skeleton of an algorithm in an operation, deferring
some steps to subclasses. Template Method lets subclasses redefine certain steps
of an algorithm without changing the algorithm's structure.

**Visitor**: Represent an operation to be performed on the elements of an object
structure. Visitorlets you define a new operation without changing the classesof
the elements on which it operates. *(not implemented yet)*

