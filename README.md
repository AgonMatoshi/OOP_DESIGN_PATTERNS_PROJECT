# OOP_DESIGN_PATTERNS_PROJECT

# Online Food Delivery System
This project is a group effort aimed at developing an online food delivery service where users can conveniently order from various restaurants. The software solution incorporates several design patterns to ensure efficiency, flexibility, and scalability.

## Project Structure
The project consists of the following files and directories:

 ### DatabaseConnectionSingleton:
 Contains the implementation of a Singleton pattern for efficient database connections.
### Iterator:
Implements the Iterator pattern. (Details of implementation not provided)
### OrderObserver:
Incorporates the Observer pattern to notify stakeholders about order updates.
### PaymentAdapter: Utilizes the Adapter pattern to handle multiple payment methods.
### bin/Debug/net8.0:
Directory containing debug binaries.
### obj:
Directory containing object files.
### OnlineFoodDelivery.csproj: 
Project file.
### Program.cs:
Entry point of the application.
## Design Patterns Implemented
Singleton Pattern: The DatabaseConnectionSingleton ensures that there is only one instance of the database connection object, which helps in efficient resource utilization and ensures thread safety.

Adapter Pattern: The PaymentAdapter module adapts multiple payment methods to a unified interface, allowing seamless integration with the online food delivery system.

Observer Pattern: The OrderObserver module facilitates the notification of stakeholders about order updates. This pattern decouples the subject (order) from its observers (stakeholders), allowing for better maintainability and extensibility.

Additional Patterns Considered
Composite Pattern: Though not implemented in the provided files, the Composite pattern could be considered for representing menus and items within the menu hierarchically, allowing for easy manipulation of complex menu structures.
Deliverables
Documented Report: A comprehensive report detailing the developed solution, the design patterns used, and their implementation. Additionally, it documents the software requirements based on research on similar tools.

Working Demo: A functioning demonstration of the solution. This could be either a deployed solution accessible via a web link or an installable package along with setup instructions.

Source Code: The source code of the solution, developed using an object-oriented programming language. The code is available in a Git repository, facilitating collaboration and version control.
