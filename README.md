# Geometric Shapes Report - Refactoring Challenge

## Overview
This project is a refactored version of a legacy C# application that calculates areas and perimeters for various geometric shapes and generates a formatted report. 

The main goal was to eliminate code smells (such as monolithic `switch` statements and static state) and apply Object-Oriented Programming (OOP) principles to make the system extensible, maintainable, and testable.

## Key Features & Improvements

- **Polymorphism over Conditionals:** Replaced the giant `switch` statements with a robust abstract `Shape` class and concrete implementations (`Square`, `Circle`, `EquilateralTriangle`, `Rectangle`, `Trapezoid`).
- **New Shapes Added:** Implemented `Rectangle` and `Trapezoid` calculations while respecting the original design contract.
- **Internationalization (i18n):** Fully localized reports supporting **Spanish**, **English**, and **Italian** using `ResourceManager` (`.resx` files).
- **Decoupled Localization:** Created a `LanguageHelper` to handle culture-specific formatting (e.g., commas vs. dots for decimals) and text retrieval, removing localization responsibilities from the shape models.

## Architecture & Principles

- **Single Responsibility Principle (SRP):** Models only handle math. The `ShapeReportService` handles HTML generation. The `LanguageHelper` handles translations.
- **Open/Closed Principle (OCP):** Adding a new shape requires creating a new class and adding its translation key, without modifying the reporting logic.
- **Clean Code:** Standardized variable and method names in English, removed magic strings, and applied the `AAA` (Arrange, Act, Assert) pattern in tests.

## Testing

The project includes a comprehensive suite of unit tests written with **NUnit**:
- **Backward Compatibility:** All original tests provided in the challenge still pass.
- **New Functionality:** Added test coverage for the new shapes (`Rectangle`, `Trapezoid`) and the new language (`Italian`).

## Technologies Used
- **C#** (.NET Framework)
- **NUnit** (Testing Framework)
- **ResourceManager** (Localization)

## How to Run
1. Clone this repository.
2. Open the `DevelopmentChallenge.sln` file in Visual Studio.
3. Build the solution (`Ctrl + Shift + B`).
4. Open the **Test Explorer** (`Test > Test Explorer`) and click **Run All** to see the full green suite.