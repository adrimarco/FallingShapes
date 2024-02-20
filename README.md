# Falling Shapes

Falling Shapes is a simple 2D game that demonstrates Object-Oriented Programming (OOP) principles, created for a Unity Learn course. The game involves shapes falling from the top of the screen, requiring players to click on them to earn points.

Scripts can be found inside the `Assets/Scripts` folder, and they include comments explaining how OOP principles have been applied.

The OOP principles showcased in this project are:

* **Inheritance:** The creation of a base class from which other classes (child classes) can be derived. The base class contains all the fundamental atributes and methods common to objects of this class or any subclass. Child classes inherit all features of the base class and can modify them or create their own. In this project, `Shape` is a base class, from which `Circle`, `Star`, and `Triangle` inherit.

* **Polymorphism:** The creation of multiple methods with the same name to make them easy to understand and use, but with different implementations. This can be achieved in two ways. With method overloading, multiple methods can share the same name, and the appropriate one is called based on the parameters provided in the call. An example can be found in the `Shape` script. The other way is through method overriding, where a child class modifies a method of the base class so that it behaves differently. Examples of this can be seen in the `Circle`, `Star`, and `Triangle` scripts, where methods from the `Shape` script are overridden.

* **Abstraction:** Creating clean and easy-to-understand code to simplify programming. This is achieved by creating properly named methods that perform specific tasks. It helps in developing more complex functionality, and other developers can use them, understanding their intended purpose rather than their implementation details. Although this principle should be applied throughout the code, there are specific examples in the `Shape`, `Circle`, and `Spawner` scripts.

* **Encapsulation:** Hiding object attributes and restricting their access to other classes to ensure they are used as intended and to prevent errors. Like abstraction, this can be observed in all variables of the scripts, with specific examples highlighted in the `GameManager` and `Shape` scripts.