## Effectuer une activité de défi impliquant l’utilisation des instructions for et if

### Défi de code - Implémenter les règles du défi FizzBuzz: [lien du Défi](https://learn.microsoft.com/fr-fr/training/modules/csharp-for/3-challenge)

#### Ma réponse :
```
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine($"{i} - FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine($"{i} - Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine($"{i} - Buzz");
    }
    else
    {
        Console.WriteLine($"{i}");
    }
}
```

#### Solution Microsoft :
```
for (int i = 1; i < 101; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else
        Console.WriteLine($"{i}");
}
```

