## Effectuer une activité de défi pour améliorer la lisibilité du code

### Défi : appliquer des instructions de style pour améliorer la lisibilité : [lien du Défi](https://learn.microsoft.com/fr-fr/training/modules/csharp-readable-code/5-challenge)

#### Ma réponse :
```
string str = "The quick brown fox jumps over the lazy dog.";

// convert the message into a char array
char[] charMessage = str.ToCharArray();

// Reverse the chars
Array.Reverse(charMessage);

int x = 0;

// count the o's
foreach (char i in charMessage) 
    { if (i == 'o') { x++; } }

// convert it back to a string
string new_message = new String(charMessage);

// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");
```

#### Solution Microsoft :
```
/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");
```

J'ai mal interprété l'ennoncé et je ne pensais pas devoir aller ci loin dans la modification du code.

