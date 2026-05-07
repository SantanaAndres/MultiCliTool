using Domain.Interfaces.Services;
using Spectre.Console;

namespace Aplication.Services;

public class Manager(
    IPasswordServices passwordServices, 
    ISearchService searchService,
    IRequestServices requestServices
    ): IManager
{
    public async Task serviceManager()
    {
        while (true)
        {
            var opcion = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("[yellow]¿Qué quieres hacer?[/]")
                    .PageSize(10)
                    .AddChoices(new[] {
                        "🔍 Buscar archivo", 
                        "🔐 Generar contraseñas", 
                        "₿ Precio BTC", 
                        "🚪 Salir"
                    }));

            switch (opcion)
            {
                case "🔍 Buscar archivo":
                    searchService.Search();
                    break;
                case "🔐 Generar contraseñas":
                    passwordServices.GeneratePassword();
                    break;
                case "₿ Precio BTC":
                    await requestServices.CheckBTCPrice();
                    break;
                case "🚪 Salir":
                    AnsiConsole.Markup("[green]¡Hasta luego![/]");
                    return;
            }
        
            AnsiConsole.Markup("\n[dim]Presiona cualquier tecla para continuar...[/]");
            Console.ReadKey();
            Console.Clear();
        }
    }
}