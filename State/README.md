## State

Lets an object alter its behavior when its internal state changes. It appears as if the object changed its class.

### Diagram
![image info](./State_UML.png)

### When to use it
* When you have an object that behaves differently depending on its current state, the number of states is enormous, and the state-specific code changes frequently.
* When you have a class polluted with massive conditionals that alter how the class behaves according to the current values of the class’s fields.
* When you have a lot of duplicate code across similar states and transitions of a condition-based state machine.

### Resources
* https://refactoring.guru/design-patterns/state
