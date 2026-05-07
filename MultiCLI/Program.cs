using Aplication.Services;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using Infrastructure.Repository;
using Spectre.Console;
using Microsoft.Extensions.Configuration;

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.Development.json", optional: false)
    .Build();

AnsiConsole.MarkupLine("[rgb(0,255,0)]Welcome to CLI Multi Tool!!!!!!!!!!!!!![/]");



ISearchRepo searchRepo = new SearchRepo();
IPasswordGeneratorRepo passwordGeneratorRepo = new PasswordGeneratorRepo();
IRequestRepo btcRepo = new RequestRepo(configuration);

ISearchService searchService = new SearchService(searchRepo);
IPasswordServices passwordServices = new PasswordServices(passwordGeneratorRepo);
IRequestServices btcServices = new RequestService(btcRepo);
IManager manager  = new Manager(passwordServices, searchService, btcServices);

await manager.serviceManager();