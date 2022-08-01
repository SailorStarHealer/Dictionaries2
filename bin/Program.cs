// See https://aka.ms/new-console-template for more information
/*
 * 
IDictionary<int, string> hostCountries = new Dictionary<int, string>();
hostCountries[2000] = "Australia";
hostCountries[2004] = "Greece";
hostCountries[2008] = "China";
hostCountries[2012] = "Britain";
hostCountries[2016] = "Brazil";
hostCountries[2020] = "Japan";
hostCountries[2024] = "France";
hostCountries[2028] = "North America";

var random = new Random();

int year = 2000 + random.Next(hostCountries.Count) * 4;

Console.WriteLine($"Which country hosted the summer olympics in {year}?");

string answer = Console.ReadLine();

//Console.WriteLine(hostCountries[year]);

if (hostCountries[year] == (answer))
{
    Console.WriteLine("Correct answer!");
}
else
{
    Console.WriteLine($"Too bad. The correct answer was");
    Console.Write(hostCountries[year]);
} */

//Creates a new Dictionary full of countries and their names.
//Each capital is assigned to a country value.
//It is made out of Strings as a SortedList.

//Mission 2
/*

 IDictionary<string, string> countryCapitals = new SortedList<string, string>();
countryCapitals["India"] = "New Dehli";
countryCapitals["Palau"] = "Ngerulmud";
countryCapitals["Niger"] = "Niamey";
countryCapitals["Cyprus"] = "Nicosia";
countryCapitals["Mauritania"] = "Nouakchott";
countryCapitals["New Caledonia"] = "Nouméa";
countryCapitals["Tonga"] = "Nuku'alofa";
countryCapitals["Kazakhstan"] = "Nur-Sultan";


//Creates a new random engine.
var random = new Random();

//Generates a new list of strings by copying the dictionary,
//pulls a random from them.
int sort = random.Next(0, 8);
var countries = new List<string>(countryCapitals.Keys);


var country = countries[sort];

//Asks the reader what the priorly generated 'countries' correpsonds to.
Console.WriteLine($"What is the capital of {country}?");

//Reads the answer that the user generates and assigns it a string value.
string answer = Console.ReadLine();

//Writes out the answer to the question in 'countries'
Console.WriteLine(countryCapitals[country]);

//Outputs correct answer if Readline value corepponds to 
if (countryCapitals[country] == (answer))
{
    Console.WriteLine("Correct answer!");
}
else
{
    Console.WriteLine($"Too bad. The correct answer was");
    Console.Write(countryCapitals[country]);
}

//MISSION 3 below/ 
//Create dictionary
*/
//Creates a dictionary.
IDictionary<string, int> playerScore = new SortedList<string, int>();

int zero = 0;

do
{

    // Input name using readline
    Console.WriteLine("Please enter a name");
    string playerName = Console.ReadLine();

    //to create a new dictionary element with an assigned value of one.

    // If loop.
    //The starting condition is that the pre-assigned custom value playerName is inputted into the Console.Readline.
    if
    (playerScore.ContainsKey(playerName))
    {
        //This means that the value at that point in the dictionary increases by one.
        playerScore[playerName] += 1;
    }

    else
    {//If the name is not located in the dictionary, a dictionary value with '1' is created for it.
        playerScore[playerName] = 1;
    }

    //for each playername in playerScore, output a list of playerName + score

    for (int i = 0; i < playerScore.Count; i++)
    {
        Console.WriteLine("{0}, {1}",
                                                playerScore.ElementAt(i).Key,
                                                playerScore.ElementAt(i).Value);
    }

    // foreach (string playerName1 in playerScore.Keys)
    // {
    //   Console.WriteLine($"Score is {playerScore["playerName"]}!");
    //}
}
while (zero < 1);

/// </summary>
//Create dictionary GO!
//Input name using readline to create a new dictionary element with an assigned value of one. GO!
//Make the program check the dictionary to see if the inputted name already exists. GO!
//If it exists, +1 to the int value. GO!
//Display dictionary(??????) and allow more console readline. GO!

//Repeated instructions after every iteration of the quiz (Do loop).
//Add this to a loop.
//the loop should repeat after every iteration of the quiz.
//When zero player name is inputed, end loop.


/*
 * var random = new Random();



IDictionary<string, string> countryCapitals = new SortedList<string, string>();
countryCapitals["India"] = "New Dehli";
countryCapitals["Palau"] = "Ngerulmud";
countryCapitals["Niger"] = "Niamey";
countryCapitals["Cyprus"] = "Nicosia";
countryCapitals["Mauritania"] = "Nouakchott";
countryCapitals["New Caledonia"] = "Nouméa";
countryCapitals["Tonga"] = "Nuku'alofa";
countryCapitals["Kazakhstan"] = "Nur-Sultan";


IDictionary<string, int> playerScore = new SortedList<string, int>();
int counter = 10;
do
{

    //Generates a new list of strings by copying the dictionary,
    //pulls a random from them.
    int sort = random.Next(0, 9);
    var countries = new List<string>(countryCapitals.Keys);


    //Asks the reader what the priorly generated 'countries' correpsonds to.
    Console.WriteLine($"What is the capital of {country}?");

    //Reads the answer that the user generates and assigns it a string value.
    string answer = Console.ReadLine();

    //Writes out the answer to the question in 'countries'
    Console.WriteLine(countryCapitals[country]);

    //Outputs correct answer if Readline value corepponds to 
    if (countryCapitals[country] == (answer))
    {
        Console.WriteLine("Correct answer!");
    }
    else
    {
        Console.WriteLine($"Too bad. The correct answer was");
        Console.Write(countryCapitals[country]);
    }

    string playerName = Console.ReadLine();

    //to create a new dictionary element with an assigned value of one.
    if
    (playerScore.ContainsKey("playerName"))
    {
        playerScore["playerName"] += 1;
    }

    else
    {
        playerScore["playerName"] = 1;

        Console.Write(playerName);

        playerScore["playerName"] = 1;
    }

    foreach (string playerName1 in playerScore.Keys)
    {
        Console.WriteLine($"Hello {playerName.ToUpper()}!");
    }
} while (counter == 10); */