## Exercice – Effectuer une activité de défi à l’aide de l’étendue des variables

### Défi de code : mettre à jour le code problématique dans l’éditeur de code : [lien du Défi](https://learn.microsoft.com/fr-fr/training/modules/csharp-code-blocks/4-exercise-challenge-variable-scope)

#### Ma réponse :
```
int[] numbers = { 4, 8, 15, 16, 23, 42 };

int total = 0;

foreach (int number in numbers)
{
    total += number;

    if (number == 42)
    {
       bool found = true;
        
        if (found) 
        {
            Console.WriteLine("Set contains 42");
        }
    }
}

Console.WriteLine($"Total: {total}");
```

#### Solution Microsoft :
```
int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;
    if (number == 42)
        found = true;
}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");
```

