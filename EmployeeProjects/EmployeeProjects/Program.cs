<<<<<<< HEAD
﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int Is_FULL_TIME = 1;
=======
﻿int Is_FULL_TIME = 1;
>>>>>>> UC-1
Random random = new Random();
int empCheck = random.Next(0, 2);
if (empCheck == Is_FULL_TIME)
{
    Console.WriteLine("Employee is Present");
<<<<<<< HEAD
        }
=======
}
>>>>>>> UC-1
else
{
    Console.WriteLine("Employee is Absent");
}