## Effectuer une activité de défi pour des instructions d’itération et de sélection imbriquées

### Défi : Signaler les ID de commande qui nécessitent une investigation plus approfondie : [lien du Défi](https://learn.microsoft.com/fr-fr/training/modules/csharp-arrays/4-challenge)

#### Ma réponse :
```
string[] Datas = new string[] {"B123","C234","A345","C15","B177","G3003","C235","B179"};

foreach (string Data in Datas)
{
    if (Data.StartsWith("B"))
    {
        Console.WriteLine($"{Data} is a corrupted data");
    }
}
```

#### Solution Microsoft :
```
string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}
```

Je pouvais raccourcir mon code pour la création du tableau en utilisant leur syntaxe, je pensais que "new string[]" était obligatoire. Sinon mon code était correcte dans l'ensemble.
