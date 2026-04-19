using CLI_Multi_Tool;
using Spectre.Console;

// Console.WriteLine("En que directorio desea buscar el archivo");

// var userInput = Console.ReadLine();

Repo repo = new Repo();

AnsiConsole.MarkupLine("[green]✓ Build completed successfully[/]");

Console.WriteLine(repo.Search());