using FCC_Course___College_Algebra.Units.Unit_1;

bool isRunning = true;
while (isRunning)
{
    Console.Clear();
    Console.WriteLine("== FreeCodeCamp - College Algebra w/ Python ==");
    Console.WriteLine("======= Made with C# | Joshua Grossman =======");
    Console.Write("");
    Console.WriteLine("Select an option:");
    Console.WriteLine("Unit 1");
    Console.WriteLine("Lesson 1: Intro to Course (NO PRGM)");
    Console.WriteLine("Lesson 2: Solving Proportions");
    
    Console.WriteLine("Select a Unit (by number)");
    string unitChoice = Console.ReadLine();
    Console.WriteLine("");

    switch (unitChoice.ToUpper())
    {
        case "1":
            Unit1Menu();
            break;
    }
}

static void Unit1Menu()
{
    Console.Clear();
    Console.WriteLine("Unit 1");
    Console.WriteLine("Lesson 1: Intro to Course (NO PRGM)");
    Console.WriteLine("Lesson 2: Solving Proportions");
    Console.WriteLine("");
    Console.WriteLine("Select a Lesson (by number)");
    string lessonChoice = Console.ReadLine();

    switch (lessonChoice.ToUpper())
    {
        case "1":
            Console.WriteLine("NO PROGRAM IS AVALIBLE FOR LESSON 1");
            Console.WriteLine("Press any key to go back...");
            Console.ReadKey();
            break;
        case "2":
            Console.Clear();
            Lesson2.Init();
            break;
    }
}

