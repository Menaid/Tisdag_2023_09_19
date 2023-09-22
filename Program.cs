// List, Switch Case, HashMap, Dictionary

// Switch 

//string[] week = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

//foreach (string day in week)
//{
//    switch (day)
//    {
//        case "Monday":
//            Console.WriteLine("Go to work");
//            break;

//        case "Tuesday":
//            Console.WriteLine("Go to work");
//            break;
//    }
//}





//List<string> audiParts = new List<string>()
//{
//    "Part 1",
//        "Part 2",
//};

//audiParts.Add(item: "Turbo");
//audiParts.Add(item: "Koppling");

//foreach (string part in audiParts)
//{
//    Console.WriteLine(part);
//}





// Dictionary. Key Value mapping

//Dictionary<string, int> nameToBirthYear = new Dictionary<string, int>();

//nameToBirthYear.Add("Manuel", 2000);
//nameToBirthYear.Add("Arvid", 2003);
//nameToBirthYear.Add("Klas", 1989);
//nameToBirthYear.Add("Paulina", 1994);
//nameToBirthYear.Add("Ali", 1999);

//Console.WriteLine(nameToBirthYear["Manuel"]);
//nameToBirthYear["Manuel"] = 2001;
//Console.WriteLine(nameToBirthYear["Manuel"]);


string sentence = "These Are Some Words";
string[] words = sentence.Split(" ");

foreach (string word in words)
{
    Console.WriteLine(word);
}


/*
 * // Switch

string[] week = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday", "Someday" };

foreach (string day in week)
{
    switch (day)
    {
        case "Monday":
        case "Tuesday":
        case "Wednesday":
        case "Thursday":
        case "Friday":
            Console.WriteLine("Go to work");
            break;
        case "Saturday":
        case "Sunday":
            Console.WriteLine("Stay home");
            break;
        default:
            Console.WriteLine("Not a week day we know of");
            break;
    }
}

// List

List<string> audiParts = new List<string>(week)
{
    "Turbo",
    "Koppling",
};

audiParts.Add("stuff");

foreach (string part in audiParts)
{
    Console.WriteLine(part);
}

// Dictionary
Dictionary<string, int> nameToBirthYear = new Dictionary<string, int>();

nameToBirthYear.Add("manuel", 2000);
nameToBirthYear.Add("arvid", 2003);
nameToBirthYear.Add("klas", 1989);
nameToBirthYear.Add("paulina", 1994);
nameToBirthYear.Add("ali", 1999);

Console.WriteLine(nameToBirthYear["manuel"]);
nameToBirthYear["manuel"] = 2001;
Console.WriteLine(nameToBirthYear["manuel"]);

nameToBirthYear.Add("X", 0);
nameToBirthYear.Add("Y", 3);
nameToBirthYear.Add("Z", 6);

nameToBirthYear["manuel"] = 2000;
string choice = Console.ReadLine().ToLower();


switch (nameToBirthYear.ContainsKey(choice))
{
    case true:
        Console.WriteLine("Their birth year is: " + nameToBirthYear[choice]);
        break;
    case false:
        Console.WriteLine("We don't have their information stored");
        break;
}

*/