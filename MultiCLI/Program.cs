using Aplication.Services;
using Core.Interfaces.Repository;
using Core.Interfaces.Services;
using Infrastructure.Repository;
using Spectre.Console;
using Microsoft.Extensions.Configuration;

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.Development.json", optional: false)
    .Build();

AnsiConsole.MarkupLine("[rgb(0,255,0)]Welcome to CLI Multi Tool!!!!!!!!!!!!!![/]");



ISearchRepo searchRepo = new SearchRepo();
IPasswordGeneratorRepo passwordGeneratorRepo = new PasswordGeneratorRepo();

ISearchService searchService = new SearchService(searchRepo);
IPasswordServices passwordServices = new PasswordServices(passwordGeneratorRepo);
IManager manager  = new Manager(passwordServices, searchService);

var repo = new RequestRepo(configuration);
await repo.CheckBTCPrice();