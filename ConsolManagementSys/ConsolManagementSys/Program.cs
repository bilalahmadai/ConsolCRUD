using ClassLibrary;

Student std_obj = new Student();
Book book_obj = new Book();
string choice = "a";

void BookMenu()
{
    while (choice != "q")
    {
        {
            Console.WriteLine("-----Book-----");
            Console.WriteLine("1: Add");
            Console.WriteLine("2: Retrive");
            Console.WriteLine("3: Search");
            Console.WriteLine("4: Update");
            Console.WriteLine("5: Delete");
            Console.WriteLine("q: Exit");
            Console.WriteLine("Choose from Menu");
            choice = Console.ReadLine();
            Console.Clear();

            if (choice == "1")
            {
                book_obj.creatBook();
            }
            else if (choice == "2")
            {
                book_obj.viewBook();
            }
            else if (choice == "3")
            {
                Console.Write("Please enter student id >> ");
                int query = Convert.ToInt32(Console.ReadLine());
                book_obj.searchBook(query);
            }
            else if (choice == "4")
            {
                Console.Write("Please enter student id >> ");
                int query = Convert.ToInt32(Console.ReadLine());
                book_obj.updateBook(query);
            }
            else if (choice == "5")
            {
                Console.Write("Please enter student id >> ");
                int query = Convert.ToInt32(Console.ReadLine());

                book_obj.deleteBook(query);
            }

            else
            {
                Console.WriteLine("not Valid");
            }

        }
    }
}


void StudentMenu() {
    while (choice != "q")
    {
        {
            Console.WriteLine("-----Student-----");
            Console.WriteLine("1: Add");
            Console.WriteLine("2: Retrive");
            Console.WriteLine("3: Search Student");
            Console.WriteLine("4: Update");
            Console.WriteLine("5: Delete");
            Console.WriteLine("q: Exit");
            Console.WriteLine("Choose from Menu");
            choice = Console.ReadLine();
            Console.Clear();

            if (choice == "1")
            {
                std_obj.creatStudent();
            }
            else if (choice == "2")
            {
                std_obj.viewStudent();
            }
            else if (choice == "3")
            {
                Console.Write("Please enter student id >> ");
                int query = Convert.ToInt32(Console.ReadLine());
                std_obj.searchStudent(query);
            }
            else if (choice == "4")
            {
                Console.Write("Please enter student id >> ");
                int query = Convert.ToInt32(Console.ReadLine());
                std_obj.updateStudent(query);
            }
            else if (choice == "5")
            {
                Console.Write("Please enter student id >> ");
                int query = Convert.ToInt32(Console.ReadLine());

                std_obj.deleteStudent(query);
            }

            else
            {
                Console.WriteLine("not Valid");
            }

        }
    }
}
   

string menu = "b";
while (menu != "w")
{

    Console.WriteLine("-----Management Sys-----");
    Console.WriteLine("1: Student");
    Console.WriteLine("2: Book");
    Console.WriteLine("w: Exit");

    menu = Console.ReadLine();
    Console.Clear();

    if (menu == "1")
    {
        StudentMenu();
        choice = "a";

    }
   else if (menu == "2")
    {
        BookMenu();
        choice = "a";
    }
    else if (menu == "w")
    {
        break;
    }
    else {
        Console.WriteLine("invalid cmd");
    }

}

