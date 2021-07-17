## Command

Turns a request into a stand-alone object that contains all information about the request. This transformation lets you pass requests as a method arguments, delay or queue a request’s execution, and support undoable operations.

### Diagram
![image info](./Command_UML.gif)

### When to use it
* When you want to parametrize objects with operations.
* When you want to queue operations, schedule their execution, or execute them remotely.
* When you want to implement reversible operations.

### Resources
* https://refactoring.guru/design-patterns/command
