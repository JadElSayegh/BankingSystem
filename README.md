# Revisiting C# Foundations — Banking System

A console-based banking system built with raw C# to reinforce core programming fundamentals 

This project focuses on strengthening practical understanding of:
- Variables
- Functions
- Input/Output
- Loops
- Conditional logic
- Error handling
- State management

The goal is not to build a production banking platform. The goal is to rebuild strong programming fundamentals through repetition and structured problem solving.

---

# Features

## 1. Deposit System

Allows the user to deposit money into the account balance.

### Concepts Practiced
- Numeric variables
- User input
- Validation
- Arithmetic operations

### Example
Enter deposit amount: 500  
Deposited 500

---

## 2. Withdrawal System

Allows money withdrawal while preventing invalid transactions.

### Validation Rules
- Cannot withdraw negative values
- Cannot exceed account balance
- Rejects invalid input

### Concepts Practiced
- Conditional statements
- Comparison operators
- Error handling

### Example
Insufficient funds.

---

## 3. Balance Tracking

Displays the current account balance.

### Concepts Practiced
- Shared program state
- Variables
- Output formatting

### Example
Current balance: 1200

---

## 4. Interactive Menu System

The application continuously runs until the user exits manually.

### Concepts Practiced
- Loops
- Switch statements
- Program flow control

### Example
1. Deposit  
2. Withdraw  
3. Show Balance  
4. Exit

---

## 5. Error Handling

Prevents the application from crashing on invalid input.

### Concepts Practiced
- try/catch
- Exception handling
- Defensive programming

### Example
Invalid number.

---

# Technical Goals

This project was built specifically to revisit and reinforce:

| Concept          | Usage                                 |
|------------------|---------------------------------------|
| Variables        | Balance tracking and user input       |
| Functions        | Feature separation and reusable logic |
| Loops            | Persistent menu system                |
| Conditionals     | Transaction validation                |
| Input/Output     | Console interaction                   |
| Error Handling   | Preventing runtime crashes            |
| State Management | Maintaining account balance           |

---

# Current Architecture

The project currently uses:
- Procedural programming
- Static methods
- Shared balance state

This keeps the code simple while revisiting core syntax and program flow.

---

# Example Run

=== BANK MENU ===  
1. Deposit  
2. Withdraw  
3. Show Balance  
4. Exit  

Choose an option: 1  

Enter deposit amount: 500  
Deposited 500  

---

# Technologies Used

- C#
- .NET Console Application
- Visual Studio

---

# Learning Outcome

This project serves as a practical reset of C# fundamentals by rebuilding core programming habits through hands-on implementation rather than theory alone.