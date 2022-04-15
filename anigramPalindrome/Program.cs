// requests character array and an int that represnets length of that character array and sorts the character array using bubble sort algorithm
void bubbleSortString(char[] x, int n)

{
    //var arr = x.ToCharArray();
    char temp;

     // Sorting characters using bubble sort
    for (int j = 0; j < n - 1; j++)
    {
        for (int i = j + 1; i < n; i++)
        {
            if (x[j].CompareTo(x[i]) > 0)
            {
                temp = x[j];
                x[j] = x[i];
                x[i] = temp;
            }
        }
    }
}

// Requests array of characters and a an int that represents length of that character array and returns reverse string of that character array
string reverseCharacterArray(char[] x, int n)
{
    char[] arr = new char[n];
    String newString;

    for(int i = 0; i < n; i++)
    {

        arr[arr.Length-1 - i] = x[i];
    }

    newString = new String(arr);

    return newString;
}

// Requests string and returns true or false for Palindrome
bool palindromeCheck(string x)
{
    x = x.ToLower();
    var xArray = x.ToCharArray();


    string y = reverseCharacterArray(xArray, xArray.Length);


    if (x==y)
    {
        return true;
    }
    else 
    {
        return false;
    }
}

// Requests two string variables and returns true or false values for whether they are anigrams
bool anigramCheck(string x, string y)
{

    x = x.ToLower();
    y = y.ToLower();
    var xArray = x.ToCharArray();
    var yArray = y.ToCharArray();

    // Use bubble sort to sort strings
    bubbleSortString(xArray, x.Length);
    bubbleSortString(yArray, y.Length);

    // Create new strings from array of sorted characters
    x = new String(xArray);
    y = new String(yArray);

    // if/else statement to check if x == y
    if(x == y){
        return true;
    }
    else
    {
        return false;
    }
}

// Request for the first String
Console.Write("Please enter string 1: ");
String stringOne = Console.ReadLine();

// Request for the second String
Console.Write("Please enter string 2: ");
String stringTwo = Console.ReadLine();

if(palindromeCheck(stringOne)){
    Console.WriteLine($"{stringOne} is a palindrome!");
}
else
{
    Console.WriteLine($"Sorry, {stringOne} is not a palindrome");
}

if(palindromeCheck(stringTwo)){
    Console.WriteLine($"{stringTwo} is a palindrome!");
}
else
{
    Console.WriteLine($"Sorry, {stringTwo} is not a palindrome");
}

if(anigramCheck(stringOne, stringTwo)){
    Console.WriteLine($"{stringOne} & {stringTwo} are aningrams!");
}
else
{
    Console.WriteLine($"Sorry, {stringOne} & {stringTwo} are not  aningrams");
}
