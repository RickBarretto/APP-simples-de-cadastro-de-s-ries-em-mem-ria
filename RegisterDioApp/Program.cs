using System;

namespace RegisterDioApp
{
    class Program
    {
        static RepositorySeries repository = new RepositorySeries();
        static void Main(string[] args)
        {
            string userOption = GetUserOption();

            while (userOption.ToUpper() != "X")
            {
                switch(userOption)
                {
                    case "1":
                        _ListSeries();
                        break;
                    case "2":
                        _InsertSerie();
                        break;
                    case "3":
                        _UpdateSerie();
                        break;
                    case "4":
                        _DeleteSerie();
                        break;
                    case "5":
                        _ShowSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                userOption = GetUserOption();
            }
            
        }

        private static void _ListSeries()
        {
            Console.WriteLine("List Series:");

            var list = repository.List();

            if (list.Count == 0)
            {
                Console.WriteLine("[!] - No series registred!");
                return;
            }

            foreach(var serie in list)
            {
                Console.WriteLine("#ID {0} - {1}", serie.ReturnId(), serie.ReturnTitle());
            }

        }

        private static void _InsertSerie()
        {
            Console.WriteLine("Insert a new TV Serie in the App.");

            foreach(int i in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genre), i));
            }

            Console.WriteLine("Write the Genre among the Options.");
            int inputGenre = int.Parse(Console.ReadLine());

            Console.WriteLine("Write the serie title:");
            string inputTitle = Console.ReadLine();

            Console.WriteLine("Write the Serie Year:");
            int inputYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Write a description:");
            string inputDescription = Console.ReadLine();

            Series newSerie = new Series(id          : repository.NextId(),
                                            genre       : (Genre)inputGenre,
                                            title       : inputTitle,
                                            year        : inputYear,
                                            description : inputDescription);

            repository.Insert(newSerie);


        }

        private static void _UpdateSerie()
        {
            Console.WriteLine("Type the serie ID.");
            int indexSerie = int.Parse(Console.ReadLine());

            foreach(int i in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genre), i));
            }

            Console.WriteLine("Type the Genre among the Options:");
            int inputGenre = int.Parse(Console.ReadLine());

            Console.WriteLine("Write the serie title:");
            string inputTitle = Console.ReadLine();

            Console.WriteLine("Write the Serie Year:");
            int inputYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Write a description:");
            string inputDescription = Console.ReadLine();

            Series updateSerie = new Series(id          : indexSerie,
                                            genre       : (Genre)inputGenre,
                                            title       : inputTitle,
                                            year        : inputYear,
                                            description : inputDescription);

            repository.Update(indexSerie, updateSerie);

        }

        private static void _DeleteSerie()
        {
            Console.WriteLine("Type the serie ID.");
            int indexSerie = int.Parse(Console.ReadLine());

            repository.Delete(indexSerie);
        }

        private static void _ShowSerie()
        {
            Console.WriteLine("Type the serie ID.");
            int indexSerie = int.Parse(Console.ReadLine());

            var serie = repository.ReturnById(indexSerie);
            Console.WriteLine(serie);
        }

        private static string GetUserOption()
        {
            Console.WriteLine();
            Console.WriteLine("Choose one of the options bellow:");
            Console.WriteLine("1- Show TV Serie's List");
            Console.WriteLine("2- Add a new TV Serie");
            Console.WriteLine("3- Update a TV Serie");
            Console.WriteLine("4- Delete a TV Serie");
            Console.WriteLine("5- Show a Serie");
            
            Console.WriteLine("C- Clear Screen");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string userOption = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return userOption;
        }
    }
}
