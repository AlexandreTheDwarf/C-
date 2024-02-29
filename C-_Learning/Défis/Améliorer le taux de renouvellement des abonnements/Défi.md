## Effectuer une activité de défi pour appliquer des règles métier

### Défi : Améliorer le taux de renouvellement des abonnements : [lien du Défi](https://learn.microsoft.com/fr-fr/training/modules/csharp-if-elseif-else/4-challenge)

#### Ma réponse :
```

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.Write("Your subscription has expired.");
}
else if (daysUntilExpiration == 1 )
{
    discountPercentage = 20;
    Console.Write($"You got {daysUntilExpiration} day until your subscription expires.");
    Console.WriteLine($"Renew now and save {discountPercentage} %!");
}
else if (daysUntilExpiration <= 5 )
{
    discountPercentage = 10;
    Console.Write($"You got {daysUntilExpiration} days until your subscription expires.");
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration <= 10 )
{
    Console.Write($"You got {daysUntilExpiration} days until your subscription expires.");
    Console.WriteLine("Your subscription will expire soon.  Renew now!");
}
else
{
    Console.WriteLine("");
}
```

#### Solution Microsoft :
```
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}
```

J'ai compris en voyant la solution de microsoft que je pouvais mettre le message de la remise dans une condition if a part plus tot que de l'insérer dans la logique else-if au dessus.