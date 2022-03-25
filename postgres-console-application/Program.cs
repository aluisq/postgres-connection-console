using postgres_console_application.models;
using postgres_console_application.services;



Console.WriteLine("O que você deseja fazer?");
Console.WriteLine("1 - Visualizar Todas as Campanhas");
Console.WriteLine("2 - Visualizar Campanha Específica");


var opcao = Console.ReadLine();


switch (opcao)
{
    case "1":

        Console.WriteLine("Listando todas as campanhas ...");

        var campanhas = await CampanhaService.getAllCampanhasAsync();

        campanhas.ForEach(campanha => Console.WriteLine(campanha.Id + " - " + campanha.NomeCampanha));

        break;

}

