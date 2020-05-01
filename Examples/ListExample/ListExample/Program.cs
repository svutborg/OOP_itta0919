using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();

            int choise;
            bool running = true;
            while(running)
            {
                choise = printMenu();
                Console.WriteLine(choise);
                switch(choise)
                {
                    case 1:
                        AddUser(users);
                        break;
                    case 2:
                        RemoveUser(users);
                        break;
                    case 3:
                        PrintUsers(users);
                        break;
                    case 4:
                    default:
                        running = false;
                        break;
                }              
            }
            Console.Read();
        }

        static int printMenu()
        {
            Console.WriteLine("Choose option");
            Console.WriteLine("1: Add user");
            Console.WriteLine("2: Remove user");
            Console.WriteLine("3: Print users");
            Console.WriteLine("4: Exit");

            int result = -1;
            int.TryParse(Console.ReadLine(), out result);
            return result;
        }

        static void PrintUsers(List<User> users)
        {
            Console.WriteLine("=========Users=========");
            foreach(User u in users)
            {
                Console.WriteLine(u);
            }
            Console.WriteLine("=====End of users======");
        }

        static void AddUser(List<User> users)
        {
            // generate unique ID
            int iD = 1;
            while(users.Exists(u => u.ID == iD))
            {
                iD++;
            }
            User newUser = new User("", "", iD);
            
            Console.WriteLine("Enter new user:");
            Console.Write("Enter first name: ");
            newUser.Name = Console.ReadLine();
            Console.Write("Enter surname: ");
            newUser.Surname = Console.ReadLine();

            users.Add(newUser);
        }
        static void RemoveUser(List<User> users)
        {
            Console.WriteLine("Enter the ID of the user to be removed:");
            int choise;
            if (int.TryParse(Console.ReadLine(), out choise))
            {
                User u = users.Find(x => x.ID == choise);
                Console.WriteLine($"Removing user: {u}");
                users.Remove(u);
            }
        }
    }
}
