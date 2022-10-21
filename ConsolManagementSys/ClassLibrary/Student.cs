using System;

namespace ClassLibrary
{
    

    public class Student
    {
        int id;
        string name;
        string program;

        string student_file = "student.dat";



        public void creatStudent()
        {
            Console.WriteLine("Enter Student Data:");
            Console.Write("Student id >> ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Student Name >> ");
            name = Console.ReadLine();

            Console.Write("Student Program >> ");
            program = Console.ReadLine();

            StreamWriter file = new StreamWriter(student_file, append: true);
            file.WriteLine($"{id}\t{name}\t{program}");
            file.Flush();
            file.Close();
        }

        public void viewStudent()
        {
            StreamReader file = new StreamReader(student_file);
            
            string[] outputs = file.ReadToEnd().Split("\n");
            try
            {
                for(int i = 0; i < (outputs.Length - 1); i++)
                {
                    string[] variable = outputs[i].Split("\t");
                    id=Convert.ToInt32(variable[0]);
                    name=variable[1];
                    program = variable[2];
                    Console.WriteLine($"{id}\t{name}\t{program}");
                    file.Close();
                }
            }
            catch
            {
                Console.Write("file not exist");
            }
        }

        public void searchStudent(int query)
        {

            bool found = false;
            StreamReader file = new StreamReader(student_file);

            string[] outputs = file.ReadToEnd().Split("\n");
            try
            {
                for (int i = 0; i < (outputs.Length - 1); i++)
                {
                    string[] variable = outputs[i].Split("\t");
                    id = Convert.ToInt32(variable[0]);
                    name = variable[1];
                    program = variable[2];
                    if (id == query)
                    {
                        found = true;
                        Console.WriteLine($"{id}\t{name}\t{program}");
                        
                    }
                    


                }
                if (found)
                {
                    Console.WriteLine($"target Viewd");
                }
                else
                {
                    Console.WriteLine($"student not availble having ID {query} in files");
                }

                file.Close();

                //Console.WriteLine($"student not availble having {query} in files");

            }
            catch
            {
                Console.WriteLine("file not exist");
            }
        }

        public void updateStudent(int query)
        {
            bool found = false;

            StreamReader fileR = new StreamReader(student_file);
            string[] outputs = fileR.ReadToEnd().Split("\n");
            fileR.Close();
            File.Delete(student_file);
            StreamWriter fileW = new StreamWriter(student_file, append: true);
            for (int i = 0; i < (outputs.Length - 1); i++)
            {
                string[] variables = outputs[i].Split("\t");
                id = Convert.ToInt32(variables[0]);
                name = variables[1];
                program = variables[2];

                if (id == query)
                {
                    found = true;
                    Console.Clear();
                    Console.WriteLine($"{id}\t{name}\t{program}");
                    
                    Console.WriteLine("Modify record: ");
                    Console.Write("Student id >> ");
                    id = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Student Name >> ");
                    name = Console.ReadLine();

                    Console.Write("Student Program >> ");
                    program = Console.ReadLine();

                    fileW.WriteLine($"{id}\t{name}\t{program}");
                }
                else
                {
                    fileW.WriteLine($"{id}\t{name}\t{program}");
                }
            }
            if (found)
            {
                Console.WriteLine($"record having ID {query} is updated ");
            }
            else
            {
                Console.WriteLine($"student not availble having ID {query} in files");
            }

            fileW.Close();
        }

        public void deleteStudent(int query)
        {
            bool found = false;
            StreamReader fileR = new StreamReader(student_file);
            string[] outputs = fileR.ReadToEnd().Split("\n");
            fileR.Close();
            File.Delete(student_file);
            StreamWriter fileW = new StreamWriter(student_file, append: true);
            for (int i = 0; i < (outputs.Length - 1); i++)
            {
                string[] variables = outputs[i].Split("\t");
                id = Convert.ToInt32(variables[0]);
                name = variables[1];
                program = variables[2];

                if (id == query)
                {
                    found = true;
                    Console.WriteLine($"{id}\t{name}\t{program}");
                    
                }
                else
                {
                    fileW.WriteLine($"{id}\t{name}\t{program}");
                }
            }
            if (found)
            {
                Console.WriteLine($"record having ID {query} is deleted ");
            }
            else
            {
                Console.WriteLine($"student not availble having ID {query} in files");
            }


            fileW.Close();
        }

    }
}