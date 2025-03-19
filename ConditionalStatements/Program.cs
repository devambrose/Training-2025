// See https://aka.ms/new-console-template for more information

// high level -> javascript  | v8- C++ - > Machine

// low level -> c# C++ -> 1010

// machine language  1 0 

// Binary Langugae


// true or false 

string truthy = "";

if (1 == 0)
{
    truthy = "true";
}
else
{
    truthy = "false";
}

//truthy= 1 ==0   ? "true" : "false";

// binary langugage


// create an application
// that give congrats to people above the age of 30 

// interactive 

// welcome the user
// user type in the age
// check if the age is above 30
// give congrats if yes
// give the non-congrats 

Console.WriteLine("Welcome Millenials\n \n");

while (true)
{
    Console.WriteLine("Type in your age :");
    string ageText = Console.ReadLine();

    Console.WriteLine("Do you have a job (y or n ) :");
    string jobStatus = Console.ReadLine();
    try
    {
        int age = Int32.Parse(ageText);


        // > < <= >=   30  31 32 33

        //   and  or 

        // millenial has a job and is above 30
        // jobStatus == true and age > 30

        // Millenial has a job or is above 30
        // (jobStatus == true or age > 30) == true

        // true or false  == true

        // true and false == false 

        // false and false == false

        // true and true == true 

        // true or true == true

        // or = | 

        // and &

        /**
         * greater than 30
         * 31 32 33 34
         * 
         * greater than or equal to >=
         * 30 31 .... &
         * 
         * less than 
         * 29 28 ..... -&
         * 
         * less than or equal to 
         * 
         * 30 29 28 ..... -& Y y
         * 
         */

        if (age > 30 | jobStatus.ToLower() == "y")
        {

            Console.WriteLine("Thank you for growing old");
        }
        else
        {
            Console.WriteLine("Keep on pushing");
        }


    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);

    }

}

Console.ReadLine();


