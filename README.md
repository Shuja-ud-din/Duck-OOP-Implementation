# 🦆 Duck OOP Implementation

This project demonstrates a simple implementation of Object-Oriented Programming (OOP) principles using a `Duck` class in C#. The `Duck` class includes methods for quacking, swimming, displaying, and flying. Different types of ducks are implemented using inheritance and behavior interfaces.

## 📂 Directory Structure

```
Duck-OOP-Implementation/
│
├── src/
│   ├── Duck.cs
│   ├── Behaviuors.cs
│
├── .gitignore
├── Duck-OOP-Implementation.sln
├── duck.csproj
├── LICENSE
├── Program.cs
└── README.md
```

## 🛠️ Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.

## 🚀 Getting Started

Follow these steps to run the program:

1. **Clone the repository:**
   ```sh
   git clone https://github.com/Shuja-ud-din/Duck-OOP-Implementation.git
   ```
2. **Navigate to the project directory:**
   ```sh
   cd Duck-OOP-Implementation
   ```
3. **Open the project in your preferred IDE (e.g., Visual Studio, Visual Studio Code).**

4. **Build the project:**

   - If you are using Visual Studio, click on `Build > Build Solution`.
   - If you are using the command line, navigate to the project directory and run:
     ```sh
     dotnet build
     ```

5. **Run the program:**
   - If you are using Visual Studio, click on `Debug > Start Debugging`.
   - If you are using the command line, navigate to the project directory and run:
     ```sh
     dotnet run
     ```

## 📄 Project Files

- **Duck.cs:** Contains the `Duck` class and its derived classes (`Mallard`, `RedheadDuck`, `RubberDuck`, `DecoyDuck`) with methods for quacking, swimming, displaying, and flying.
- **Behaviuors.cs:** Contains the behavior interfaces (`FlyBehavior`, `QuackBehavior`) and their implementations (`FlyWithWings`, `FlyNoWay`, `Quack`, `Squeak`, `MuteQuack`).
- **Program.cs:** Contains the `Main` method which creates instances of different duck types and calls their methods.

## 🖥️ Example Output

When you run the program, you should see the following output in the console:

```
I am a Mallard
I'm flying with wings
Quack Quack
I am swimming!
I am a Redhead Duck
I'm flying with wings
Quack Quack
I am swimming!
I am a Rubber Duck
 I'll never fly
Squeak
I am swimming!
I am a Decoy Duck
 I'll never fly
Silence
I am swimming!
```

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
