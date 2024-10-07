// See https://aka.ms/new-console-template for more information
double radius = 5;
double smlallside = 2 * radius;
double smallside = radius * math.Sqrt(2);
double smallarea = smallside * smallside;
double largside = smallside * math.Sqrt(2);
double largarea = largside * largside;
double areadifference = largarea - smallarea;
 Console.WriteLine($"the difference is between the areas of the large and small squares:{areadifference}");





string[] input1 = { "@", "@", "@", "@", "@", "@" };
string[] input2 = { "x", "x", "x" };
string[] input3 = { "s", "s", "s" };
string[] input4 = { "@", "a", "@", "@", "@", "@" };
testjackpot(input1);
testjackpot(input2);
testjackpot(input3);
testjackpot(input4);
static void testjackpot(string[] input)
{
    bool jackpot = checkjackpot(input);
    if (jackpot)
    {
        Console.WriteLine("yes");
    }
    else
    {
        Console.WriteLine("no");
    }
}
static bool checkjackpot(string[] input)
{
    string firstsymbol = input[0];

    foreach (string symbol in input)
    {
        if (symbol != firstsymbol)
        {
            return false;
        }
    }

    return true;
}

int wins = 3;
int draws = 1;
int losses = 1;

int totalpoints = wins * 3 + draws * 1 + losses * 0;
Console.WriteLine(totalpoints);

int[][] hoursarray = {
            new int[] { 8, 8, 8, 8, 8, 0, 0 },
            new int[] { 8, 8, 8, 8, 8, 8, 0 },
            new int[] { 4, 4, 4, 4, 4, 0, 4 },
            new int[] { 5, 8, 8, 8, 8, 8, 8 }
        };


foreach (var hours in hoursarray)
{
    double totalincome = calculateincome(hours);
    Console.WriteLine("input: " + string.Join(", ", hours) + " -> output: $" + totalincome);
}


static double calculateincome(int[] hours)
{
    double totalincome = 0;


    for (int i = 0; i < hours.Length; i++)
    {
        int dailyhours = hours[i];
        if (i < 5)
        {
            if (dailyhours > 8)
            {
                totalincome += (8 * 10) + ((dailyhours - 8) * 15);
            }
            else
            {
                totalincome += dailyhours * 10;
            }
        }
        else
        {
            totalincome += dailyhours * 20;
        }
    }
    return totalincome;
}





int[] results1 = { 5, 8, 8, 9, 10 };
int improvementcount1 = countimprovements(results1);
Console.WriteLine("input 1: " + string.Join(", ", results1) + " -> output: " + improvementcount1);
int[] results2 = { 5, 5, 5, 5 };
int improvementcount2 = countimprovements(results2);
Console.WriteLine("input 2: " + string.Join(", ", results2) + " -> output: " + improvementcount2);
static int countimprovements(int[] results)
{
    int count = 0;


    for (int i = 1; i < results.Length; i++)
    {

        if (results[i] > results[i - 1])
        {
            count++;
        }
    }

    return count;
}

string[] words = { "Hello", "World", "Programming", "communication" };
int N1 = 7;
PrintWordsOfLength(words, N1);
int N2 = 15;
PrintWordsOfLength(words, N2);

static void PrintWordsOfLength(string[] words, int N)
{
    bool found = false;

    foreach (string word in words)
    {

        if (word.Length == N)
        {
            Console.Write(word + " ");
            found = true;
        }
    }
    if (!found)
    {
        Console.WriteLine("No elements found");
    }
    else
    {
        Console.WriteLine();
    }
}