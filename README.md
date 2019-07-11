# urban-planner
NSS C# exercise utilizing classes to build buildings and cities
Practice: Urban Planner

In this exercise, you are going to define your own Building type and create several instances of it to design your own virtual city.
Create a class named Building in the Building.cs file and define the following fields, properties, and methods.

Also make sure that the class is defined in the same namespace as your program.

Private Fields
_designer of type string. It will hold your name.
_dateConstructed of type DateTime. This will hold the exact time the building was created.
_address of type string.
_owner of type string. This will store the same of the person who owns the building.

Public Properties
Stories typed as an integer.
Width typed as a double.
Depth typed as a double.
Volume should be read-only and should return width * depth * (3 * # of stories). Each story is 3 meters high.
Constructor
Define a constructor method that accepts a single string argument - address -

The constructor's logic should set the _address field's value to the argument value
Public Methods
Define a Construct() method.
Define a Purchase() method.

Build Your City
Create several buildings in the Main() method of Program.cs.
Building FiveOneTwoEigth = new Building("512 8th Avenue");
Give each building a width, height, and number of stories.
Construct each building.
Have business people in your city purchase each of your buildings.
After all of the buildings have been purchased, display the following information to the console for each building.
