# Phonebook App 📖📱

A **.NET MAUI** application that allows users to store, manage, and access their phonebook contacts efficiently. This project showcases essential features like CRUD operations, SQLite database integration, and a user-friendly interface.

## Features ✨
- Add, edit, and delete contacts.
- View contact details with an intuitive UI.
- Search functionality for quick access.
- Data persistence using **SQLite** for local storage.
- Responsive design for seamless usage across devices.

## Tech Stack 💻
- **Framework:** .NET MAUI
- **Database:** SQLite
- **Language:** C#
- **Tools:** Visual Studio 2022

## Installation 🚀
1. Clone the repository:
   ```bash
   git clone https://github.com/madhur1702/PhonebookApp.git
   ```
2. Open the solution file (`.sln`) in Visual Studio.
3. Ensure you have the necessary .NET SDK and MAUI workloads installed.
4. Build and run the application on your emulator or connected device.

## How to Use 📌
1. **Add Contact:** Tap on the "Add" button and fill in the contact details.
2. **Edit Contact:** Select a contact and tap "Edit" to update details.
3. **Delete Contact:** Swipe left on a contact to remove it from your phonebook.
4. **Search Contact:** Use the search bar to quickly find a contact by name or phone number.

## Project Structure 🗂️
```
PhonebookApp/
├── Models/       # Contains the Contact model
├── Views/        # Contains UI pages like MainPage.xaml
├── ViewModels/   # Contains MVVM logic
├── Services/     # Handles database operations
├── Resources/    # UI resources like styles and images
└── App.xaml      # Application-level configurations
```

## Future Enhancements 🌟
- Add a feature to export contacts to a CSV file.
- Integrate with cloud storage for backup and synchronization.
- Enhance the UI with modern themes and animations.
