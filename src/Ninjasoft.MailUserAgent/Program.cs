using System.Net.Sockets;

Welcome.Execute();
if(!Authenticate.Execute())
{
    Console.WriteLine("Goodbye");
    return;
}

while(true)
{
    Console.WriteLine("1. Check Mail");
    Console.WriteLine("2. Send Mail");
    Console.WriteLine("9. Exit");
    Console.Write("Select an option: ");

    string? input = Console.ReadLine();
    if(string.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("Invalid input. Press any key to continue");
        Console.ReadLine();
        Console.Clear();
        continue;
    }
    if(!int.TryParse(input, out int option))
    {
        Console.WriteLine("Invalid input. Press any key to continue");
        Console.ReadLine();
        Console.Clear();
        continue;
    }
    if(option < 1 || option > 3)
    {
        Console.WriteLine("Invalid input. Press any key to continue");
        Console.ReadLine();
        Console.Clear();
        continue;
    }

    switch(option)
    {
        case 1:
            Console.WriteLine("Checking mail");
            using(TcpClient tcpClient = new TcpClient())
            {
                tcpClient.Connect("pop3.domain.com", 995);
                tcpClient.Connect("imap4.domain.com", 993);
            }
            break;
        case 2:
            Console.WriteLine("To: ");
            Console.WriteLine("Cc: ");
            Console.WriteLine("Bcc: ");
            Console.WriteLine("Subject: ");
            Console.WriteLine("Body: ");
            
            using(TcpClient tcpClient = new TcpClient())
            {
                byte[] data = System.Text.Encoding.ASCII.GetBytes("");
                tcpClient.Connect("msa.domain.com", 587);
                tcpClient.Connect("smtp.domain.com", 587);
                NetworkStream ns = tcpClient.GetStream();
                ns.Write(data, 0, data.Length);


                // Buffer to store the response bytes.
                data = new Byte[256];

                // String to store the response ASCII representation.
                string responseData = string.Empty;

                // Read the first batch of the TcpServer response bytes.
                int bytes = ns.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            }
            Console.WriteLine("Sending mail");
            break;
        case 9:
            Console.WriteLine("Goodbye");
            return;
        default:
            break;
    }
}