namespace System{
public static class MyNotes
{
    public static string VariablesPageOne = @"...
In the vast savannah of computer memory, a remarkable phenomenon occurs. 
Behold, the magnificent 'variables' – they are the vessels of information, the heart of computation. 
They bear names, bestowed upon them with care, starting only with letters or the humble underscore. 
But tread with caution, for certain names are forbidden, like 'int', 'string', and 'bool'. 
With the gentle touch of the '=' operator, values are imbued unto these variables. 
And lo, their types can be declared, like incantations, as in 'type variableName = value;'. 
Observe: 
 int age = 32;
 string name = ""Jesper"";
 float awesomeLevel = 99.9f;
 bool TooCoolForSchool = false;
";

    public static string VariablesPageTwo =
@"...
So often used without consideration for its magnificence, the humble 'variable' is the heart of computation. 
It can be used to store and manipulate data, and is the backbone of all computer programs. 
The 'variable' is a named container for a value, and can be of different types. 
The type of a variable determines what kind of value it can hold, and what kind of operations can be performed on it. 
There are many different types of variables, but the most common ones are 'int', 'string', 'float', and 'bool'. 
An 'int' is a whole number, like 1, 2, 3, 4, 5, 6, 7, 8, 9, 0. 
A 'string' is a sequence of characters, like ""Hello World"", ""I am a string"", and ""C# is awesome"". 
A 'float' is a decimal number, like 1.234, 5.678, and 9.101112. 
A 'bool' is a true or false value, like true and false. ";
        public static string ClassPageOne = @"...
            Imagine a grand architectural design in the world of programming – behold the 'class.' 
            Classes are blueprints, the masterminds behind creating objects. 
            They are the foundation of object-oriented programming, combining data (attributes) and functionality (methods) into a cohesive unit. 
            A class defines the structure and behavior an object will possess. 
            Much like a cookie cutter shapes cookies, a class molds objects, giving them distinct characteristics and capabilities.
            To create a class, use the 'class' keyword followed by a name, and within its curly braces, you define fields and methods.
            Observe:
            
            public class Person
            {
                public string Name;
                public int Age;
                
                public void SayHello()
                {
                    Console.WriteLine(""Hello, I am "" + Name);
                }
            }
        ";

        public static string ClassPageTwo = @"
            ...
            The world of programming is brimming with complex ideas, but 'classes' serve as the cornerstone of organization and structure. 
            Just as an architect plans a building, a programmer crafts classes to model real-world entities or abstract concepts.
            Inside a class, you can declare fields, which are like attributes that hold data, and methods, which define actions the object can perform.
            For instance, a 'Person' class might have 'Name' and 'Age' fields and a 'SayHello' method to greet people.
            Objects created from these classes inherit their attributes and methods.
            Classes enable code reusability and encapsulation, fostering a modular and clean code design.
            They form the basis for managing complexity and building scalable software systems.
";

 public static string InheritancePageOne = @"...
            In the realm of object-oriented programming, there exists a powerful concept known as 'inheritance.' 
            Imagine a family tree, where traits, characteristics, and abilities are passed down from generation to generation. 
            In C#, inheritance allows one class to acquire the properties and behaviors of another class. 
            The class that provides the features is called the 'base' or 'parent' class, while the one inheriting is the 'derived' or 'child' class. 
            This allows you to create a new class based on an existing one, reusing and extending its functionality. 
            Derived classes inherit fields, methods, and properties from their base classes, promoting code reuse and fostering a hierarchical structure.
            To establish inheritance, use the ':' symbol followed by the base class name when defining a new class.
            Observe:
            
            public class Animal
            {
                public string Name;
                
                public void Speak()
                {
                    Console.WriteLine(""Animal speaks."");
                }
            }
            
            public class Dog : Animal
            {
                public void Bark()
                {
                    Console.WriteLine(""Dog barks."");
                }
            }
        ";

        public static string InheritancePageTwo = @"
            ...
            Inheritance empowers you to model relationships between objects and build upon existing functionality. 
            The 'Dog' class in the example inherits the 'Name' field and 'Speak' method from the 'Animal' class. 
            It can also introduce its unique attributes and methods, like 'Bark.' 
            Inheritance forms the basis for polymorphism and code organization. 
            Derived classes can be used interchangeably with their base classes, promoting flexibility and extensibility. 
            However, remember that C# supports single inheritance only, meaning a class can inherit from one base class. 
            If you need to reuse functionality from multiple sources, consider interfaces, a concept similar to inheritance but with more flexibility.
        ";
/*
all taken from chatgpt ofc
*/
}}