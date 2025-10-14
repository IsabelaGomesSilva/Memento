# ⚙️ Project Setup & Execution Guide

This document explains how to set up, build, and run the **Memento Pattern Example** project, as well as its current structure.

---

## 📦 Requirements

Before running the project, make sure you have:

- [.NET SDK 6.0+](https://dotnet.microsoft.com/download) installed  
- A terminal or command prompt  
- A code editor (e.g., [Visual Studio Code](https://code.visualstudio.com/) or [Visual Studio](https://visualstudio.microsoft.com/))  

---

## 🚀 How to Run the Project

1. **Clone the repository**
   ```bash
   git clone https://github.com/IsabelaGomesSilva/Memento.git
   cd Memento

2. **Restore dependencies**
   ```bash
    dotnet restore
3. **Build the project**
   
        dotnet build

5. **Run the project**
   ```bash
    dotnet run --project Memento

# Optional: Run in watch mode (auto rebuild & run on save)
       dotnet watch run --project Memento
# Clean build artifacts
    dotnet clean

# Check installed SDKs
    dotnet --list-sdks

## 📂 Project Structure
Memento/

│

├── Program.cs # Entry point of the application (demo execution)

│

├── 📄 UserNote.cs # Originator - represents the note object

├── 📄 NoteMemento.cs # Memento - stores the note's state

├── 📄 NoteHistory.cs # Caretaker - manages saved states

├── 📄 INoteMemento.cs # Interface for the memento

│

├── 📄 README.md # Main documentation (about the Memento pattern)

└── 📄 SETUP.md # This setup & execution guide
