## Observer

Lets you define a subscription mechanism to notify multiple objects about any events that happen to the object they’re observing.

### Diagram
![image info](./Observer_UML.png)

### When to use it
* When changes to the state of one object may require changing other objects, and the actual set of objects is unknown beforehand or changes dynamically.
* When some objects in your app must observe others, but only for a limited time or in specific cases.

### Resources
* https://refactoring.guru/design-patterns/observer
