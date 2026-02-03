# Week 10 - File Input/Output

A C# console application demonstrating file I/O and JSON deserialization.

## What It Does

This program reads a JSON file (`reading-list.json`) containing filament spool data, deserializes it into a `List<FilamentSpool>` using `System.Text.Json`, and displays detailed information about each spool including brand, color, material, diameter, weight, and remaining percentage. It uses a C# record type for the data model.

## How to Run

```bash
cd week-10-file-input-output
dotnet run
```
