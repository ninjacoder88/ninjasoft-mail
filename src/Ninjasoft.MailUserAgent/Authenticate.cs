public static class Authenticate
{
    public static bool Execute()
    {
        while(true)
        {
            //Console.WriteLine("outgoing mail server: pop.ninjasoft.dev");
            //Console.WriteLine("port: 465")


            Console.Write("username: ");
            string? username = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(username))
            {
                Console.WriteLine("error - invalid username");
                return false;
            }

            Console.Write("password: ");
            string? password = Console.ReadLine();
            if(string.IsNullOrEmpty(password))
            {
                Console.WriteLine("error - invalid password");
                return false;
            }

            Console.WriteLine("info - logging in");
            return true;
        }
    }
}