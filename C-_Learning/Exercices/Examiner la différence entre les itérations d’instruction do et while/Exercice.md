# Effectuer une activité de défi pour différencier les instructions d’itération do et while : [Link](hhttps://learn.microsoft.com/fr-fr/training/modules/csharp-do-while/5-exercise-challenge-differentiate-while-do-statements)

## Mon code :

### Projet de programmation 1 : écrire du code qui valide l’entrée d’un entier
```
Console.WriteLine("Enter an integer value between 5 and 10");

int number;
bool isValidInput;

do
{   
    string input = Console.ReadLine();

    if (input != null)
    {
        isValidInput = int.TryParse(input, out number);

        if (isValidInput && number >= 5 && number <= 10)
        {
            break;
        }
        else if (!isValidInput)
        {
            Console.WriteLine($"Sorry, \"{input}\" is not a valid integer. Please try again.");
        }
        else
        {
           Console.WriteLine($"You entered {number}. Please enter a number between 5 and 10."); 
        }
    }
    else
    {
        Console.WriteLine("Null input detected. Please try again.");
        isValidInput = false;
    }
    
} while (true);

Console.WriteLine($"Your input value ({number}) has been accepted.");
```

### Projet de programmation 2 : écrire du code qui valide l’entrée d’une chaîne

```
Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

string roles = ""; // Initialise la variable en dehors de la boucle
bool isValidInput;

do
{   
    string input = Console.ReadLine();

    if (input != null)
    {
        // Comparaison avec les valeurs autorisées en utilisant des chaînes en minuscules
        string inputLower = input.ToLower().Trim(); // Convertit l'entrée en minuscules et supprime les espaces en début et fin de chaîne
        if (inputLower == "administrator" || inputLower == "manager" || inputLower == "user")
        {
            roles = inputLower; // Affecte la valeur en minuscules à la variable roles
            isValidInput = true;
        }
        else
        {
            Console.WriteLine($"The role name that you entered, {inputLower} is not valid. Enter your role name (Administrator, Manager, or User)");
            isValidInput = false;
        }
    }
    else
    {
        Console.WriteLine("Null input detected. Please try again.");
        isValidInput = false;
    }
    
} while (!isValidInput); // Sort de la boucle lorsque l'entrée est valide

Console.WriteLine($"Your input value ({roles}) has been accepted.");
```

### Projet de code 3 – Écrire du code qui traite le contenu d’un tableau de chaînes

```
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

List<int> periodLocations = new List<int>();

foreach (var myString in myStrings)
{
    int location = myString.IndexOf(".");
    if (location != -1)
    {
        periodLocations.Add(location);
    }

    int startIndex = 0;
    int endIndex;
    while (startIndex < myString.Length && (endIndex = myString.IndexOf(".", startIndex)) != -1)
    {
        string phrase = myString.Substring(startIndex, endIndex - startIndex).TrimStart();
        Console.WriteLine(phrase);
        startIndex = endIndex + 1;
    }
    // Print the last phrase if it exists
    if (startIndex < myString.Length)
    {
        string lastPhrase = myString.Substring(startIndex).TrimStart();
        Console.WriteLine(lastPhrase);
    }
}
```

