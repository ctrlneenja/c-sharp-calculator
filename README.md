# 🧮 Modern Calculator (C# WinForms)

A modern, user-friendly calculator built with **C# Windows Forms**.  
The project demonstrates programming fundamentals, clean UI design, and correct evaluation of expressions using **PEMDAS rules**.  

---
✨ Features

- ✅ Perform **basic arithmetic**: addition, subtraction, multiplication, and division.  
- ✅ Supports **decimal numbers**.  
- ✅ **Parentheses `( )` support** for grouping operations.  
- ✅ **Percentage (%)** calculation.  
- ✅ **Negation (±)** toggle for switching between positive and negative numbers.  
- ✅ **Clear (C)** button to reset the input.  
- ✅ Follows **PEMDAS** (operator precedence) for accurate results.  
- ✅ Responsive and clean design with styled buttons.
  
---
🛠️ Tech Stack

- Language: C#
- Framework: .NET (Windows Forms)
- IDE: Visual Studio

---
📖 How It Works

- Expressions are built inside a single text field (TextBox).
- The DataTable.Compute() method evaluates the entered expression, ensuring PEMDAS rules are followed.
- Parentheses and negation (±) are handled with custom button logic.
  
---
👨‍💻 Code Structure

- Form1.cs → Handles calculator logic and button events.
- Form1.Designer.cs → UI layout and button placement.
- Program.cs → Application entry point.

---
🙏 Acknowledgements

Thanks to Microsoft Documentation for .NET WinForms references.
Inspired by modern smartphone calculator layouts.
Built as part of an academic activity/project to practice:
- Event-driven programming
- UI/UX design in C#
- Debugging and handling exceptions
    
---
📌 Future Improvements

- Add scientific calculator functions (sin, cos, log, etc.).
- Add calculation history panel.
- Implement keyboard input support.

---
📜 License

This project is for educational purposes.
Feel free to fork, improve, and learn from it!
