# Election Vote Counter

A C# console application that manages election data for multiple candidates, developed as part of the ITDEV-115 course.

## Features

- Collect names and vote counts for 5 candidates
- Calculate voting percentages for each candidate
- Determine and display the winner
- Clean console-based user interface

## How It Works

1. The program prompts the user to enter the name of each candidate
2. For each candidate, the user enters their vote count
3. The program calculates the percentage of total votes for each candidate
4. Results are displayed in a table showing name, votes, and percentage
5. The winner is announced based on highest vote count

## Technical Highlights

- **Object-Oriented Design**: Separates business logic (Election class) from user interface (ElectionUI)
- **Exception Handling**: Validates index ranges to prevent errors
- **LINQ Methods**: Uses LINQ's Max() and Sum() functions for data analysis
- **String Formatting**: Formats display outputs for readability

## Project Structure

- `Election.cs`: Core class managing candidate data and vote calculations
- `ElectionUI.cs`: Handles user interface and display logic
- `Program.cs`: Entry point for the application

## Building and Running

This project can be compiled with Visual Studio or any .NET-compatible IDE. It targets .NET Framework 4.7.2.

## Author:
Domeneak Addison
