using System;

namespace ClassLibrary
{


    public class Book
    {
        int id;
        string name;
        string Issued_to;

        string Book_file = "Book.dat";



        public void creatBook()
        {
            Console.WriteLine("Enter Book Data:");
            Console.Write("Book id >> ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Book Name >> ");
            name = Console.ReadLine();

            Console.Write("Book Issued_to >> ");
            Issued_to = Console.ReadLine();

            StreamWriter file = new StreamWriter(Book_file, append: true);
            file.WriteLine($"{id}\t{name}\t{Issued_to}");
            file.Flush();
            file.Close();
        }

        public void viewBook()
        {
            StreamReader file = new StreamReader(Book_file);

            string[] outputs = file.ReadToEnd().Split("\n");
            try
            {
                for (int i = 0; i < (outputs.Length - 1); i++)
                {
                    string[] variable = outputs[i].Split("\t");
                    id = Convert.ToInt32(variable[0]);
                    name = variable[1];
                    Issued_to = variable[2];
                    Console.WriteLine($"{id}\t{name}\t{Issued_to}");
                    file.Close();
                }
            }
            catch
            {
                Console.Write("file not exist");
            }
        }

        public void searchBook(int query)
        {

            bool found = false;
            StreamReader file = new StreamReader(Book_file);

            string[] outputs = file.ReadToEnd().Split("\n");
            try
            {
                for (int i = 0; i < (outputs.Length - 1); i++)
                {
                    string[] variable = outputs[i].Split("\t");
                    id = Convert.ToInt32(variable[0]);
                    name = variable[1];
                    Issued_to = variable[2];
                    if (id == query)
                    {
                        found = true;
                        Console.WriteLine($"{id}\t{name}\t{Issued_to}");

                    }



                }
                if (found)
                {
                    Console.WriteLine($"target Viewd");
                }
                else
                {
                    Console.WriteLine($"Book not availble having ID {query} in files");
                }

                file.Close();

                //Console.WriteLine($"Book not availble having {query} in files");

            }
            catch
            {
                Console.WriteLine("file not exist");
            }
        }

        public void updateBook(int query)
        {
            bool found = false;

            StreamReader fileR = new StreamReader(Book_file);
            string[] outputs = fileR.ReadToEnd().Split("\n");
            fileR.Close();
            File.Delete(Book_file);
            StreamWriter fileW = new StreamWriter(Book_file, append: true);
            for (int i = 0; i < (outputs.Length - 1); i++)
            {
                string[] variables = outputs[i].Split("\t");
                id = Convert.ToInt32(variables[0]);
                name = variables[1];
                Issued_to = variables[2];

                if (id == query)
                {
                    found = true;
                    Console.Clear();
                    Console.WriteLine($"{id}\t{name}\t{Issued_to}");

                    Console.WriteLine("Modify record: ");
                    Console.Write("Book id >> ");
                    id = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Book Name >> ");
                    name = Console.ReadLine();

                    Console.Write("Book Issued_to >> ");
                    Issued_to = Console.ReadLine();

                    fileW.WriteLine($"{id}\t{name}\t{Issued_to}");
                }
                else
                {
                    fileW.WriteLine($"{id}\t{name}\t{Issued_to}");
                }
            }
            if (found)
            {
                Console.WriteLine($"record having ID {query} is updated ");
            }
            else
            {
                Console.WriteLine($"Book not availble having ID {query} in files");
            }

            fileW.Close();
        }

        public void deleteBook(int query)
        {
            bool found = false;
            StreamReader fileR = new StreamReader(Book_file);
            string[] outputs = fileR.ReadToEnd().Split("\n");
            fileR.Close();
            File.Delete(Book_file);
            StreamWriter fileW = new StreamWriter(Book_file, append: true);
            for (int i = 0; i < (outputs.Length - 1); i++)
            {
                string[] variables = outputs[i].Split("\t");
                id = Convert.ToInt32(variables[0]);
                name = variables[1];
                Issued_to = variables[2];

                if (id == query)
                {
                    found = true;
                    Console.WriteLine($"{id}\t{name}\t{Issued_to}");

                }
                else
                {
                    fileW.WriteLine($"{id}\t{name}\t{Issued_to}");
                }
            }
            if (found)
            {
                Console.WriteLine($"record having ID {query} is deleted ");
            }
            else
            {
                Console.WriteLine($"Book not availble having ID {query} in files");
            }


            fileW.Close();
        }

    }
}