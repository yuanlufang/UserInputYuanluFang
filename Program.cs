using System;

namespace UserInputYuanluFang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, this is Yuanlu Fang!");
            Console.WriteLine("Please enter your message below and hit ENTER:");
            string userTypeInMessage;
            userTypeInMessage = Console.ReadLine();
            Console.WriteLine("You input was:");
            Console.WriteLine(userTypeInMessage);
            
        }
    }
}
