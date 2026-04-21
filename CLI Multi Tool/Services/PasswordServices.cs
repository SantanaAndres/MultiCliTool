using CLI_Multi_Tool.Interfaces;
using Spectre.Console;

namespace CLI_Multi_Tool;

public class PasswordServices(IPasswordGeneratorRepo repo): IPasswordServices
{
    public void GeneratePassword()
    {
        
        int howMany = AnsiConsole.Prompt(
            new TextPrompt<int>("[green]How many passwords?[/]")
                .ValidationErrorMessage("[red]Please enter a valid number[/]")
                .Validate(n => n > 0));

        int length = AnsiConsole.Prompt(
            new TextPrompt<int>("[green]Character length?[/]")
                .Validate(n => n > 0));

        for (int i = 0; i < howMany; i++)
        {
            AnsiConsole.MarkupLine($"[blue]Password {i+1}:[/] {repo.GeneratePassword(length)}");
        }
    }
}