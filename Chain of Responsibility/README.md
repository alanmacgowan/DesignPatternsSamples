## Chain of Responsibility

Lets you pass requests along a chain of handlers. Upon receiving a request, each handler decides either to process the request or to pass it to the next handler in the chain.

### Diagram
![image info](./Chain_of_Responsibility_UML.png)

### When to use it
* When your program is expected to process different kinds of requests in various ways, but the exact types of requests and their sequences are unknown beforehand.
* When it’s essential to execute several handlers in a particular order.
* When the set of handlers and their order are supposed to change at runtime.

### Resources
* https://refactoring.guru/design-patterns/chain-of-responsibility
