# Week 12 - Async Programming

A C# console application demonstrating asynchronous programming with `async/await` by fetching data from the PokeAPI.

## What It Does

This program uses `HttpClient` with `async` and `await` to fetch data for 10 random Pokemon from the PokeAPI. It deserializes the JSON response using `System.Text.Json` into custom classes (`PokemonDetails`, `TypeSlot`, `TypeInfo`) and displays each Pokemon's name, height, weight, and types. Features ASCII art of a Pokeball!

## How to Run

```bash
cd week-12-async-programming
dotnet run
```
