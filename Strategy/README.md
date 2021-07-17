## Strategy

Lets you define a family of algorithms, put each of them into a separate class, and make their objects interchangeable.

### Diagram
![image info](./Strategy_UML.png)

### When to use it
* When you want to use different variants of an algorithm within an object and be able to switch from one algorithm to another during runtime.
* When you have a lot of similar classes that only differ in the way they execute some behavior.
* To isolate the business logic of a class from the implementation details of algorithms that may not be as important in the context of that logic.
* When your class has a massive conditional operator that switches between different variants of the same algorithm.

### Resources
* https://refactoring.guru/design-patterns/strategy
