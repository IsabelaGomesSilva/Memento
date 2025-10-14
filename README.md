# 📝 Memento Pattern Example

Welcome to **Memento**, a simple C# project created to demonstrate the **Memento Design Pattern** in action.  
This repository is a great way to understand how to save and restore the state of an object without breaking its encapsulation.  

---

## 🎯 What is the Memento Pattern?

The **Memento Pattern** is a **behavioral design pattern** that allows you to:

- Capture and save an object’s internal state (snapshot) ✅  
- Restore the object to a previously saved state 🔄  
- Do all of this **without exposing the object’s internal details** 🔒  

It’s commonly used to implement features such as **Undo/Redo**, **state history**, and **version control**.

---

## 🧩 Pattern Participants

The pattern usually involves three main parts:

1. **Originator**  
   - The object whose state we want to save/restore.  
2. **Memento**  
   - Stores the internal state of the Originator.  
3. **Caretaker (History Manager)**  
   - Keeps track of mementos and decides when to save or restore the state.  

---

## 💻 How this project works

This project demonstrates the Memento pattern through a simple **note-taking application**.

- `UserNote` → **Originator**  
  Represents a note created by the user. It can be edited and changed.  

- `NoteMemento` → **Memento**  
  Stores the snapshot (state) of the note at a specific moment in time.  

- `NoteHistory` → **Caretaker**  
  Manages the history of all note versions. It can save states and restore them when needed.  

- `INoteMemento` → **Interface**  
  Provides a contract that defines what a memento must implement.  

The `Program.cs` file demonstrates how to use these classes to **save**, **modify**, and **restore** notes.

---

## 📚 Example Flow

Here’s how the application demonstrates the pattern:

1. A user creates a new note 📝  
2. The current state is saved into the history ✅  
3. The user edits the note ✏️  
4. If needed, the user can restore a previous state from history 🔄  

This mimics how "Undo" or "history restore" works in real-world applications.

---

## ⚡ Example Code (simplified)

```csharp
// Create a note
var note = new UserNote("First version of the note");

// Save the state
var history = new NoteHistory();
history.Save(note.SaveState());

// Modify the note
note.Content = "Edited version of the note";

// Restore the previous state
note.RestoreState(history.GetLast());
Console.WriteLine(note.Content); // Output: "First version of the note"

