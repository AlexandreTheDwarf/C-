# Exercice - Implémenter l’instruction foreach [link](https://learn.microsoft.com/fr-fr/training/modules/csharp-arrays/3-exercise-foreach)

## Mon code :

```
int[] inventory = { 200, 450, 700, 175, 250 };

int sum = 0;
int bin = 0;


foreach (int items in inventory)
{
    sum += items;
    bin++;

    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");
```