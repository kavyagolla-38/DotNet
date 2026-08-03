using System;
using System.Collections.Generic;

class ServiceToken
{
    public int TokenID { get; set; }
    public int Position { get; set; }
    public DateTime TicketDateTime { get; set; }
    public string Status { get; set; }

    public ServiceToken(int tokenId, int position)
    {
        TokenID = tokenId;
        Position = position;
        TicketDateTime = DateTime.Now;
        Status = "Pending";
    }
}

class TicketManager
{
    Queue<ServiceToken> queue = new Queue<ServiceToken>();
    List<ServiceToken> allTokens = new List<ServiceToken>();

    int tokenCounter = 1;

    public void GenerateServiceToken()
    {
        ServiceToken token = new ServiceToken(tokenCounter, queue.Count + 1);
        queue.Enqueue(token);
        allTokens.Add(token);

        Console.WriteLine("Token Created Successfully");
        Console.WriteLine("Token ID : " + token.TokenID);

        tokenCounter++;
    }

    public void GetNextToken()
    {
        if (queue.Count == 0)
        {
            Console.WriteLine("No Tokens Available");
            return;
        }

        ServiceToken token = queue.Peek();

        Console.WriteLine("Next Token");
        Console.WriteLine("Token ID : " + token.TokenID);
        Console.WriteLine("Position : " + token.Position);
        Console.WriteLine("Status : " + token.Status);
    }

    public void UpdateToken(int id)
    {
        bool found = false;

        foreach (ServiceToken token in allTokens)
        {
            if (token.TokenID == id)
            {
                token.Status = "Complete";

                if (queue.Count > 0 && queue.Peek().TokenID == id)
                    queue.Dequeue();

                Console.WriteLine("Token Updated Successfully");
                found = true;
                break;
            }
        }

        if (!found)
            Console.WriteLine("Token Not Found");
    }

    public void SkipToken()
    {
        if (queue.Count < 2)
        {
            Console.WriteLine("Cannot Skip Token");
            return;
        }

        ServiceToken skipped = queue.Dequeue();
        queue.Enqueue(skipped);

        ServiceToken next = queue.Peek();

        Console.WriteLine("Skipped Token : " + skipped.TokenID);
        Console.WriteLine("Next Token : " + next.TokenID);
    }

    public void ListAllTokens()
    {
        if (allTokens.Count == 0)
        {
            Console.WriteLine("No Tokens Available");
            return;
        }

        Console.WriteLine("\nToken Details");

        foreach (ServiceToken token in allTokens)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Token ID : " + token.TokenID);
            Console.WriteLine("Position : " + token.Position);
            Console.WriteLine("Date : " + token.TicketDateTime);
            Console.WriteLine("Status : " + token.Status);
        }
    }
}

class Program
{
    static void Main()
    {
        TicketManager manager = new TicketManager();

        while (true)
        {
            Console.WriteLine("\n******** TOKEN MANAGEMENT SYSTEM ********");
            Console.WriteLine("1. Create Token");
            Console.WriteLine("2. Get Next Token");
            Console.WriteLine("3. Update Token");
            Console.WriteLine("4. Skip Token");
            Console.WriteLine("5. List All Tokens");
            Console.WriteLine("6. Exit");

            Console.Write("Enter Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    manager.GenerateServiceToken();
                    break;

                case 2:
                    manager.GetNextToken();
                    break;

                case 3:
                    Console.Write("Enter Token ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    manager.UpdateToken(id);
                    break;

                case 4:
                    manager.SkipToken();
                    break;

                case 5:
                    manager.ListAllTokens();
                    break;

                case 6:
                    return;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}