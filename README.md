Short Answer

1. What are the six combinations of access modifier keywords and what do they do?
public: Accessible from any code.
private: Accessible only within the containing class or struct.
protected: Accessible within the containing class or derived classes.
internal: Accessible within the same assembly but not from another assembly.
protected internal: Accessible within the same assembly or from derived classes.
private protected: Accessible within the containing class or derived classes within the same assembly.
2. What is the difference between the static, const, and readonly keywords when applied to a type member?
static: Indicates that the member belongs to the type itself rather than to a specific object. It can be accessed without creating an instance of the class.
const: Indicates that the value of the member is a compile-time constant and cannot be changed.
readonly: Indicates that the member can be assigned a value only during declaration or in a constructor of the same class.
3. What does a constructor do?
A constructor is a special method that is called when an instance of a class is created. It is used to initialize the object, setting initial values for its fields or properties.

4. Why is the partial keyword useful?
The partial keyword allows the definition of a class, struct, or interface to be split across multiple files. This is useful for organizing code, especially in large projects or when using code generation tools.

5. What is a tuple?
A tuple is a data structure that can hold a fixed number of items, each of a potentially different type. It is useful for grouping multiple values together without creating a custom class.

6. What does the C# record keyword do?
The record keyword defines a reference type that provides built-in functionality for value equality, immutability, and concise syntax for defining data classes.

7. What does overloading and overriding mean?
Overloading: Defining multiple methods with the same name but different parameters within the same class.
Overriding: Providing a new implementation for a method in a derived class that was defined in a base class.
8. What is the difference between a field and a property?
Field: A variable that is declared directly in a class or struct.
Property: A member that provides a flexible mechanism to read, write, or compute the value of a private field, typically using getters and setters.
9. How do you make a method parameter optional?
You make a method parameter optional by providing a default value for it in the method signature.

csharp
Copy code
void MyMethod(int x, int y = 10)
{
    // y is optional
}
10. What is an interface and how is it different from an abstract class?
Interface: A contract that defines a set of methods and properties that the implementing class must provide. It cannot contain implementation.
Abstract Class: A class that can contain both abstract methods (without implementation) and concrete methods (with implementation). It can also have fields and constructors.
11. What accessibility level are members of an interface?
Members of an interface are always public by default.

12. True/False. Polymorphism allows derived classes to provide different implementations of the same method.
True

13. True/False. The override keyword is used to indicate that a method in a derived class is providing its own implementation of a method.
True

14. True/False. The new keyword is used to indicate that a method in a derived class is providing its own implementation of a method.
True (But note that it is used to hide the base class method, not override it.)

15. True/False. Abstract methods can be used in a normal (non-abstract) class.
False

16. True/False. Normal (non-abstract) methods can be used in an abstract class.
True

17. True/False. Derived classes can override methods that were virtual in the base class.
True

18. True/False. Derived classes can override methods that were abstract in the base class.
True

19. True/False. In a derived class, you can override a method that was neither virtual nor abstract in the base class.
False

20. True/False. A class that implements an interface does not have to provide an implementation for all of the members of the interface.
False

21. True/False. A class that implements an interface is allowed to have other members that aren’t defined in the interface.
True

22. True/False. A class can have more than one base class.
False

23. True/False. A class can implement more than one interface.
True
True
