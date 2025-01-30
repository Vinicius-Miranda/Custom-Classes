using CustomClasses.Classes;
using CustomClasses.Results;

Console.WriteLine("Options:");
Console.WriteLine("1. Client");
Console.WriteLine("2. Facture");
Console.Write("Select your test: ");

string? option = Console.ReadLine();

while(option != "0")
{           
    if(option == "1")
    {
        Client client;
        Console.Write("Enter client name: ");
        string? clientName = Console.ReadLine();
        if(!string.IsNullOrEmpty(clientName))
        {
            client = new(clientName);
            ExecutionResult<Client> executionResult = new(true, client, $"\n{nameof(client)} {client.Name} was created at {client.CreateDateTime:dd/MM/yyyy HH:mm} with the ID {client.Id}\n");
            Console.WriteLine(executionResult.Message);
        }
        else
            Console.WriteLine("Client name is mandatory");
    }
    else if(option == "2")
    {
        Facture facture;
        Console.Write("Enter facture name: ");
        var factureName = Console.ReadLine();
        if(!string.IsNullOrEmpty(factureName))
        {
            facture = new Facture(factureName);
            ExecutionResult<Facture> executionResult = new(true, facture, $"\n{nameof(facture)} {facture.Name} was created at {facture.CreateDateTime:dd/MM/yyyy HH:mm} with the ID {facture.Id}\n");
            Console.WriteLine(executionResult.Message);
        }
        else
            Console.WriteLine("Facture name is mandatory");
    }
    else
    {
        Console.WriteLine("Invalid option");
    }

    Console.Write("Do you want to continue? (y/n): \n");
    string? continueOption = Console.ReadLine();

    if(continueOption != "y")
    {
        Console.WriteLine("Thanks for using the system:");
        break;
    }
    else
    {
        Console.WriteLine("Options:");
        Console.WriteLine("1. Client");
        Console.WriteLine("2. Facture");
        Console.Write("Select your test: ");
        option = Console.ReadLine();
    }
}